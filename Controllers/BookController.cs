using Microsoft.AspNetCore.Mvc;
using Model;

namespace Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BookController : ControllerBase
    {
        private readonly Services.IBookService _bookService;
        private readonly ILogger<BookController> _logger;

        public BookController(
            Services.IBookService bookService, ILogger<BookController> logger
        )
        {
            _bookService = bookService;
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var book = _bookService.getById(1);
            _logger.LogInformation("Fetched book with ID 1: {@Book}", book);

            return Ok(book);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            _logger.LogInformation("Fetching book with ID {BookId}", id);
            var book = _bookService.getById(id);
            if (book == null) return NotFound();

            return Ok(book);
        }

        [HttpPost]
        public IActionResult Create(Book book)
        {
            var createdBook = _bookService.create(book);
            _logger.LogInformation("Created a new book with ID {BookId}", createdBook.Id);

            return Ok(createdBook);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, Book book)
        {
            var updatedBook = _bookService.update(id, book);

            return Ok(updatedBook);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _bookService.delete(id);

            return NoContent();
        }
    }
}
