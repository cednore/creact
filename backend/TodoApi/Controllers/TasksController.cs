using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TodoApi.Models;
using TodoApi.Services;

namespace TodoApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TasksController : ControllerBase
    {
        private readonly ITaskService _taskService;

        public TasksController(ITaskService taskService)
        {
            _taskService = taskService;
        }

        // GET: api/tasks
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Models.Task>>> GetTasks()
        {
            var tasks = await _taskService.GetAllTasksAsync();
            return Ok(tasks);
        }

        // GET: api/tasks/{id}
        [HttpGet("{id}")]
        public async Task<ActionResult<Models.Task>> GetTask(Guid id)
        {
            var task = await _taskService.GetTaskByIdAsync(id);

            if (task == null)
            {
                return NotFound();
            }

            return Ok(task);
        }

        // POST: api/tasks
        [HttpPost]
        public async Task<ActionResult<Models.Task>> CreateTask(CreateTaskDto taskDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var createdTask = await _taskService.CreateTaskAsync(taskDto);
            return CreatedAtAction(nameof(GetTask), new { id = createdTask.Id }, createdTask);
        }

        // TODO: Implement the PUT endpoint to update a task
        // PUT: api/tasks/{id}
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateTask(Guid id, UpdateTaskDto taskDto)
        {
            // The candidate should implement this method
            // It should call _taskService.UpdateTaskAsync and handle the response appropriately
            throw new NotImplementedException("This endpoint needs to be implemented by the candidate");
        }

        // TODO: Implement the DELETE endpoint to delete a task
        // DELETE: api/tasks/{id}
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTask(Guid id)
        {
            // The candidate should implement this method
            // It should call _taskService.DeleteTaskAsync and handle the response appropriately
            throw new NotImplementedException("This endpoint needs to be implemented by the candidate");
        }

        // TODO: Implement the POST endpoint to filter tasks
        // POST: api/tasks/filter
        [HttpPost("filter")]
        public async Task<ActionResult<IEnumerable<Models.Task>>> FilterTasks(TaskFilterDto filterDto)
        {
            // The candidate should implement this method
            // It should call _taskService.FilterTasksAsync and handle the response appropriately
            throw new NotImplementedException("This endpoint needs to be implemented by the candidate");
        }

        // TODO: Implement the GET endpoint to check dependencies
        // GET: api/tasks/{id}/dependencies/check
        [HttpGet("{id}/dependencies/check")]
        public async Task<ActionResult<bool>> CheckDependencies(Guid id)
        {
            // The candidate should implement this method
            // It should call _taskService.CheckDependenciesAsync and handle the response appropriately
            throw new NotImplementedException("This endpoint needs to be implemented by the candidate");
        }

        // TODO: Implement the GET endpoint to get dependent tasks
        // GET: api/tasks/{id}/dependents
        [HttpGet("{id}/dependents")]
        public async Task<ActionResult<IEnumerable<Models.Task>>> GetDependentTasks(Guid id)
        {
            // The candidate should implement this method
            // It should call _taskService.GetDependentTasksAsync and handle the response appropriately
            throw new NotImplementedException("This endpoint needs to be implemented by the candidate");
        }

        // TODO: Implement the GET endpoint to get task statistics
        // GET: api/tasks/statistics
        [HttpGet("statistics")]
        public async Task<ActionResult<Dictionary<string, int>>> GetTaskStatistics()
        {
            // The candidate should implement this method
            // It should call _taskService.GetTaskStatisticsAsync and handle the response appropriately
            throw new NotImplementedException("This endpoint needs to be implemented by the candidate");
        }
    }
} 