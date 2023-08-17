using Microsoft.VisualStudio.TestTools.UnitTesting;
using GestaoProdutos.Controllers;
using GestaoProdutos.Data;
using GestaoProdutos.Data.Dtos;
using GestaoProdutos.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Moq;
using System.Collections.Generic;
using System.Linq;

namespace GestaoProdutos.Tests
{
    [TestClass]
    public class ProdutoControllerTests
    {
        [TestMethod]
        public void AdicionarProduto_DeveRetornarCreatedAtAction()
        {
            // Arrange
            var options = new DbContextOptionsBuilder<ProdutoContext>()
                .UseInMemoryDatabase(databaseName: "TestDatabase")
                .Options;

            using (var context = new ProdutoContext(options))
            {
                var mapperMock = new Mock<IMapper>();
                var controller = new ProdutoController(context, mapperMock.Object);

                var produtoDto = new CreateProdutoDto { /* definir propriedades aqui */ };

                // Act
                var result = controller.AdicionarProduto(produtoDto);

                // Assert
                Assert.IsInstanceOfType(result, typeof(CreatedAtActionResult));
            }
        }

        [TestMethod]
        public void ListarProdutos_DeveRetornarProdutos()
        {
            // Arrange
            var options = new DbContextOptionsBuilder<ProdutoContext>()
                .UseInMemoryDatabase(databaseName: "TestDatabase")
                .Options;

            using (var context = new ProdutoContext(options))
            {
                // Adicione produtos fictícios para testar a ação
                context.produtos.AddRange(new List<Produto>
                {
                    new Produto { Id = 1, /* definir outras propriedades */ },
                    new Produto { Id = 2, /* definir outras propriedades */ },
                    // ... Adicione mais produtos
                });
                context.SaveChanges();

                var mapperMock = new Mock<IMapper>();
                var controller = new ProdutoController(context, mapperMock.Object);

                // Act
                var result = controller.ListarProdutos();

                // Assert
                var produtosResult = result.ToList();
                Assert.IsTrue(produtosResult.Count > 0);
            }
        }

        [TestMethod]
        public void ListaProdutoPorId_DeveRetornarProdutoExistente()
        {
            // Arrange
            var options = new DbContextOptionsBuilder<ProdutoContext>()
                .UseInMemoryDatabase(databaseName: "TestDatabase")
                .Options;

            using (var context = new ProdutoContext(options))
            {
                // Adicione um produto fictício para testar a ação
                context.produtos.Add(new Produto { Id = 1, /* definir outras propriedades */ });
                context.SaveChanges();

                var mapperMock = new Mock<IMapper>();
                var controller = new ProdutoController(context, mapperMock.Object);

                // Act
                var result = controller.ListaProdutoPorId(1);

                // Assert
                Assert.IsInstanceOfType(result, typeof(OkObjectResult));
            }
        }

    }
}
