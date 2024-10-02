using Microsoft.AspNetCore.Mvc;
using WeLearnAPI.Models.Domain;
using WeLearnAPI.Repository.Interface;
using AutoMapper;
using WeLearnAPI.Models.DTO.RequestDto;
using Microsoft.AspNetCore.Authorization;
using WeLearnAPI.Models.DTO.ResponeDto;
using WeLearnAPI.Helpers;

[ApiController]
[Route("api/[controller]")]
[Authorize(Roles = "Admin")]
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
    [AllowAnonymous]
    public async Task<IActionResult> GetAllNews(
            int pageNumber = 1,
            int pageSize = 10,
            string sortBy = "Date",
            bool isDescending = true,
            string titleFilter = null)
    {
        var (news, totalCount) = await _unitOfWork.News.GetAllNewsAsync(pageNumber, pageSize, sortBy, isDescending, titleFilter);

        if (news == null || !news.Any())
        {
            return NotFound(new { message = "No news found." });
        }

        var newsDto = _mapper.Map<IEnumerable<NewsReponeDTO>>(news);

        var pagedResult = new PagedResult<NewsReponeDTO>
        {
            Items = newsDto.ToList(),
            TotalCount = totalCount,
            PageNumber = pageNumber,
            PageSize = pageSize
        };

        return Ok(new
        {
            message = "News retrieved successfully.",
            data = pagedResult
        });
    }



    [HttpGet("{id}")]
    public async Task<IActionResult> GetNewsById(int id)
    {
        var news = await _unitOfWork.News.GetNewsByIdAsync(id);
        if (news == null)
            return NotFound(new { message = "News not found." });
        return Ok(new { message = "News retrieved successfully.", data = news });
    }

    [HttpPost]
    public async Task<IActionResult> AddNews([FromBody] AddNewsRequestDTO newsRequestDto)
    {
        
        if (!ModelState.IsValid)
        {
            return BadRequest(new { message = "Invalid data.", errors = ModelState });
        }

       var news = _mapper.Map<News>(newsRequestDto);   

        var adminExists = await _unitOfWork.Admin.GetAdminByIdAsync(Guid.Parse(newsRequestDto.AdminId));
        if (adminExists == null)
        {
            return BadRequest(new { message = "Admin invalid" });
        }

        var newsDto = _mapper.Map<NewsReponeDTO>(newsRequestDto);

        await _unitOfWork.News.AddAsync(news);
        await _unitOfWork.SaveChangesAsync();

        return CreatedAtAction(nameof(GetNewsById), new { id = news.Id }, new { message = "News added successfully."  , data = newsDto });
    }



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
