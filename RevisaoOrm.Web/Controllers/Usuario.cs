using Microsoft.AspNetCore.Mvc;
using revisaoOrm.Classes;
using RevisaoOrm.Lib.Data;
using Microsoft.EntityFrameworkCore;

namespace RevisaoOrm.Web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    
    public class UsuarioControllers : ControllerBase
    {
        private readonly RevisaoOrmContext _context; 
        public UsuarioControllers(RevisaoOrmContext context)
        {
            _context = context;
        }
    

        [HttpGet()]
        public IActionResult GetTodos()
        {
            var usuarios = _context.Usuarios.ToList();
            return Ok(usuarios);
        }
        [HttpGet("{id}")]
        public IActionResult GetId(int id)
        {
            return Ok(_context.Usuarios.Find(id));
        }
        [HttpPost()]
        public IActionResult SavarId(Usuarios usuario)
        {
            _context.Usuarios.Add(usuario);
            _context.SaveChanges();
            return Ok();
        }

        [HttpDelete("DeletarUsuario/{id}")]
        public IActionResult DeletarUsuarioId(int id)
        {
            var usuario = _context.Usuarios.Find(id);
            _context.Usuarios.Remove(usuario);
            _context.SaveChanges();
            return Ok("Usuario Removido.");
        }
        
        [HttpPut("AlterarSenha/{id}/{senha}")]
        public IActionResult AlterarSenha(int id, string senha)
        {
            var usuario = _context.Usuarios.Find(id);
            usuario.Senha = senha;
            _context.SaveChanges();
            return Ok(usuario);
        }
    }
}