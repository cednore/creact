using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodoApi.Models;

namespace TodoApi.Services
{
    public class TaskService : ITaskService
    {
        // In-memory storage for tasks (would be replaced with a database in a real application)
        private readonly List<Models.Task> _tasks = new List<Models.Task>();

        public TaskService()
        {
            // Add some sample tasks
            _tasks.Add(new Models.Task
            {
                Id = Guid.NewGuid(),
                Title = "Implement authentication",
                Description = "Add JWT authentication to the API",
                Priority = TaskPriority.High,
                Status = TodoApi.Models.TaskStatus.NotStarted,
                DueDate = DateTime.UtcNow.AddDays(5),
                EstimatedHours = 8,
                Tags = new List<string> { "backend", "security" }
            });

            _tasks.Add(new Models.Task
            {
                Id = Guid.NewGuid(),
                Title = "Design dashboard UI",
                Description = "Create wireframes for the main dashboard",
                Priority = TaskPriority.Medium,
                Status = TodoApi.Models.TaskStatus.InProgress,
                DueDate = DateTime.UtcNow.AddDays(3),
                EstimatedHours = 6,
                Tags = new List<string> { "frontend", "design" }
            });
        }

        public Task<IEnumerable<Models.Task>> GetAllTasksAsync()
        {
            return System.Threading.Tasks.Task.FromResult<IEnumerable<Models.Task>>(_tasks);
        }

        public Task<Models.Task> GetTaskByIdAsync(Guid id)
        {
            var task = _tasks.FirstOrDefault(t => t.Id == id);
            return System.Threading.Tasks.Task.FromResult(task);
        }

        public Task<Models.Task> CreateTaskAsync(CreateTaskDto taskDto)
        {
            var task = new Models.Task
            {
                Id = Guid.NewGuid(),
                Title = taskDto.Title,
                Description = taskDto.Description,
                Priority = taskDto.Priority,
                DueDate = taskDto.DueDate,
                EstimatedHours = taskDto.EstimatedHours,
                Tags = taskDto.Tags ?? new List<string>(),
                DependsOn = taskDto.DependsOn ?? new List<Guid>(),
                CustomFields = taskDto.CustomFields ?? new Dictionary<string, string>()
            };

            _tasks.Add(task);
            return System.Threading.Tasks.Task.FromResult(task);
        }

        // TODO: Implement the UpdateTaskAsync method
        public Task<Models.Task> UpdateTaskAsync(Guid id, UpdateTaskDto taskDto)
        {
            // The candidate should implement this method
            // It should update the task with the given id using the properties from taskDto
            // Only update properties that are not null in the taskDto
            // Return null if the task is not found
            throw new NotImplementedException("This method needs to be implemented by the candidate");
        }

        // TODO: Implement the DeleteTaskAsync method
        public Task<bool> DeleteTaskAsync(Guid id)
        {
            // The candidate should implement this method
            // It should remove the task with the given id from the _tasks list
            // Return true if the task was found and deleted, false otherwise
            throw new NotImplementedException("This method needs to be implemented by the candidate");
        }

        // TODO: Implement the FilterTasksAsync method
        public Task<IEnumerable<Models.Task>> FilterTasksAsync(TaskFilterDto filterDto)
        {
            // The candidate should implement this method
            // It should filter tasks based on the criteria in filterDto
            // It should also handle sorting and pagination
            throw new NotImplementedException("This method needs to be implemented by the candidate");
        }

        // TODO: Implement the CheckDependenciesAsync method
        public Task<bool> CheckDependenciesAsync(Guid taskId)
        {
            // The candidate should implement this method
            // It should check if all dependencies of the task with the given id are completed
            // Return true if all dependencies are completed or if there are no dependencies
            throw new NotImplementedException("This method needs to be implemented by the candidate");
        }

        // TODO: Implement the GetDependentTasksAsync method
        public Task<IEnumerable<Models.Task>> GetDependentTasksAsync(Guid taskId)
        {
            // The candidate should implement this method
            // It should return all tasks that depend on the task with the given id
            throw new NotImplementedException("This method needs to be implemented by the candidate");
        }

        // TODO: Implement the GetTaskStatisticsAsync method
        public Task<Dictionary<string, int>> GetTaskStatisticsAsync()
        {
            // The candidate should implement this method
            // It should return statistics about the tasks, such as:
            // - Number of tasks by status
            // - Number of tasks by priority
            // - Number of overdue tasks
            // - Number of tasks with dependencies
            throw new NotImplementedException("This method needs to be implemented by the candidate");
        }
    }
} 