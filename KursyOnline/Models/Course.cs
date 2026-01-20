using KursyOnline.Models;
using System.ComponentModel.DataAnnotations;

namespace KursyOnline.Models
{
    public class Course
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Tytuł kursu jest wymagany")]
        public string Title { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }

        // Relacja do Kategorii
        public int CategoryId { get; set; }
        public virtual Category? Category { get; set; }

        public virtual ICollection<Lesson>? Lessons { get; set; }
    }
}