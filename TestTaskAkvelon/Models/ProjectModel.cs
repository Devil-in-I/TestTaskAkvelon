using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TestTaskAkvelon.Models
{
    [Table("Project")]
    public class ProjectModel : IIdentifiable
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public DateTime StartDate { get; set; }
        [Required]
        public DateTime CompletionDate { get; set; }
        [Required]
        public ProjectStatus ProjectStatus { get; set; }
        [Required]
        public int Priority { get; set; }

        public virtual ICollection<TaskModel> Tasks { get; set; }
    }

    public enum ProjectStatus
    {
        NotStarted,
        Active,
        Completed
    }
}
