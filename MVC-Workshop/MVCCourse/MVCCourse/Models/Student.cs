using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MVCCourse.Models
{
    public class Student
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        [DisplayName("TC No")]
        [MinLength(11, ErrorMessage = "TC Kimlik Numarası 11 karakter olmalıdır.")]
        [MaxLength(11, ErrorMessage = "TC Kimlik Numarası 11 karakter olmalıdır.")]
        public string TcNo { get; set; }
        
        public string Major { get; set; }
        public int RegisteredYear { get; set; }

        [Required]
        [DisplayName("Email")]
        [EmailAddress]
        public string Email { get; set; }


    }

}
