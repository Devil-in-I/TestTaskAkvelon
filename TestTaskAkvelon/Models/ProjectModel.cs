using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TestTaskAkvelon.Models
{
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
        public int MyProperty { get; set; }
        [Required]
        public ProjectStatus ProjectStatus { get; set; }
        [Required]
        public int Priority { get; set; }
    }

    public enum ProjectStatus
    {
        NotStarted,
        Active,
        Completed
    }
}
