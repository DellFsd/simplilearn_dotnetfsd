﻿using System.ComponentModel.DataAnnotations;

namespace Phase2Section2._18.Models
{
    public class StudentModel
    {
        [Key]
        public int StudentID { get; set; }

        [Required(ErrorMessage = "Name is required")]
        [StringLength(100)]
        public string Name { get; set; }

        [Required]
        [StringLength(255)]
        public string Address { get; set; }

        [Required]
        [StringLength(10)]
        public string Class { get; set; }

        [Required]
        [EmailAddress]
        [Display(Name = "Contact Email")]
        public string ContactEmail { get; set; }

        [Required]
        [Range(5, 14)]
        public int Age { get; set; }
    }
}
