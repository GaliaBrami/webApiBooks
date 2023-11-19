using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebApiLibrary.Entities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApiLibrary.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        static List<Book> books=new List<Book> {new Book(1,"bla"), new Book(2, "blu"), new Book(3, "bli") };

        // GET: api/<BooksController>
        [HttpGet]
        public IEnumerable<Book> Get()
        {
            return books;
        }

        // GET api/<BooksController>/5
        [HttpGet("{id}")]
        public Book Get(int id)
        {
            return books.FirstOrDefault(x=>x.Id==id);
        }

        // POST api/<BooksController>
        [HttpPost]
        public void Post([FromBody] Book b)
        {
            books.Add(b);
        }

        // PUT api/<BooksController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Book value)
        {
            Book b=books.Find(x => x.Id == id);
            b.Status = value.Status;
            b.Title = value.Title;
            b.Description = value.Description;
            
        }

        // DELETE api/<BooksController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
