using System.ComponentModel.DataAnnotations;

namespace BookCatalogAPI.Services.DTO
{
    public class UpdateBookDTO
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Author { get; set; }
        [Range(1, 2025)]
        public int? YearPublished { get; set; }
    }
}
