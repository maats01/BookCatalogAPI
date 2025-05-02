namespace BookCatalogAPI.Models
{
    public class Book
    {
        /// <summary>
        /// Identificador único do livro.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Título do livro.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Autor do livro.
        /// </summary>
        public string Author { get; set; }

        /// <summary>
        /// Ano de publicação do livro.
        /// </summary>
        public int YearPublished { get; set; }
    }
}
