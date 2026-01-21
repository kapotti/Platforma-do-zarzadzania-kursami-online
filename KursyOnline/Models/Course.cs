using Microsoft.AspNetCore.Authorization;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KursyOnline.Models
{
    [Authorize]
    public class Course
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Tytuł kursu jest wymagany.")]
        [Display(Name = "Tytuł kursu")]
        public string Title { get; set; } = string.Empty;

        [Required(ErrorMessage = "Opis jest wymagany.")]
        [Display(Name = "Opis kursu")]
        public string Description { get; set; } = string.Empty;

        [Required(ErrorMessage = "Cena jest wymagana.")]
        [Range(0.01, 10000.00, ErrorMessage = "Cena musi być większa od 0.")]
        [Display(Name = "Cena (PLN)")]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }
        [Required(ErrorMessage = "Wybór kategorii jest wymagany.")]
        [Display(Name = "Kategoria")]
        public int CategoryId { get; set; }

        [ForeignKey("CategoryId")]
        [Display(Name = "Kategoria")]
        public virtual Category? Category { get; set; }

        public virtual ICollection<Lesson>? Lessons { get; set; }
    }
}