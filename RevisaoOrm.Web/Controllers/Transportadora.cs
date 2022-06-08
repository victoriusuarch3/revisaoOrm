using Microsoft.AspNetCore.Mvc;
using RevisaoOrm.Lib.Data;


namespace ProjetoML.Web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class Transportadora : ControllerBase
    {
        public ILogger<Transportadora> _log { get; set; }
        private readonly RevisaoOrmContext _Context;
        public Transportadora(ILogger<Transportadora> log, RevisaoOrmContext revisaoOrmContext)
        {
            _log = log;
            _Context = revisaoOrmContext;
        }
        
        
        [HttpGet("GetidTransportadora")]
        public IActionResult GetTransportadoraPeloId(int id)
        {
            var transportadoraDesejada = _Context.Transportadores.Find(id);
            return Ok(transportadoraDesejada);
        }
        [HttpGet("GetTransportadoras")]
        public IActionResult GetTransportadoras()
        {
            var transportadoras = _Context.Transportadores.ToList();
            return Ok(transportadoras);
        }
        [HttpPut("AlterarNomeTransportadoraID")]
        public IActionResult PutNomeTransportadora(int id, string nomeNovo)
        {
            _Context.Transportadores.Find(id).Nome = nomeNovo;
            _Context.SaveChanges();
            return Ok(_Context.Transportadores);
        }
        [HttpDelete("DeletarTransportadoraid")]
        public IActionResult DeletarTransportadoraPeloId(int id)
        {
            var transportadoraASerRemovida = _Context.Transportadores.Find(id);
            _Context.Transportadores.Remove(transportadoraASerRemovida);
            _Context.SaveChanges();
            return Ok(_Context.Transportadores);
        }
    }
}