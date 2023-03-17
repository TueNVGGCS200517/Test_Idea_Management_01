using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Idea_Management.Models
{
    public class Ideas
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(200)]
        public string Title { get; set; }
        public string Description { get; set; }
        public string Author_Id { get; set; }

        [ForeignKey("Author_Id")]

        public ApplicationUser Author { get; set; }
        
        public DateTime Deadline1 { get; set; }
        public DateTime Deadline2 { get; set; }
    }
}