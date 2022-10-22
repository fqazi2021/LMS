using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LMS_Core_App.Models
{
    public partial class Student
    {
        public string Id { get; set; } = null!;

        [Required]
        public string FullName { get; set; } = null!;
        [Required]
        [Range(18,60)]
        public int Age { get; set; }
        [Required]
        public DateTime DateOfBirth { get; set; }
        public string? ParentDetails { get; set; }

        [Required]
        [EmailAddress]
        public string? Email { get; set; }
        [Required]
        public string Class { get; set; }

        public virtual Parent ParentDetailsNavigation { get; set; } = null!;
    }
}
