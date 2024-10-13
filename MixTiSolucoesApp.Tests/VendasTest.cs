using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using MixTiSolucoesApp;

[TestClass]
public class VendaTests
{
    [TestMethod]
    public void TestRegistrarVenda()
    {
        // Arrange
        var mockProdutoService = new Mock<IProdutoService>();

        // Simulando produtos que serão retornados pelo serviço
        var produtos = new List<dynamic> {
            new { ProdutoId = 1, Nome = "Produto Teste" }
        };

        mockProdutoService.Setup(x => x.ObterProdutos()).Returns(produtos);

        // Simulando a injeção de dependência
        var formRegistrarVenda = new FormRegistrarVenda(mockProdutoService.Object);

        // Simulando a escolha de um produto no ComboBox
        formRegistrarVenda.cmbProduto.SelectedIndex = 0;

        // Simulando a entrada de uma quantidade vendida
        formRegistrarVenda.txtQuantidadeVendida.Text = "5";

        // Act
        formRegistrarVenda.btnFinalizarVenda.PerformClick();

        // Assert
        mockProdutoService.Verify(x => x.RegistrarVenda(1, 5), Times.Once);
    }
}
