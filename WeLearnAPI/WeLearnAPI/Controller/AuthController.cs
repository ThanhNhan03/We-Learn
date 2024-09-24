using AutoMapper;
using DMS_API.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using WeLearnAPI.Models.Domain;
using WeLearnAPI.Models.DTO.RequestDto;
using WeLearnAPI.Repository.Interface;
using WeLearnAPI.Services;

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
            RoleManager<IdentityRole<Guid>> roleManager)
        {
            _unitOfWork = unitOfWork;
            _userManager = userManager;
            _adminManager = adminManager;
            _mapper = mapper;
            _authService = authService;
            _emailSenderService = emailSenderService;
            _roleManager = roleManager;
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
                    await _emailSenderService.SendEmailAsync(user.Email, "Confirm your email", message);
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

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginRequestDTO request)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var admin = await _adminManager.FindByEmailAsync(request.Email);

            if (admin != null && await _adminManager.CheckPasswordAsync(admin, request.Password))
            {
                var roles = await _adminManager.GetRolesAsync(admin);
                var role = roles.FirstOrDefault(); // Assuming an admin has only one role

                if (role == null)
                {
                    return BadRequest("User role not found");
                }

                var token = await _authService.GenerateJwtToken(admin, role);
                return Ok(new { token, role });
            }

            var user = await _userManager.FindByEmailAsync(request.Email);

            if (user != null && await _userManager.CheckPasswordAsync(user, request.Password))
            {
                var token = await _authService.GenerateJwtToken(user, "User");
                return Ok(new { token, role = "User" });
            }

            return Unauthorized("Cannot Authorized");
        }
    }
}
