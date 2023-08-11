using GestaoProdutos.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System.Collections.Generic;

namespace GestaoProdutos.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProdutoController : Controller
    {
        private static List<Produto> produtos = new List<Produto>();
        private static int id = 0;

        [HttpPost]
        public IActionResult AdicionarProduto([FromBody] Produto produto)
        {
            produto.Id = id++;
            produtos.Add(produto);
            return CreatedAtAction(nameof(ListaProdutoPorId), new { id = produto.Id }, produto);

        }


        [HttpGet]
        public IEnumerable<Produto> ListarProdutos([FromQuery] int skip = 0,
        [FromQuery] int take = 15)
        {
            return produtos.Skip(skip).Take(take);
        }


        [HttpGet("{id}")]
        public IActionResult ListaProdutoPorId(int id)
        {
            var produto = produtos.FirstOrDefault(produto => produto.Id == id);
            if (produto == null) return NotFound();
            return Ok(produto);
        }
    }
}