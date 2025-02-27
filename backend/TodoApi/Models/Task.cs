using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TodoApi.Models
{
    public enum TaskStatus
    {
        NotStarted,
        InProgress,
        Blocked,
        Completed,
        Archived
    }

    public enum TaskPriority
    {
        Low,
        Medium,
        High,
        Critical
    }

    public class Task
    {
        public Guid Id { get; set; }
        
        [Required]
        [StringLength(100, MinimumLength = 3)]
        public string Title { get; set; }
        
        public string Description { get; set; }
        
        public TaskStatus Status { get; set; } = TaskStatus.NotStarted;
        
        public TaskPriority Priority { get; set; } = TaskPriority.Medium;
        
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        
        public DateTime? DueDate { get; set; }
        
        public DateTime? CompletedAt { get; set; }
        
        public int EstimatedHours { get; set; }
        
        public int? ActualHours { get; set; }
        
        public List<string> Tags { get; set; } = new List<string>();
        
        // IDs of tasks that must be completed before this task can start
        public List<Guid> DependsOn { get; set; } = new List<Guid>();
        
        // Custom fields for extensibility
        public Dictionary<string, string> CustomFields { get; set; } = new Dictionary<string, string>();
        
        // Calculated property to determine if task can be started based on dependencies
        [System.Text.Json.Serialization.JsonIgnore]
        public bool CanStart { get; set; }
    }
} 