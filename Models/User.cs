using System;
using System.ComponentModel.DataAnnotations;

namespace demo.Models
{
    public class User
    {
        [Key]  // Marks this as the Primary Key
        public int Id { get; set; }

        [Required]  // Makes this column NOT NULL
        [StringLength(100)]
        public string Name { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;  // Default value
    }
}
