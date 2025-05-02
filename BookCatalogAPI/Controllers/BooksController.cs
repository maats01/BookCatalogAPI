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

        /// <summary>
        /// Endpoint para retornar todos os livros do catálago.
        /// </summary>
        /// <returns>Retorna o código de status 200 e os livros em formato JSON no corpo da resposta.</returns>
        [HttpGet("api/books")]
        public IActionResult GetAll()
        {
            List<BookDTO> books = _booksService.GetAll();

            return Ok(books);
        }

        /// <summary>
        /// Endpoint para retornar livros com base no Id.
        /// </summary>
        /// <param name="id">Id para buscar</param>
        /// <returns>
        /// Retorna 200 junto com o livro em formato JSON no corpo da resposta.
        /// Retorna 404 caso não tenha sido encontrado o livro.
        /// </returns>
        [HttpGet("api/books/{id}")]
        public IActionResult Get(int id)
        {
            BookDTO? book = _booksService.GetById(id);

            if (book == null)
                return NotFound();

            return Ok(book);
        }

        /// <summary>
        /// Endpoint para criar um novo livro no catálogo.
        /// </summary>
        /// <param name="createDTO">Objeto contendo as informações do livro.</param>
        /// <returns>
        /// Retorna 201 se o livro for criado com sucesso.
        /// Retorna 400 se os dados fornecidos forem inválidos.
        /// </returns>
        [HttpPost("api/books")]
        public IActionResult Create([FromBody] CreateBookDTO createDTO)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            BookDTO book = _booksService.Add(createDTO);

            return CreatedAtAction(nameof(Get), new {id = book.Id}, book);
        }

        /// <summary>
        /// Endpoint para atualizar um livro do catálogo.
        /// </summary>
        /// <param name="id">Id do livro.</param>
        /// <param name="updateDTO">Objeto contendo as informações atualizadas do livro.</param>
        /// <returns>
        /// Retorna 200 se o livro for atualizado com sucesso.
        /// Retorna 400 se os dados fornecidos forem inválidos.
        /// Retorna 404 caso o livro não tenha sido encontrado.
        /// </returns>

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

        /// <summary>
        /// Endpoint para remover um livro do catálogo.
        /// </summary>
        /// <param name="id">Id do livro.</param>
        /// <returns>
        /// Retorna 204 se o livro for removido com sucesso.
        /// Retorna 404 caso o livro não tenha sido encontrado.
        /// </returns>

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
