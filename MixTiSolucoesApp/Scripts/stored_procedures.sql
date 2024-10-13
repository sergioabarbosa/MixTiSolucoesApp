-- Script para criar stored procedure de relatório de vendas

CREATE PROCEDURE sp_RelatorioVendas
AS
BEGIN
    SELECT V.VendaId, P.Nome AS NomeProduto, V.QuantidadeVendida, V.DataVenda
    FROM Vendas V
    JOIN Produtos P ON V.ProdutoId = P.ProdutoId;
END;
GO

-- Script para criar stored procedure de relatório de estoque

CREATE PROCEDURE sp_RelatorioEstoque
AS
BEGIN
    SELECT ProdutoId, Nome, QuantidadeEstoque
    FROM Produtos;
END;
GO
