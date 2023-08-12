using System;
using GestaoProdutos.Models;
using Microsoft.EntityFrameworkCore;

namespace GestaoProdutos.Data
{
    public class ProdutoContext : DbContext
    {
        public ProdutoContext(DbContextOptions<ProdutoContext> options) : base(options)
        {

        }
        public DbSet<Produto> produtos { get; set; }
    }
}
