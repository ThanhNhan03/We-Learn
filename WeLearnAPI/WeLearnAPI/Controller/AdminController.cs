using AutoMapper;
using DMS_API.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WeLearnAPI.Models.Domain;
using WeLearnAPI.Models.DTOs;
using WeLearnAPI.Repository.Interface;
using WeLearnAPI.Services;

namespace WeLearnAPI.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(Roles = "Admin")]
    public class AdminController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IAdminService _adminService;
        private readonly UserManager<Admin> _adminManager;
        private readonly IMapper _mapper;

        public AdminController(IUnitOfWork unitOfWork, UserManager<Admin> adminManager, IMapper mapper, IAdminService adminService)
        {
            _unitOfWork = unitOfWork;
            _adminManager = adminManager;
            _mapper = mapper;
            _adminService = adminService;
        }

        // GET: api/Admin
        [HttpGet]
        public async Task<IActionResult> GetAllAdmins()
        {
            var admins = await _unitOfWork.Admin.GetAllAdminsAsync();
            var adminResponse = _mapper.Map<List<AdminResponseDTO>>(admins);
            return Ok(adminResponse);
        }

        // GET: api/Admin/{id}
        [HttpGet("{id}")]
        public async Task<IActionResult> GetAdminById(Guid id)
        {
            var admin = await _unitOfWork.Admin.GetAdminByIdAsync(id);
            if (admin == null)
            {
                return NotFound();
            }

            var adminResponse = _mapper.Map<AdminResponseDTO>(admin);
            return Ok(adminResponse);
        }

        // POST: api/Admin
        [HttpPost]
        public async Task<IActionResult> AddAdmin(AddAdminRequestDTO addAdminRequest)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var existingAdmin = await _unitOfWork.Admin.GetAdminByEmailAsync(addAdminRequest.Email);
            if (existingAdmin != null)
            {
                return BadRequest("The email is already in use. Please choose a different email.");
            }

            var result = await _adminService.AddAdminAsync(addAdminRequest);

            if (result.Succeeded)
            {
                string responseMessage;
                if (addAdminRequest.Role.Equals("teacher", StringComparison.OrdinalIgnoreCase))
                {
                    responseMessage = "Teacher has been added successfully.";
                }
                else
                {
                    responseMessage = "Admin has been added successfully.";
                }

                return Ok(responseMessage);
            }

            return BadRequest(result.Errors);
        }
        [HttpGet("teachers")]
        public async Task<IActionResult> GetAllTeachers(
            [FromQuery] int pageNumber = 1,
            [FromQuery] int pageSize = 10,
            [FromQuery] string? filter = null,
            [FromQuery] string? sortOrder = null)
        {
            var (teachers, totalTeachers) = await _unitOfWork.Admin.GetAllTeachersAsync("Teacher", pageNumber, pageSize, filter, sortOrder);
            var teacherResponse = _mapper.Map<List<AdminResponseDTO>>(teachers);

            return Ok(new { TotalCount = totalTeachers, Teachers = teacherResponse });
        }

        [HttpGet("users")]
        public async Task<IActionResult> GetAllUsers(
            [FromQuery] int pageNumber = 1,
            [FromQuery] int pageSize = 10,
            [FromQuery] string? filter = null,
            [FromQuery] string? sortOrder = null)
        {
            var (users, totalUsers) = await _unitOfWork.Users.GetAllUsersAsync(pageNumber, pageSize, filter, sortOrder);
            var userResponse = _mapper.Map<List<UserResponseDTO>>(users);

            return Ok(new { TotalCount = totalUsers, Users = userResponse });
        }
        //DELETE: api/Admin/{id}
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAdmin(Guid id)
        {
            var admin = await _unitOfWork.Admin.GetAdminByIdAsync(id);
            if (admin == null)
            {
                return NotFound();
            }
            _unitOfWork.Admin.Delete(admin);
            await _unitOfWork.SaveChangesAsync();

            return Ok("Deleted successfully");
        }
        //PUT: api/Admin/{id}
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateAdmin(Guid id, UpdateAdminRequestDTO updateAdminRequest)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var admin = await _unitOfWork.Admin.GetAdminByIdAsync(id);
            if (admin == null)
            {
                return NotFound();
            }
            _mapper.Map(updateAdminRequest, admin);
            await _unitOfWork.SaveChangesAsync();

            return Ok("Updated successfully");
        }
    }
}
