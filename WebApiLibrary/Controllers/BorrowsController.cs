using Microsoft.AspNetCore.Mvc;
using WebApiLibrary.Entities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApiLibrary.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BorrowsController : ControllerBase
    {
        static List<Borrow>borrows = new List<Borrow> { new Borrow(1,1,2,DateOnly.FromDateTime(DateTime.Now)), new Borrow(2, 2, 1, DateOnly.FromDateTime(DateTime.Now)), new Borrow(3, 3, 3, DateOnly.FromDateTime(DateTime.Now)) };
        // GET: api/<BorrowsController>
        [HttpGet]
        public IEnumerable<Borrow> Get()
        {
            return borrows;
        }

        // GET api/<BorrowsController>/5
        [HttpGet("{id}")]
        public Borrow Get(int id)
        {
            return borrows.FirstOrDefault(x=>x.Id==id);
        }

        // POST api/<BorrowsController>
        [HttpPost]
        public void Post([FromBody] Borrow value)
        {
            borrows.Add(value);
        }

        // PUT api/<BorrowsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Borrow value)
        {
            Borrow b = borrows.FirstOrDefault(x=>x.Id==id);
            b.MemberId=value.MemberId;
            b.BookId=value.BookId;
            b.Date=value.Date;
        }

        // DELETE api/<BorrowsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            Borrow b=borrows.FirstOrDefault(x=>x.Id==id);
            borrows.Remove(b);
        }
    }
}
