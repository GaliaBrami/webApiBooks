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
        //static int id = 1;
        //static List<Book> books=new List<Book> {new Book(id++,"bla",""), new Book(id++, "blu",""), new Book(id++, "bli", "") };
        DataContext context=new DataContext();
        // GET: api/<BooksController>
        [HttpGet]
        public IEnumerable<Book> Get()
        {
            return context.Books;
        }

        // GET api/<BooksController>/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            Book b= context.Books.FirstOrDefault(x=>x.Id==id);
            if(b==null)
                return NotFound();
            return Ok(b);
        }

        // POST api/<BooksController>
        [HttpPost]
        public void Post([FromBody] Book b)
        {
            context.Books.Add(new Book(b.Title,b.Author,b.Description,true));
        }

        // PUT api/<BooksController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Book value)
        {
            Book b= context.Books.Find(x => x.Id == id);
            if (b == null)
                return NotFound();
            context.Books.Remove(b);

            b.Status = value.Status;
            b.Author = value.Author;
            b.Title = value.Title;
            b.Description = value.Description;
            context.Books.Add(b);
            return Ok();
            
        }
        // PUT api/<BooksController>/5
        [HttpPut("{id}/status")]
        public ActionResult PutStatus(int id)
        {
            Book b = context.Books.Find(x => x.Id == id);
            if (b == null)
                return NotFound();
            context.Books.Remove(b);
            b.Status = !b.Status;
            context.Books.Add(b);
            return Ok();

        }
        // DELETE api/<BooksController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            Book b = context.Books.Find(x => x.Id == id);
            if (b == null)
                return NotFound();
            context.Books.Remove(b);
            
            return Ok();
        }
    }
}
