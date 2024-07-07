using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MVCCourse.Models
{
    public class Book
    {
        public int Id { get; set; }

        [Required]
        [DisplayName("Name")]
        public string Name { get; set; }

        [DisplayName("Description")]
        public string Desc { get; set; }

        [Required]
        [DisplayName("Page Number")]
        [MinLength(50, ErrorMessage = "The number of pages of the book must be at least 50.")]
        [MaxLength(350, ErrorMessage = "The number of pages of the book must not exceed 350.")]
        public int pageNumber { get; set; }

        [Required]
        [DisplayName("Author")]
        public Author author { get; set; }
    }
}
