using System.ComponentModel.DataAnnotations;

namespace KursyOnline.Models
{
    public class Lesson
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Tytuł lekcji jest wymagany")]
        [Display(Name = "Tytuł lekcji")]
        public string Title { get; set; } = string.Empty;

        [Required(ErrorMessage = "Treść lekcji jest wymagana")]
        [Display(Name = "Treść/Opis lekcji")]
        public string Content { get; set; } = string.Empty; // TO TEGO POLA BRAKOWAŁO

        [Display(Name = "Link do wideo (URL)")]
        public string? VideoUrl { get; set; }

        [Display(Name = "Kurs")]
        public int CourseId { get; set; }
        public virtual Course? Course { get; set; }
    }
}