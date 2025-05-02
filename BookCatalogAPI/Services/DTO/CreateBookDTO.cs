using System.ComponentModel.DataAnnotations;

namespace BookCatalogAPI.Services.DTO
{
    public class CreateBookDTO
    {
        /// <summary>
        /// Título do livro.
        /// </summary>
        [Required]
        public string Title { get; set; }

        /// <summary>
        /// Autor do livro.
        /// </summary>
        [Required]
        public string Author { get; set; }

        /// <summary>
        /// Ano de publicação do livro.
        /// </summary>
        [Required]
        [Range(1, 2025)]
        public int YearPublished { get; set; }
    }
}
