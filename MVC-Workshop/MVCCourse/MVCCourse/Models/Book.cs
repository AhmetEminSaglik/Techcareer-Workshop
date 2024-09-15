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

        [Required]
        [MinLength(5, ErrorMessage = "Can Be minimum 5 characters.")]
        [MaxLength(50, ErrorMessage = "Can Be minimum 50 characters.")]
        [DisplayName("Description")]
        public string Desc { get; set; }

        [Required]
        [Range(50, 350, ErrorMessage = "The number of pages of the book must be between 50-350")]
        [DisplayName("Page Number")]
        public int PageNumber { get; set; }

        [Required]
        [DisplayName("Author Name")]
        public string AuthorName { get; set; }

    }
}
