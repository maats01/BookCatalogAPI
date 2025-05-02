using BookCatalogAPI.Services;
using Microsoft.AspNetCore.Mvc;
using BookCatalogAPI.Services.DTO;

namespace BookCatalogAPI.Controllers
{
    public class BooksController : Controller
    {
        private readonly BooksService _booksService;

        public BooksController(BooksService booksService)
        {
            _booksService = booksService;
        }

        [HttpGet("api/books")]
        public IActionResult GetAll()
        {
            List<BookDTO> books = _booksService.GetAll();

            return Ok(books);
        }

        [HttpGet("api/books/{id}")]
        public IActionResult Get(int id)
        {
            BookDTO? book = _booksService.GetById(id);

            if (book == null)
                return NotFound();

            return Ok(book);
        }

        [HttpPost("api/books")]
        public IActionResult Create([FromBody] CreateBookDTO createDTO)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            BookDTO book = _booksService.Add(createDTO);

            return CreatedAtAction(nameof(Get), new {id = book.Id}, book);
        }

        [HttpPut("api/books/{id}")]
        public IActionResult Update(int id, [FromBody] UpdateBookDTO updateDTO)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            BookDTO? book = _booksService.GetById(id);

            if (book == null)
                return NotFound();

            updateDTO.Id = id;
            BookDTO updatedBook = _booksService.Update(updateDTO);

            return Ok(updatedBook);
        }

        [HttpDelete("api/books/{id}")]
        public IActionResult Delete(int id)
        {
            bool isRemoved = _booksService.Delete(id);

            if (!isRemoved)
                return NotFound();

            return NoContent();
        }
    }
}
