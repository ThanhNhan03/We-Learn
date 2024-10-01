using CloudinaryDotNet.Actions;
using CloudinaryDotNet;
using Microsoft.AspNetCore.Mvc;

[Route("api/[controller]")]
[ApiController]
public class UploadController : ControllerBase
{
    private readonly Cloudinary _cloudinary;

    public UploadController(Cloudinary cloudinary)
    {
        _cloudinary = cloudinary;
    }

    [HttpPost("upload")]
    public async Task<IActionResult> UploadImage(IFormFile file, string folder)
    {
        if (file.Length > 0)
        {
            using var stream = file.OpenReadStream();
            var uploadParams = new ImageUploadParams()
            {
                File = new FileDescription(file.FileName, stream),
                Folder = folder 
            };

            var uploadResult = await _cloudinary.UploadAsync(uploadParams);
            return Ok(new { url = uploadResult.Url.ToString() });
        }

        return BadRequest("Invalid file.");
    }
}
