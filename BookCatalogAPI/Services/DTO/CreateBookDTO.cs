using System.ComponentModel.DataAnnotations;

namespace BookCatalogAPI.Services.DTO
{
    public class CreateBookDTO
    {
        [Required]
        public string Title { get; set; }
        [Required]
        public string Author { get; set; }
        [Required]
        [Range(1, 2025)]
        public int YearPublished { get; set; }
    }
}
