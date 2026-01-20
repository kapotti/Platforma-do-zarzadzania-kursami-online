using System.ComponentModel.DataAnnotations;

namespace KursyOnline.Models
{
    public class Category
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Nazwa kategorii jest wymagana")]
        [StringLength(50)]
        public string? Name { get; set; }
        public virtual ICollection<Course>? Courses { get; set; }
    }
}