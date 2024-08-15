using GiveAID_API.Models.ModelView;
using GiveAID_API.Models.Repository;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GiveAID_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GalleryController : ControllerBase
    {
        // GET: api/<GalleryController>
        [HttpGet]
        public IEnumerable<GalleryView> Get()
        {
            return GvieAIDRepository.Instance.GetAllGallery();
        }

        // GET api/<GalleryController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<GalleryController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<GalleryController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<GalleryController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
