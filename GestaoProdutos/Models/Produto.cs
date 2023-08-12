using System.ComponentModel.DataAnnotations;

namespace GestaoProdutos.Models;

public class Produto
{
    [Key]
    [Required]
    public int Id { get; set; }

    [Required(ErrorMessage = "O nome do produto é obrigatório")]
    public string Nome { get; set; }

    [Required(ErrorMessage = "O preço do produto é obrigatório")]
    [Range(0, int.MaxValue, ErrorMessage = "O preço do produto deve ser um valor positivo")]
    public int Preco { get; set; }

    [Required(ErrorMessage = "A Quantidade de produto é obrigatório")]
    public int QuantidadeEmEstoque { get; set; }

    [Required(ErrorMessage = "O data do produto é obrigatório")]
    public int DataDeCriacao { get; set; }

   


}