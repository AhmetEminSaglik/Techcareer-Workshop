using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class Book
    {
        public int Id { get; set; }

        [Required]
        [DisplayName("Adı")]
        public string Name { get; set; }

        [DisplayName("Özet")]
        public string Desc { get; set; }

        [Required]
        [DisplayName("Sayfa sayısı")]
        [MinLength(50, ErrorMessage = "Eklenecek kitabın sayfa sayısı en az 50 olmalıdır.")]
        [MaxLength(350, ErrorMessage = "Eklenecek kitabın sayfa sayısı en fazla 350 olmalıdır.")]
        public int page { get; set; }

        [Required]
        [DisplayName("Yazar")]
        public Author author { get; set; }

        /*     [Required]
             [DisplayName("Yazar Adı")]
             public string Author { get; set; }*/
    }
}
