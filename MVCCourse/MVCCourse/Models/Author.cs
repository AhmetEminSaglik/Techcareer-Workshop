using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MVCCourse.Models
{
    public class Author
    {
        public int Id { get; set; }

        [Required]
        [DisplayName("Adı")]
        public string Name { get; set; }

        [Required]
        [DisplayName("Doğum Yılı")]
        public int BirthYear { get; set; }

    }
}
