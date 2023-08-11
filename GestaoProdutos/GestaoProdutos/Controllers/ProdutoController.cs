using GestaoProdutos.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace GestaoProdutos.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProdutoController : Controller
    {
        private static List<Produto> produtos = new List<Produto>();

        [HttpPost]
        public void AdicionarProduto([FromBody] Produto produto)
        {
            produtos.Add(produto);
            Console.WriteLine(produto.Nome);
            Console.WriteLine(produto.Preco);
            Console.WriteLine(produto.QuantidadeEmEstoque);
            Console.WriteLine(produto.DataDeCriacao);

        }
    }
}

