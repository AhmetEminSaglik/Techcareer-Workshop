using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class Student
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        [DisplayName("Türkiye Cumhuriyeti Kimlik Numarası")]
        [MinLength(11, ErrorMessage = "TC Kimlik Numarası 11 karakter olmalıdır.")]
        [MaxLength(11, ErrorMessage = "TC Kimlik Numarası 11 karakter olmalıdır.")]
        public string TcNo { get; set; }

        public string Departmant { get; set; }

        public int RegisteredYear { get; set; }

    }

}
