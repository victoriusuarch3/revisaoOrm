using Microsoft.AspNetCore.Mvc;
using revisaoOrm.Classes;
using RevisaoOrm.Lib.Data;
using Microsoft.EntityFrameworkCore;

namespace RevisaoOrm.Web.Controllers
{
    [ApiController]
    [Route("[controller]")]

    public class VendedoresController : ControllerBase
    {
        private readonly RevisaoOrmContext _context;
        public VendedoresController(RevisaoOrmContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetTodos()
        {
            var usuarios = _context.Usuarios.ToList();
            return Ok(usuarios);
        }

        [HttpGet("{id}")]
        public IActionResult GetId(int id)
        {
            return Ok(_context.Vendedores.Find(id));
        }

        [HttpPost()]
        public IActionResult SaveId(Vendedores vendedores)
        {
            _context.Vendedores.Add(vendedores);
            _context.SaveChanges();
            return Ok();
        }


    }
}