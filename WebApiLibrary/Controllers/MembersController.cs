using Microsoft.AspNetCore.Mvc;
using WebApiLibrary.Entities;
using static System.Reflection.Metadata.BlobBuilder;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApiLibrary.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MembersController : ControllerBase
    {
        //static int id = 1;
        //static List<Member> members=new List<Member> { new Member(id++,"moshe",true), new Member(id++, "haim",true) , new Member(id++, "tuvia", true) };
        DataContext context=new DataContext();

        // GET: api/<MembersController>
        [HttpGet]
        public IEnumerable<Member> Get()
        {
            return context.Members;
        }

        // GET api/<MembersController>/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            Member m= context.Members.Find(x=>x.Id==id);
            if (m == null)
                return NotFound();
            return Ok(m);
        }

        // POST api/<MembersController>
        [HttpPost]
        public void Post([FromBody] Member value)
        {
            context.Members.Add(new Member(value.Name,true,value.Tel));
        }

        // PUT api/<MembersController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Member value)
        {
            Member m = context.Members.Find(x=>x.Id==id);
            if (m == null)
                return NotFound();
            context.Members.Remove(m);
            m.Name=value.Name;
            m.Tel=value.Tel;
            m.Status = value.Status;

            context.Members.Add(m);
            return Ok();
           
        }

        // DELETE api/<MembersController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            Member m = context.Members.Find(x => x.Id == id);
            if (m == null)
                return NotFound();
            context.Members.Remove(m);
            return Ok();
        }
    }
}
