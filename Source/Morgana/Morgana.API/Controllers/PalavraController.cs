using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Morgana.Application.Interfaces;
using Morgana.Application.ViewModels.Vocabulario;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Morgana.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //[Authorize]
    public class PalavraController : ApiController
    {
        private readonly IPalavraAppService _palavraAppService;

        public PalavraController(IPalavraAppService palavraAppService)
        {
            _palavraAppService = palavraAppService;
        }

        // GET: api/<PalavraController>
        [HttpGet]
        public async Task<IEnumerable<PalavraViewModel>> Get()
        {
            return await _palavraAppService.ConsultaPalavras();
        }

        // GET api/<PalavraController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<PalavraController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<PalavraController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<PalavraController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
