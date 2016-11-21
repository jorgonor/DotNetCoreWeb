using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication.Models
{
    public class Todo
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TodoId { get; set; }

        [Required]
        public string Title { get; set; }
        public string Comments { get; set; }

        public DateTime? DueDate { get; set; }
    }
}