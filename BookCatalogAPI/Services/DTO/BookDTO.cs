namespace BookCatalogAPI.Services.DTO
{
    public class BookDTO
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public int YearPublished { get; set; }
    }

    public static class ExtensionMethodsForBook
    {
        public static BookDTO ToDTO(this Models.Book book)
        {
            return new BookDTO()
            {
                Id = book.Id,
                Title = book.Title,
                Author = book.Author,
                YearPublished = book.YearPublished,
            };
        }
    }
}
