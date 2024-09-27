using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using WeLearnAPI.Models.Domain;
using WeLearnAPI.Models.DTO.RequestDto;
using WeLearnAPI.Models.DTO.ResponeDto;
using WeLearnAPI.Repository.Interface;
using WeLearnAPI.Services.Interface;

namespace WeLearnAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly UserManager<Users> _userManager;
        private readonly UserManager<Admin> _adminManager;
        private readonly IMapper _mapper;
        private readonly IAuthService _authService;
        private readonly IJwtTokenService _jwtTokenService;
        private readonly IEmailService _emailSenderService;
        private readonly RoleManager<IdentityRole<Guid>> _roleManager;


        public AuthController(
            IUnitOfWork unitOfWork,
            UserManager<Users> userManager,
            UserManager<Admin> adminManager,
            IConfiguration configuration,
            IMapper mapper,
            IAuthService authService,
            IEmailService emailSenderService,
            RoleManager<IdentityRole<Guid>> roleManager,
            IJwtTokenService jwtTokenService)
        {
            _unitOfWork = unitOfWork;
            _userManager = userManager;
            _adminManager = adminManager;
            _mapper = mapper;
            _authService = authService;
            _emailSenderService = emailSenderService;
            _roleManager = roleManager;
            _jwtTokenService = jwtTokenService;
        }

        [HttpPost("register/user")]
        public async Task<IActionResult> RegisterUser([FromBody] RegisterRequestDTO request)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var user = _mapper.Map<Users>(request);
            user.EmailConfirmed = false;
            var result = await _userManager.CreateAsync(user, request.Password);

            if (result.Succeeded)
            {
                var token = await _userManager.GenerateEmailConfirmationTokenAsync(user);
                var confirmationLink = Url.Action(nameof(ConfirmEmail), "Auth",
                    new { userId = user.Id, token }, Request.Scheme);

                var message = $"Please confirm your account by clicking this link: <a href='{confirmationLink}'>Confirm your account</a>";

                var sendEmailTask = Task.Run(async () =>
                {
                    await _emailSenderService.SendEmailAsync(user.Email, "Confirm your email", message)
                    ;
                });

                return Ok(new { message = "User registered successfully. Please check your email to confirm your account." });
            }

            return BadRequest(result.Errors);
        }


        [HttpGet("confirm-email")]
        public async Task<IActionResult> ConfirmEmail(string userId, string token)
        {
            if (string.IsNullOrWhiteSpace(userId) || string.IsNullOrWhiteSpace(token))
                return BadRequest("User Id and Token are required");

            var user = await _userManager.FindByIdAsync(userId);
            if (user == null)
                return NotFound($"Unable to load user with ID '{userId}'.");

            var result = await _userManager.ConfirmEmailAsync(user, token);
            if (result.Succeeded)
                return Ok("Email confirmed successfully!");

            return BadRequest("Error confirming your email.");
        }


        [HttpPost("register/admin")]
        public async Task<IActionResult> RegisterAdmin([FromBody] RegisterRequestDTO request)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var admin = _mapper.Map<Admin>(request);
            var result = await _adminManager.CreateAsync(admin, request.Password);

            if (result.Succeeded)
            {
                if (!await _roleManager.RoleExistsAsync("Admin"))
                {
                    await _roleManager.CreateAsync(new IdentityRole<Guid>("Admin"));
                }

                await _adminManager.AddToRoleAsync(admin, "Admin");

                await _unitOfWork.SaveChangesAsync();
                return Ok(new { message = "Admin registered successfully and assigned Admin role" });
            }

            return BadRequest(result.Errors);
        }

        [HttpPost("refresh-token")]
        public async Task<IActionResult> RefreshToken([FromBody] TokenRequestDTO tokenRequest)
        {
            if (tokenRequest is null || string.IsNullOrEmpty(tokenRequest.AccessToken) || string.IsNullOrEmpty(tokenRequest.RefreshToken))
                return BadRequest("Invalid client request");

            var principal = _jwtTokenService.GetPrincipalFromExpiredToken(tokenRequest.AccessToken);
            if (principal == null)
                return BadRequest("Invalid access token or refresh token");

            var userEmail = principal.Identity.Name;
            var user = await _userManager.FindByEmailAsync(userEmail);

            if (user == null || user.RefreshToken != tokenRequest.RefreshToken || user.RefreshTokenExpiryTime <= DateTime.Now)
                return BadRequest("Invalid refresh token");

            var newAccessToken = await _jwtTokenService.GenerateJwtToken(user, "User");
            var newRefreshToken = await _jwtTokenService.GenerateRefreshToken();

            user.RefreshToken = newRefreshToken;
            await _userManager.UpdateAsync(user);

            return Ok(new
            {
                AccessToken = newAccessToken,
                RefreshToken = newRefreshToken
            });
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginRequestDTO request)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            // Authenticate admin
            var (adminToken, adminRole) = await _authService.AuthenticateAdminAsync(request.Email, request.Password);
            if (adminToken != null)
            {
                return Ok(new { AccessToken = adminToken, RefreshToken = (string)null, role = adminRole });
            }

            // Authenticate user
            var user = await _userManager.FindByEmailAsync(request.Email);
            if (user != null)
            {
                if (!user.EmailConfirmed)
                {
                    return Unauthorized("Please confirm your email before logging in.");
                }

                var (userAccessToken, userRefreshToken, userRole) = await _authService.AuthenticateUserAsync(request.Email, request.Password);
                if (userAccessToken != null)
                {
                    return Ok(new { AccessToken = userAccessToken, RefreshToken = userRefreshToken, role = userRole });
                }
            }

            return Unauthorized("Invalid email or password.");
        }




    }
}
