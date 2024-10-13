-- Script para inserir dados de exemplo na tabela Produtos

INSERT INTO Produtos (Nome, Preco, QuantidadeEstoque)
VALUES
('Produto A', 10.00, 100),
('Produto B', 20.00, 50),
('Produto C', 30.00, 30);

-- Script para inserir dados de exemplo na tabela Vendas

INSERT INTO Vendas (ProdutoId, QuantidadeVendida, DataVenda)
VALUES
(1, 5, GETDATE()),
(2, 2, GETDATE()),
(3, 10, GETDATE());
