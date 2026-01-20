using KursyOnline.Models;
using System.ComponentModel.DataAnnotations;

namespace KursyOnline.Models
{
    public class Lesson
    {
        public int Id { get; set; }
        [Required]
        public string? Title { get; set; }
        public string? VideoUrl { get; set; } 

        public int CourseId { get; set; }
        public virtual Course? Course { get; set; }
    }
}