using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TodoApi.Models;

namespace TodoApi.Services
{
    public interface ITaskService
    {
        Task<IEnumerable<Models.Task>> GetAllTasksAsync();
        
        Task<Models.Task> GetTaskByIdAsync(Guid id);
        
        Task<IEnumerable<Models.Task>> FilterTasksAsync(TaskFilterDto filterDto);
        
        Task<Models.Task> CreateTaskAsync(CreateTaskDto taskDto);
        
        Task<Models.Task> UpdateTaskAsync(Guid id, UpdateTaskDto taskDto);
        
        Task<bool> DeleteTaskAsync(Guid id);
        
        Task<bool> CheckDependenciesAsync(Guid taskId);
        
        Task<IEnumerable<Models.Task>> GetDependentTasksAsync(Guid taskId);
        
        Task<Dictionary<string, int>> GetTaskStatisticsAsync();
    }
} 