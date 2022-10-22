using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LMS_Core_App.Models
{
    public partial class Parent
    {
        public Parent()
        {
            Students = new HashSet<Student>();
        }

        public string Id { get; set; } 
        [Required]
        public string? FirstName { get; set; } 
        [Required]
        public string? LastName { get; set; } 
        [Required]

        public string? MobileNumber { get; set; } 
        [Required]
        public string? Address { get; set; }
        public bool IsActive { get; set; }

        public virtual ICollection<Student> Students { get; set; }
    }
}
