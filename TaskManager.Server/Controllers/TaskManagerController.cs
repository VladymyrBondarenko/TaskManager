using Microsoft.AspNetCore.Mvc;
using TaskManager.Infrastructure.Services;

namespace TaskManager.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TaskController : ControllerBase
    {
        private readonly ITaskService _taskService;

        public TaskController(ITaskService taskService)
        {
            _taskService = taskService;
        }

        [HttpGet()]
        public async Task<IActionResult> GetAll()
        {
            var tasks = await _taskService.GetTasks();
            return Ok(tasks);
        }
    }
}
