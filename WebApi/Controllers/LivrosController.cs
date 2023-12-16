using Manager.Interfaces;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TJ_Spassu_Blazor.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LivrosController : ControllerBase
    {
        private readonly ILivroManager _LivroManager;

        public LivrosController(ILivroManager LivroManager)
        {
            _LivroManager = LivroManager;
        }

        // GET: api/<LivrosController>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await _LivroManager.GetLivrosAsync());
        }

        // GET api/<LivrosController>/5
        [HttpGet("{codl}")]
        public async Task<IActionResult> Get(int codl)
        {
            return Ok(await _LivroManager.GetLivroAsync(codl));
        }

        // POST api/<LivrosController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<LivrosController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<LivrosController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
