using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using MixTiSolucoesApp;
using System.Windows.Forms;

[TestClass]
public class VendaTests
{
    [TestMethod]
    public void TestRegistrarVenda()
    {
        // Arrange
        var mockProdutoService = new Mock<IProdutoService>();

        // Simulando a injeção de dependência
        var formRegistrarVenda = new FormRegistrarVenda(mockProdutoService.Object);

        // Simulando a escolha de um produto no ComboBox
        formRegistrarVenda.cmbProduto.Items.Add(new { ProdutoId = 1, Nome = "Produto Teste" });
        formRegistrarVenda.cmbProduto.SelectedIndex = 0;

        // Simulando a entrada de uma quantidade vendida
        formRegistrarVenda.txtQuantidadeVendida.Text = "5";

        // Act
        formRegistrarVenda.btnFinalizarVenda.PerformClick();

        // Assert
        mockProdutoService.Verify(x => x.RegistrarVenda(1, 5), Times.Once);
    }
}
