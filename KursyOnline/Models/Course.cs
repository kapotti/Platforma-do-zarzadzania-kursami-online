using KursyOnline.Models;
using System.ComponentModel.DataAnnotations;

namespace KursyOnline.Models
{
    public class Course
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Tytuł jest wymagany")]
        [Display(Name = "Tytuł kursu")]
        public string? Title { get; set; }

        [Display(Name = "Opis")]
        public string? Description { get; set; }

        [Display(Name = "Cena")]
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }

        [Display(Name = "Kategoria")]
        public int CategoryId { get; set; }
        public virtual Category? Category { get; set; }

        public virtual ICollection<Lesson>? Lessons { get; set; }
    }
}