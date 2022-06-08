using Microsoft.AspNetCore.Mvc;
using RevisaoOrm.Lib.Data;

namespace RevisaoOrm.Web.Controllers
{

    [ApiController]
    [Route("[Controller]")]

    public class Pedidos : ControllerBase
    {
        private readonly RevisaoOrmContext _context;
        public Pedidos(RevisaoOrmContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetTodos()
        {
            var pedidos = _context.Pedidos.ToList();
            return Ok(pedidos);
        }

         [HttpGet("{id}")]
        public IActionResult GetPeloId(int id)
        {
            return Ok(_context.Pedidos.Find(id));
        }

        [HttpPost()]
        public IActionResult SavePorId(Pedidos pedidos)
        {
            _context.Pedidos.Add(pedidos);
            _context.SaveChanges();
            return Ok();
        }

        [HttpPut()]
        public IActionResult verificarValor(int idPedido, DateTime datapedido)
        {
            var pedido = _context.Pedidos.Find(idPedido);
            pedido.DataPedido = datapedido;
            _context.SaveChanges();
            return Ok();
        }
        [HttpDelete("{id}")]
        public IActionResult DeletarpeloId(int id)
        {
            var pedido = _context.Pedidos.Find(id);
            _context.Pedidos.Remove(pedido);
            _context.SaveChanges();
            return Ok();
        }
    }
}