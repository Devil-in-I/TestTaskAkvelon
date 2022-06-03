using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;

namespace TestTaskAkvelon.Models
{
    [Table("Task")]
    public class TaskModel : IIdentifiable
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
        [Required]
        public TaskStatus TaskStatus { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public int Priority { get; set; }

        // Foreign key 
        public int ProjectId { get; set; }
        // Foreign property
        public ProjectModel Project { get; set; }
    }

    public enum TaskStatus
    {
        ToDO,
        InProgress,
        Done
    }
}