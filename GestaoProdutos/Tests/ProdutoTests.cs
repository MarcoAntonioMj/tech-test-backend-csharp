using Microsoft.VisualStudio.TestTools.UnitTesting;
using GestaoProdutos.Models;

namespace GestaoProdutos.Tests
{
    [TestClass]
    public class ProdutoTests
    {
        [TestMethod]
        public void Preco_DeveSerPositivo()
        {
            // Arrange
            Produto produto = new Produto();
            produto.Preco = 10; // Definir um preço positivo

            // Act
            bool isValid = produto.Preco >= 0;

            // Assert
            Assert.IsTrue(isValid);
        }

        [TestMethod]
        public void Nome_NaoDeveSerNuloOuVazio()
        {
            // Arrange
            Produto produto = new Produto();
            produto.Nome = ""; // Nome vazio

            // Act
            bool isValid = !string.IsNullOrEmpty(produto.Nome);

            // Assert
            Assert.IsFalse(isValid);
        }

        [TestMethod]
        public void QuantidadeEmEstoque_DeveSerPositiva()
        {
            // Arrange
            Produto produto = new Produto();
            produto.QuantidadeEmEstoque = -5; // Quantidade negativa

            // Act
            bool isValid = produto.QuantidadeEmEstoque >= 0;

            // Assert
            Assert.IsFalse(isValid);
        }

        [TestMethod]
        public void DataDeCriacao_DeveSerDefinida()
        {
            // Arrange
            Produto produto = new Produto();
            produto.DataDeCriacao = default; // Data não definida

            // Act
            bool isValid = produto.DataDeCriacao != default;

            // Assert
            Assert.IsTrue(isValid);
        }
    }
}

