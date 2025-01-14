using AutoMapper;
using GestaoProdutos.Data.Dtos;
using GestaoProdutos.Models;

namespace GestaoProdutos.Profiles
{
    public class ProdutoProfile : Profile
    {
        public ProdutoProfile()
        {
            CreateMap<CreateProdutoDto, Produto>();
            CreateMap<UpdateProdutoDto, Produto>();
            CreateMap<Produto, UpdateProdutoDto>();
            CreateMap<Produto, ProdutoDto>() // Adicionando mapeamento para ProdutoDto
               .ForMember(dest => dest.ValorTotal, opt => opt.MapFrom(src => src.Preco * src.QuantidadeEmEstoque));

        }
    }
}


