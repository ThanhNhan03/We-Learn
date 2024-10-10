using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WeLearnAPI.Models.Domain;
using WeLearnAPI.Models.DTO.RequestDto;
using WeLearnAPI.Models.DTO.ResponeDto;
using WeLearnAPI.Repository.Interface;

namespace WeLearnAPI.Controller
{
    [ApiController]
    [Route("api/[controller]")]
    //[Authorize(Roles = "Admin")]
    public class FaqController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public FaqController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> GetAllFaqs()
        {
            var faqs = await _unitOfWork.Faq.GetAllFaqsAsync();
            var faqDtos = _mapper.Map<IEnumerable<FaqResponeDTO>>(faqs);
            return Ok(faqDtos);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetFaqById(int id)
        {
            var faq = await _unitOfWork.Faq.GetFaqByIdAsync(id);
            if (faq == null)
                return NotFound("Faq not found");
            var faqDto = _mapper.Map<FaqResponeDTO>(faq);
            return Ok(faqDto);
        }
        [HttpPost]
        public async Task<IActionResult> CreateFaq([FromBody] AddFaqRequestDTO faqDto)
        {
            if (faqDto == null)
                return BadRequest("Faq data is required");
            var faq = _mapper.Map<Faq>(faqDto);
            await _unitOfWork.Faq.AddAsync(faq);
            await _unitOfWork.SaveChangesAsync();
            var createdFaqDto = _mapper.Map<FaqResponeDTO>(faq);
            return Ok(createdFaqDto);
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateFaq(int id, [FromBody] UpdateFaqRequestDTO faqDto)
        {
            if (faqDto == null)
                return BadRequest("Faq data is required");
            var existingFaq = await _unitOfWork.Faq.GetFaqByIdAsync(id);
            if (existingFaq == null)
                return NotFound("Faq not found");
            _mapper.Map(faqDto, existingFaq);
            await _unitOfWork.SaveChangesAsync();
            var updatedFaqDto = _mapper.Map<FaqResponeDTO>(existingFaq);
            return Ok(updatedFaqDto);
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteFaq(int id)
        {
            var faq = await _unitOfWork.Faq.GetFaqByIdAsync(id);
            if (faq == null)
                return NotFound("Faq not found");
            _unitOfWork.Faq.Delete(faq);
            await _unitOfWork.SaveChangesAsync();
            return NoContent();
        }
    }
}
