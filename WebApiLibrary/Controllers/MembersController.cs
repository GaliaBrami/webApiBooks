using Microsoft.AspNetCore.Mvc;
using WebApiLibrary.Entities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApiLibrary.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MembersController : ControllerBase
    {
        static List<Member> members=new List<Member> { new Member(1,"moshe"), new Member(2, "haim") , new Member(3, "tuvia") };
        // GET: api/<MembersController>
        [HttpGet]
        public IEnumerable<Member> Get()
        {
            return members;
        }

        // GET api/<MembersController>/5
        [HttpGet("{id}")]
        public Member Get(int id)
        {
            return members.FirstOrDefault(x=>x.Id==id);
        }

        // POST api/<MembersController>
        [HttpPost]
        public void Post([FromBody] Member value)
        {members.Add(value);
        }

        // PUT api/<MembersController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Member value)
        {
            Member m = members.FirstOrDefault(x=>x.Id==id);  
            m.Name=value.Name;
            m.Tel=value.Tel;
        }

        // DELETE api/<MembersController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
