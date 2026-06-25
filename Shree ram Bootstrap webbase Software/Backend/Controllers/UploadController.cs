using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.IO;
using System.Threading.Tasks;

namespace Backend
{
    [ApiController]
    [Route("api/upload")]
    public class UploadController : ControllerBase
    {
        private readonly string _uploadsFolder = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "Uploads");

        [HttpPost]
        [DisableRequestSizeLimit] // Disable size limits to support up to 200MB uploads
        public async Task<IActionResult> Upload(IFormFile file)
        {
            try
            {
                if (file == null || file.Length == 0)
                {
                    return BadRequest(new { success = false, message = "No file uploaded" });
                }

                // Ensure the wwwroot/Uploads folder exists
                if (!Directory.Exists(_uploadsFolder))
                {
                    Directory.CreateDirectory(_uploadsFolder);
                }

                // Generate a unique file name
                string extension = Path.GetExtension(file.FileName);
                string newFileName = $"{Guid.NewGuid()}{extension}";
                string filePath = Path.Combine(_uploadsFolder, newFileName);

                // Save file to disk
                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    await file.CopyToAsync(stream);
                }

                // Return relative URL
                string relativeUrl = $"/Uploads/{newFileName}";
                return Ok(new { success = true, url = relativeUrl });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { success = false, message = ex.Message });
            }
        }
    }
}
