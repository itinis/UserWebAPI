using Microsoft.AspNetCore.Mvc;
using UserApiBL;

namespace UserWebAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        IUserBL userBL;
        public UserController(IUserBL userBL)
        {
            this.userBL = userBL;
        }
        // GET: api/<UserController>
        [HttpGet("getAll")]
        public async Task<ActionResult<List<string>>> GetAll()
        {
            var res = await userBL.GetAll();
            return res;
        }
        //// POST api/<UserController>
      
        [HttpPost("insertAll")]
        public async Task<ActionResult<bool>> InsertAll([FromBody] Object  value)
        {
            string a="";
            var res = await userBL.insertAll(a);
            return res;
        }
     
   
        //// GET api/<UserController>/5
        //[HttpGet("{id}")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        //// POST api/<UserController>
        //[HttpPost]
        //public void Post([FromBody] string value)
        //{
        //}

        //// PUT api/<UserController>/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        //// DELETE api/<UserController>/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
