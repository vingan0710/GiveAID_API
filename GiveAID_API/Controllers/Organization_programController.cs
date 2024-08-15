using GiveAID_API.Models.ModelView;
using GiveAID_API.Models.Repository;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GiveAID_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Organization_programController : ControllerBase
    {
        // GET: api/<Organization_programController>
        [HttpGet]
        public IEnumerable<Organization_programView> Get()
        {
            return GvieAIDRepository.Instance.GetOrgbyOutstanding();
        }

        // GET api/<Organization_programController>/5
        [HttpGet("{id}")]
        public Organization_programView Get(int Id)
        {
            return GvieAIDRepository.Instance.GetOrgbyId(Id);
        }

        // POST api/<Organization_programController>
        [HttpPost]
        public void Post([FromBody] string value)
        {

        }

        // PUT api/<Organization_programController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<Organization_programController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
