using System;
using System.ComponentModel.DataAnnotations;

namespace WebApplication.Models
{
    public class Todo
    {
        public int TodoId { get; set; }

        [Required]
        public string Title { get; set; }
        public string Comments { get; set; }

        public DateTime? DueDate { get; set; }
    }
}