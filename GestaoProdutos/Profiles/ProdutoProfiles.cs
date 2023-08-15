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
        }
    }
}


