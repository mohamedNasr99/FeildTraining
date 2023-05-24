﻿using System.ComponentModel.DataAnnotations;

namespace FeildTraining.Models
{
    public class Admin
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        [Required]
        public string Email { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        [Required]
        public string Phone { get; set; } = string.Empty;
    }
}
