using Domain.Entities;
using Manager.Interfaces.Livros;
using Microsoft.AspNetCore.Mvc;

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
        public async Task<IActionResult> Post(Livro livro)
        {
            var livroInserido = _LivroManager.InsertLivroAsync(livro);
            return CreatedAtAction(nameof(Get), new { codl = livro.Codl }, livro);
        }

        // PUT api/<LivrosController>
        [HttpPut]
        public async Task<IActionResult> Put(Livro livro)
        {
            var livroAtualizado = await _LivroManager.UpdateLivroAsync(livro);
            if (livroAtualizado == null)
            {
                return NotFound();
            }
            return Ok(livroAtualizado);
        }

        // DELETE api/<LivrosController>/5
        [HttpDelete("{codl}")]
        public async Task<IActionResult> Delete(int codl)
        {
            await _LivroManager.DeleteLivroAsync(codl);
            return NoContent();
        }
    }
}
