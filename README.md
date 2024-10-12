# MixTiSolucoesApp - Sistema de Gerenciamento de Produtos e Vendas

Este projeto foi desenvolvido para gerenciar produtos e vendas, com funcionalidades de cadastro de produtos, geração de relatórios de vendas e estoque. A aplicação foi construída em **Windows Forms** com **C#**, utilizando **MaterialSkin** para a estilização da interface.

## Funcionalidades

- Cadastro de Produtos
- Edição e exclusão de Produtos
- Registro de vendas
- Relatório de Vendas
- Relatório de Estoque

## Tecnologias Utilizadas

- **C#**
- **Windows Forms**
- **MaterialSkin**: Framework para estilização da interface
- **SQL Server**: Banco de dados relacional
- **ADO.NET**: Para interação com o banco de dados
- **Stored Procedures**: Para manipulação de dados no banco de dados

## Pré-requisitos

Para executar este projeto, você precisará ter instalado:

- [Visual Studio 2022](https://visualstudio.microsoft.com/downloads/)
- [.NET Framework 4.7.2 ou superior](https://dotnet.microsoft.com/download/dotnet-framework)
- [SQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-downloads)

## Configuração do Ambiente

### Clonando o repositório

```bash
git clone https://github.com/seu-usuario/mix-ti-solucoes-app.git
cd mix-ti-solucoes-app
```

Configuração do Banco de Dados
Configure um banco de dados SQL Server em sua máquina local ou em um servidor.

No arquivo App.config, configure a string de conexão para o seu ambiente SQL Server:

<connectionStrings>
  <add name="MixTiSolucoesDB" connectionString="Data Source=SEU_SERVIDOR;Initial Catalog=MixTiSolucoesDB;Integrated Security=True" providerName="System.Data.SqlClient" />
</connectionStrings>

Rode o script SQL para criar o banco de dados e as tabelas necessárias. O script está localizado na pasta scripts do repositório.
```bash
-- Exemplo do script SQL:
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

-- Stored Procedures
CREATE PROCEDURE sp_RelatorioVendas
AS
BEGIN
  SELECT 
    V.VendaId,
    P.Nome AS NomeProduto,
    V.QuantidadeVendida,
    V.DataVenda
  FROM Vendas V
  JOIN Produtos P ON V.ProdutoId = P.ProdutoId;
END;
````

Executando a Aplicação
1. Abra o projeto no Visual Studio.
2. Compile o projeto para restaurar todos os pacotes NuGet e garantir que o projeto está sem erros.
3. Execute o projeto pressionando F5 ou clicando no botão de "Iniciar".

Funcionalidades do Sistema

Gerenciar Produtos
Adicione, edite e exclua produtos no sistema. Cada produto tem nome, preço e quantidade em estoque.

Registrar Vendas
Registre as vendas realizadas no sistema. Escolha o produto e insira a quantidade vendida.

Relatório de Vendas
Gere um relatório detalhado de todas as vendas realizadas. O relatório contém o ID da venda, nome do produto, quantidade vendida e data da venda.

Relatório de Estoque
Gere um relatório detalhado do estoque atual. O relatório contém o ID do produto, nome e quantidade em estoque.

Estrutura de Pastas
````bash
mix-ti-solucoes-app/
│
├── MixTiSolucoesApp/              # Diretório do código principal da aplicação
│   ├── Forms/                     # Formulários da aplicação (Windows Forms)
│   ├── Properties/                # Arquivos de configuração do Visual Studio
│   └── Resources/                 # Imagens e ícones usados no projeto
│
├── scripts/                       # Scripts SQL para criação e população do banco de dados
│   └── create_database.sql        # Script para criação do banco de dados
│
└── README.md                      # Documentação do projeto
````

Como Contribuir
Se desejar contribuir com o projeto, siga estas etapas:

Fork o repositório.
Crie um branch com sua nova feature (git checkout -b minha-feature).
Commit suas alterações (git commit -am 'Adiciona nova feature').
Push para o branch (git push origin minha-feature).
Abra um Pull Request.
Licença

Este projeto é licenciado sob a licença MIT - consulte o arquivo LICENSE.md para mais detalhes.

Você pode copiar e colar esse conteúdo diretamente no arquivo `README.md` do seu repositório GitHub.
