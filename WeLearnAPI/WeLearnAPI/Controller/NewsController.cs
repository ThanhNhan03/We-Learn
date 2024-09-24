using Microsoft.AspNetCore.Mvc;
using WeLearnAPI.Models.Domain;
using WeLearnAPI.Repository.Interface;
using AutoMapper;
using WeLearnAPI.Models.DTO.RequestDto;
using Microsoft.AspNetCore.Authorization;

[ApiController]
[Route("api/[controller]")]
[Authorize (Roles = "Admin")]
public class NewsController : ControllerBase
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public NewsController(IUnitOfWork unitOfWork, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    // GET: api/News
    [HttpGet]
    public async Task<IActionResult> GetAllNews()
    {
        var news = await _unitOfWork.News.GetAllNewsAsync();
        if (news == null || !news.Any())
        {
            return NotFound(new { message = "No news found." });
        }
        return Ok(new { message = "News retrieved successfully.", data = news });
    }

    // GET: api/News/{id}
    [HttpGet("{id}")]
    public async Task<IActionResult> GetNewsById(int id)
    {
        var news = await _unitOfWork.News.GetNewsByIdAsync(id);
        if (news == null)
            return NotFound(new { message = "News not found." });
        return Ok(new { message = "News retrieved successfully.", data = news });
    }

    // POST: api/News
    [HttpPost]
    public async Task<IActionResult> AddNews([FromBody] AddNewsRequestDTO newsDto)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(new { message = "Invalid data.", errors = ModelState });
        }

        var news = _mapper.Map<News>(newsDto);

        await _unitOfWork.News.AddAsync(news);
        await _unitOfWork.SaveChangesAsync();

        return CreatedAtAction(nameof(GetNewsById), new { id = news.Id }, new { message = "News added successfully.", data = news });
    }

    // DELETE: api/News/{id}
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteNews(int id)
    {
        var news = await _unitOfWork.News.GetNewsByIdAsync(id);
        if (news == null)
        {
            return NotFound(new { message = "News not found." });
        }

        _unitOfWork.News.Delete(news);
        await _unitOfWork.SaveChangesAsync();

        return Ok(new { message = "News deleted successfully." });
    }

    // PUT: api/News/{id}
    [HttpPut("{id}")]

    public async Task<IActionResult> UpdateNews(int id, [FromBody] UpdateNewsRequestDTO updateNewsRequest)

    {
        if (!ModelState.IsValid)
            return BadRequest(new { message = "Invalid data.", errors = ModelState });

        var news = await _unitOfWork.News.GetNewsByIdAsync(id);
        if (news == null)
        {
            return NotFound(new { message = "News not found." });
        }

        _mapper.Map(updateNewsRequest, news);
        await _unitOfWork.SaveChangesAsync();

        return Ok(new { message = "News updated successfully." });
    }
}
