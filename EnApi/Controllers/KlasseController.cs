using Hej;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EnApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KlasseController : ControllerBase
    {
        private KlasseRepo _repo;

        public KlasseController(KlasseRepo repo)
        {
            _repo = repo;
        }

        // GET: api/<KlasseController>
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [HttpGet]
        public ActionResult<IEnumerable<Klasse>> GetAll()
        {
            List<Klasse> klasse = _repo.GetAll();

            if (klasse.Count == 0) return NoContent();

            return Ok(klasse);
        }
        //hejwefwef
        //// GET api/<KlasseController>/5
        //[HttpGet("{id}")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        //// POST api/<KlasseController>
        //[HttpPost]
        //public void Post([FromBody] string value)
        //{
        //}

        //// PUT api/<KlasseController>/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        //// DELETE api/<KlasseController>/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
