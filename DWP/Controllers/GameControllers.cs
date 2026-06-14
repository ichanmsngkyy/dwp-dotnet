using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication.Data;
using WebApplication.DTOs;

namespace WebApplication.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class GamesController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public GamesController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<GameDTO>>> GetAllGames()
        {
            try
            {
                var games = await _context.Games
                    .Select(g => new GameDTO
                    {
                        Artworks = g.Artworks,
                        GameType = g.GameType,
                        Title = g.Title,
                        Slug = g.Slug,
                        Platforms = g.Platforms,
                        Genre = g.Genre,
                        Developer = g.Developer,
                        ReleaseYear = g.ReleaseYear
                    }).Where(g => g.ReleaseYear > 2000)
                    .ToListAsync();
                var response = new
                {
                    Success = true,
                    Data = games,
                    Message = "Games retrieved successfully."
                };

                return Ok(response);    //200
            }
            catch (Exception ex)
            {
                var response = new
                {
                    Success = false,
                    Message = "An error occurred while retrieving data.",
                    Errors = new List<string> { ex.Message }
                };
                return StatusCode(500, response);
            }
        }
    }
}
