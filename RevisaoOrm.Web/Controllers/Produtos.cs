using Microsoft.AspNetCore.Mvc;
using revisaoOrm.Classes;
using RevisaoOrm.Lib.Data;

namespace RevisaoOrm.Web.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class ProdutosController : ControllerBase
    {
        private readonly RevisaoOrmContext _Context;
        public ProdutosController(RevisaoOrmContext context)
        {
            _Context = context;
        }

        [HttpGet]
        public IActionResult GetTodos()
        {
            var Produtos = _Context.Produtos.ToList();
            return Ok(Produtos);
        }

        [HttpGet("{id}")]
        public IActionResult GetPorId(int id)
        {
            return Ok(_Context.Produtos.Find(id));
        }

        [HttpPost()]
        public IActionResult SalvarporId(Produtos produtos)
        {
            _Context.Produtos.Add(produtos);
            _Context.SaveChanges();
            return Ok();
        }
        [HttpPut()]
        public IActionResult Valor(int IdProdutos, double valor)
        {
            var produtos = _Context.Produtos.Find(IdProdutos);
            produtos.Valor = Convert.ToSingle(valor);
            _Context.SaveChanges();
            return Ok();
        }

        [HttpDelete("id")]
        public IActionResult DeletarPorId(int id)
        {
            var produtos = _Context.Produtos.Find(id);
            _Context.Produtos.Remove(produtos);
            _Context.SaveChanges();
            return Ok();
        }

    }
}