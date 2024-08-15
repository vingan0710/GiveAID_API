using GiveAID_API.Models.ModelView;
using GiveAID_API.Models.Repository;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GiveAID_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        // GET: api/<AccountController>
        [HttpGet]
        public IEnumerable<AccountView> Get()
        {
            return GvieAIDRepository.Instance.GetAllAccount();
        }

        // GET api/<AccountController>/5
        [HttpGet("{id}")]
        public AccountView  Get(int Id)
        {
            return GvieAIDRepository.Instance.GetAccountbyId(Id);
        }

        // POST api/<AccountController>
        [HttpPost]
        public void Post([FromBody] string value)
        {

        }

        // PUT api/<AccountController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<AccountController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
