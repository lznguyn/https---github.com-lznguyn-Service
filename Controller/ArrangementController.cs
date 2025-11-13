using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MuTraProAPI.Data;
using MuTraProAPI.Models;
using System.IO;

namespace MuTraProAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class Arrangement : ControllerBase
    {
        private readonly MuTraProDbContext _context;
        private readonly IWebHostEnvironment _env;
        public Arrangement(MuTraProDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }
        [HttpGet]
        public async Task<IActionResult> GetMusicSubmissions()
        {
            var arrangement = await _context.MusicSubmissions.ToListAsync();
            return Ok(new { status = "success", message = "Lấy danh sách bài hát yêu cầu thành công", data = arrangement });
        }
    }
}