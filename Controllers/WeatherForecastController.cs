using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TrainingSystem.API.Data;

namespace TrainingSystem.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StatsController : ControllerBase
    {
        private readonly AppDbContext _context;

        public StatsController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet("services")]
        public async Task<IActionResult> GetStats()
        {
            var result = await _context.ServiceStats.ToListAsync();
            return Ok(result);
        }

        [HttpGet("assignment-usage")]
        public async Task<IActionResult> GetAssignmentUsage()
        {
            var result = await _context.AssignmentUsage.ToListAsync();
            return Ok(result);
        }

        [HttpGet("device-usage")]
        public async Task<IActionResult> GetDeviceUsage()
        {
            var result = await _context.DeviceAssignmentCount.ToListAsync();
            return Ok(result);
        }

    }
}
