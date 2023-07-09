using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManager.Infrastructure.Services;

namespace TaskManager.Infrastructure.Tests
{
    public class TaskServiceTests
    {
        private readonly TaskService _taskService;

        public TaskServiceTests()
        {
            _taskService = new TaskService();
        }

        [Fact]
        public async Task GetTasks_ReturnsListOfTasks_WithNoEmptyNames()
        {
            var tasks = await _taskService.GetTasks();
            Assert.True(tasks.All(x => !string.IsNullOrWhiteSpace(x.Name)));
        }
    }
}
