using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace RESTAPIs.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        static List<Models.Book> books = new List<Models.Book>
        {
            new Models.Book { Id = 1, Title = "The Great Gatsby", Author = "F. Scott Fitzgerald", YearPublished = 1925 },
            new Models.Book { Id = 2, Title = "To Kill a Mockingbird", Author = "Harper Lee", YearPublished = 1960 },
            new Models.Book { Id = 3, Title = "1984", Author = "George Orwell", YearPublished = 1949 }
        };

        [HttpGet]
        public ActionResult<IEnumerable<Models.Book>> GetBooks()
        {
            return Ok(books);
        }
    }
}
