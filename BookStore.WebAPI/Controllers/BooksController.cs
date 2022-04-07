using Microsoft.AspNetCore.Mvc;
using BookStore.Core;
namespace BookStore.WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BooksController : ControllerBase
    {
        private readonly IBookServices _bookServices;
        //private readonly IAuthorServices _authorServices;
        public BooksController(IBookServices bookServices , IAuthorServices authorServices)
        {
            _bookServices = bookServices;
            //_authorServices = authorServices;  
        }

        [HttpGet]
        public IActionResult GetBooks()
        {
            return Ok(_bookServices.GetBooks());
        }
        //[HttpGet]
        //public IActionResult GetAuthors()
        //{
        //    return Ok(_authorServices.GetAuthors());
        //}
        [HttpGet("{id}", Name = "GetBook")]
        public IActionResult GetBook(string id)
        {
            return Ok(_bookServices.GetBook(id));
        }

        [HttpPost]
        public IActionResult AddBook(Book book)
        {
            _bookServices.AddBook(book);
            return CreatedAtRoute("GetBook", new { id = book.Id }, book);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteBook(string id)
        {
            _bookServices.DeleteBook(id);
            return NoContent();
        }

        [HttpPut]
        public IActionResult UpdateBook(Book book)
        {
            return Ok(_bookServices.UpdateBook(book));
        }

    }
}