using BookCatalogAPI.Models;
using BookCatalogAPI.Services.DTO;

namespace BookCatalogAPI.Services
{
    public class BooksService
    {
        private readonly List<Book> _books;
        private int _lastId = 0;

        public BooksService()
        {
            _books = new List<Book>();
        }

        private int GetNewId()
        {
            return ++_lastId;
        }

        public List<BookDTO> GetAll()
        {
            return _books.Select(b => b.ToDTO()).ToList();
        }

        public BookDTO? GetById(int id)
        {
            Book? book = _books.FirstOrDefault(b => b.Id == id);

            if (book == null)
                return null;

            return book.ToDTO();
        }

        public BookDTO Add(CreateBookDTO dto)
        {
            Book book = new Book()
            {
                Id = GetNewId(),
                Title = dto.Title,
                Author = dto.Author,
                YearPublished = dto.YearPublished
            };

            _books.Add(book);

            return book.ToDTO();
        }

        public BookDTO Update(UpdateBookDTO dto)
        {
            Book book = _books.First(b => b.Id == dto.Id);

            if (dto.Title != null)
                book.Title = dto.Title;

            if (dto.Author != null)
                book.Author = dto.Author;

            if (dto.YearPublished != null)
                book.YearPublished = (int)dto.YearPublished;

            return book.ToDTO();
        }

        public bool Delete(int id)
        {
            Book? book = _books.FirstOrDefault(b => b.Id == id);

            if (book == null)
                return false;

            _books.Remove(book);

            return true;
        }
    }
}
