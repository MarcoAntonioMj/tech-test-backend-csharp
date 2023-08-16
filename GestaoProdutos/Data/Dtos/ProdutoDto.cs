using System.ComponentModel.DataAnnotations;

namespace GestaoProdutos.Data.Dtos;

public class ProdutoDto
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public int Preco { get; set; }
    public int QuantidadeEmEstoque { get; set; }
    public int DataDeCriacao { get; set; }
    public int ValorTotal { get; set; }
}

