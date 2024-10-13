using Microsoft.VisualStudio.TestTools.UnitTesting;
using MixTiSolucoesApp; // Certifique-se de importar o namespace correto do projeto principal

[TestClass]
public class ProdutoTest
{
    [TestMethod]
    public void TestAdicionarProduto()
    {
        // Arrange
        var produtoService = new ProdutoService(); // Exemplo de uma classe de serviço
        var produto = new Produto { Nome = "Produto Teste", Preco = 10.00m, QuantidadeEstoque = 5 };

        // Act
        produtoService.Adicionar(produto);

        // Assert
        Assert.AreEqual("Produto Teste", produto.Nome);
        Assert.AreEqual(10.00m, produto.Preco);
        Assert.AreEqual(5, produto.QuantidadeEstoque);
    }
}
