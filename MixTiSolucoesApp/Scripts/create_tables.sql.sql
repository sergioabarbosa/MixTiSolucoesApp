-- Script para criar as tabelas Produtos e Vendas

CREATE TABLE Produtos (
    ProdutoId INT PRIMARY KEY IDENTITY(1,1),
    Nome NVARCHAR(100) NOT NULL,
    Preco DECIMAL(18, 2) NOT NULL,
    QuantidadeEstoque INT NOT NULL
);

CREATE TABLE Vendas (
    VendaId INT PRIMARY KEY IDENTITY(1,1),
    ProdutoId INT FOREIGN KEY REFERENCES Produtos(ProdutoId),
    QuantidadeVendida INT NOT NULL,
    DataVenda DATETIME NOT NULL DEFAULT GETDATE()
);
