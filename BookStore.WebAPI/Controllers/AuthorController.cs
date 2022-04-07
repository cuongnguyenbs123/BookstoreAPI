using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using BookStore.Core;
namespace BookStore.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorController : ControllerBase
    {
        private readonly IAuthorServices _authorServices;
        public AuthorController (IAuthorServices authorServices)
        {
            _authorServices = authorServices;  
        }
        [HttpGet]
        public IActionResult GetAuthors()
        {
            return Ok(_authorServices.GetAuthors());
        }
    }
}
