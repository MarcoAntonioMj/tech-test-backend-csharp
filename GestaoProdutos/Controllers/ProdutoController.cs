using AutoMapper;
using GestaoProdutos.Data.Dtos;
using GestaoProdutos.Data;
using GestaoProdutos.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System.Collections.Generic;

namespace GestaoProdutos.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ProdutoController : Controller
{
    private ProdutoContext _context;
    private IMapper _mapper;


    public ProdutoController(ProdutoContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    [HttpPost]
    public IActionResult AdicionarProduto([FromBody] CreateProdutoDto produtoDto)
    {
        Produto produto = _mapper.Map<Produto>(produtoDto);
        _context.produtos.Add(produto);  
        _context.SaveChanges();
        return CreatedAtAction(nameof(ListaProdutoPorId), new { id = produto.Id }, produto);

    }


    [HttpGet]
    public IEnumerable<Produto> ListarProdutos([FromQuery] int skip = 0,
    [FromQuery] int take = 15)
    {
        return _context.produtos.Skip(skip).Take(take);
    }


    [HttpGet("{id}")]
    public IActionResult ListaProdutoPorId(int id)
    {
        var produto = _context.produtos.FirstOrDefault(produto => produto.Id == id);
        if (produto == null) return NotFound();
        return Ok(produto);
    }

    [HttpPut("{id}")]
    public IActionResult AtualizarProduto(int id, [FromBody] UpdateProdutoDto produtoDto)
    {
        var produto = _context.produtos.FirstOrDefault(produto => produto.Id == id);
        if (produto == null) return NotFound();
        else
        {
            _mapper.Map(produtoDto, produto);
            _context.SaveChanges();
            return NoContent();
        }
    }
}