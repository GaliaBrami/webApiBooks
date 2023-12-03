using Microsoft.AspNetCore.Mvc;
using WebApiLibrary.Entities;
using static System.Reflection.Metadata.BlobBuilder;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApiLibrary.Controllers
{
    
    [Route("api/[controller]")]
    [ApiController]
    public class BorrowsController : ControllerBase
    {
        //static int id = 1;
        //static List<Borrow>borrows = new List<Borrow> { new Borrow(id++,1,2,true), new Borrow(id++, 2, 1, true), new Borrow(id++, 3, 3, true) };
        DataContext context = new DataContext();
        // GET: api/<BorrowsController>
        [HttpGet]
        public IEnumerable<Borrow> Get()
        {
            return context.Borrows;
        }

        // GET api/<BorrowsController>/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
           Borrow b= context.Borrows.Find(x=>x.Id==id);
            if (b == null)
                return NotFound();
            return Ok(b);
        }

        // POST api/<BorrowsController>
        [HttpPost]
        public void Post([FromBody] Borrow value)
        {

            context.Borrows.Add(new Borrow(value.MemberId,value.BookId,true));
        }

        // PUT api/<BorrowsController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Borrow value)
        {
            Borrow b = context.Borrows.Find(x=>x.Id==id);
            if (b == null)
                return NotFound();
            context.Borrows.Remove(b);

            b.MemberId=value.MemberId;
            b.BookId=value.BookId;
            b.Status=value.Status;
            context.Borrows.Add(b);
            return Ok();
           
        }
        // PUT api/<BorrowsController>/5
        [HttpPut("{id}/status")]
        public ActionResult PutStats(int id)
        {
            Borrow b = context.Borrows.FirstOrDefault(x => x.Id == id);
            
            if (b == null)
                return NotFound();
            context.Borrows.Remove(b);
            b.Status = !b.Status;
            context.Borrows.Add(b);
            return Ok();
            

        }

        //// DELETE api/<BorrowsController>/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
