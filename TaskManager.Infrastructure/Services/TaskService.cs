using TaskManager.Infrastructure.Models;

namespace TaskManager.Infrastructure.Services
{
    public class TaskService : ITaskService
    {
        private List<TaskModel> _tasks;

        public TaskService()
        {
            _tasks = new List<TaskModel>
            {
                new TaskModel(1, "Clean the room"),
                new TaskModel(2, "Make the dinner"),
                new TaskModel(3, "Do homework")
            };
        }

        public async Task<List<TaskModel>> GetTasks()
        {
            return await Task.FromResult(_tasks);
        }
    }
}
