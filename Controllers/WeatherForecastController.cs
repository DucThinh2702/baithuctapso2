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

        // ➤ View 1: Dịch vụ và số lượng phân công
        [HttpGet("services")]
        public async Task<IActionResult> GetStats()
        {
            var result = await _context.ServiceStats.ToListAsync();
            return Ok(result);
        }

        // ➤ View 2: Tổng số phân công theo thiết bị theo tuần/tháng/năm
        [HttpGet("assignment-usage")]
        public async Task<IActionResult> GetAssignmentUsage()
        {
            var result = await _context.AssignmentUsage.ToListAsync();
            return Ok(result);
        }

        // ➤ View 3: Tổng số lượt sử dụng của từng thiết bị
        [HttpGet("device-usage")]
        public async Task<IActionResult> GetDeviceUsage()
        {
            var result = await _context.DeviceAssignmentCount.ToListAsync();
            return Ok(result);
        }
    }
}
