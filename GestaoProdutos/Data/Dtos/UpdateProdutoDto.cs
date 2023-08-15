using System.ComponentModel.DataAnnotations;

namespace GestaoProdutos.Data.Dtos;

public class UpdateProdutoDto
{
    [Required(ErrorMessage = "O nome do produto é obrigatório")]
    public string Nome { get; set; }

    [Required(ErrorMessage = "O preço do produto é obrigatório")]
    [Range(0, int.MaxValue, ErrorMessage = "O preço do produto deve ser um valor positivo")]
    public int Preco { get; set; }

    [Required(ErrorMessage = "A quantidade de produto é obrigatória")]
    public int QuantidadeEmEstoque { get; set; }

    [Required(ErrorMessage = "A data do produto é obrigatória")]
    public int DataDeCriacao { get; set; }
}


