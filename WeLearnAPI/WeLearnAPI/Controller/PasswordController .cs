﻿using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using WeLearnAPI.Models.DTO.RequestDto;
using WeLearnAPI.Services.Interface;


namespace YourNamespace.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PasswordController : ControllerBase
    {
        private readonly UserManager<Users> _userManager;
        private readonly IEmailService _emailSenderService;
        private readonly IConfiguration _configuration;

        public PasswordController(UserManager<Users> userManager, IEmailService emailSenderService, IConfiguration configuration)
        {
            _userManager = userManager;
            _emailSenderService = emailSenderService;
            _configuration = configuration;
        }


        [HttpPost("forgot-password")]
        public async Task<IActionResult> ForgotPassword([FromBody] ForgotPasswordRequestDTO request)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var user = await _userManager.FindByEmailAsync(request.Email);
            if (user == null)
                return NotFound("User not found");

            var token = await _userManager.GeneratePasswordResetTokenAsync(user);

            user.RememberToken = token;
            await _userManager.UpdateAsync(user);

            // Lấy URL của client-app từ appsettings
            var clientAppUrl = _configuration["ClientAppUrl"];

            // Tạo link reset password cho client-app
            var resetPasswordLink = $"{clientAppUrl}/reset-password?token={Uri.EscapeDataString(token)}&email={Uri.EscapeDataString(user.Email)}";

            var message = $"Click the link to reset your password: <a href='{resetPasswordLink}'>Reset Password</a>";
            await _emailSenderService.SendEmailAsync(user.Email, "Reset your password", message);

            return Ok(new { message = "Please check your email to reset your password." });
        }

        [HttpPost("reset-password")]
        public async Task<IActionResult> ResetPassword([FromBody] ResetPasswordRequestDTO request)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var user = await _userManager.FindByEmailAsync(request.Email);
            if (user == null)
                return NotFound("User not found");

            var result = await _userManager.ResetPasswordAsync(user, request.Token, request.NewPassword);
            if (result.Succeeded)
            {
                user.RememberToken = null;
                await _userManager.UpdateAsync(user);

                return Ok("Password has been reset successfully");
            }

            return BadRequest(result.Errors);
        }

        [HttpPost("change-password")]
        public async Task<IActionResult> ChangePassword([FromBody] ChangePasswordRequestDTO request)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var user = await _userManager.FindByEmailAsync(request.Email);
            if (user == null)
                return NotFound("User not found");

            var result = await _userManager.ChangePasswordAsync(user, request.CurrentPassword, request.NewPassword);
            if (result.Succeeded)
            {
                return Ok("Password has been changed successfully");
            }

            return BadRequest(result.Errors);
        }
    }
}
