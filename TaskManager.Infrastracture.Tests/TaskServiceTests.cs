using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManager.Infrastructure.Services;

namespace TaskManager.Infrastracture.Test
{
    public class TaskServiceTests
    {
        private readonly TaskService _taskService;

        public TaskServiceTests()
        {
            _taskService = new TaskService();
        }

        [Fact]
        public async Task GetTasks_ShouldReturnTaskList_WithNotEmptyNames()
        {
            var tasks = await _taskService.GetTasks();

            Assert.True(tasks.All(x => !string.IsNullOrWhiteSpace(x.Name)));
        }
    }
}
