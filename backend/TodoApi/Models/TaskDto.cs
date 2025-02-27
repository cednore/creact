using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TodoApi.Models
{
    public class CreateTaskDto
    {
        [Required]
        [StringLength(100, MinimumLength = 3)]
        public string Title { get; set; }
        
        public string Description { get; set; }
        
        public TaskPriority Priority { get; set; } = TaskPriority.Medium;
        
        public DateTime? DueDate { get; set; }
        
        public int EstimatedHours { get; set; }
        
        public List<string> Tags { get; set; } = new List<string>();
        
        public List<Guid> DependsOn { get; set; } = new List<Guid>();
        
        public Dictionary<string, string> CustomFields { get; set; } = new Dictionary<string, string>();
    }

    public class UpdateTaskDto
    {
        public string Title { get; set; }
        
        public string Description { get; set; }
        
        public TaskStatus? Status { get; set; }
        
        public TaskPriority? Priority { get; set; }
        
        public DateTime? DueDate { get; set; }
        
        public DateTime? CompletedAt { get; set; }
        
        public int? EstimatedHours { get; set; }
        
        public int? ActualHours { get; set; }
        
        public List<string> Tags { get; set; }
        
        public List<Guid> DependsOn { get; set; }
        
        public Dictionary<string, string> CustomFields { get; set; }
    }

    public class TaskFilterDto
    {
        public string SearchTerm { get; set; }
        
        public List<TaskStatus> Statuses { get; set; }
        
        public List<TaskPriority> Priorities { get; set; }
        
        public DateTime? DueDateFrom { get; set; }
        
        public DateTime? DueDateTo { get; set; }
        
        public List<string> Tags { get; set; }
        
        public bool? HasDependencies { get; set; }
        
        public bool? CanStart { get; set; }
        
        public string SortBy { get; set; } = "DueDate";
        
        public bool SortAscending { get; set; } = true;
        
        public int PageNumber { get; set; } = 1;
        
        public int PageSize { get; set; } = 10;
    }
} 