using TaskManager.Infrastructure.Models;

namespace TaskManager.Infrastructure.Services
{
    public interface ITaskService
    {
        Task<List<TaskModel>> GetTasks();
    }
}