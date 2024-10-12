MixTiSolucoesApp - Sistema de Gerenciamento de Produtos e Vendas
================================================================

Este projeto foi desenvolvido para gerenciar produtos e vendas, com funcionalidades de cadastro de produtos, geração de relatórios de vendas e estoque. A aplicação foi construída em **Windows Forms** com **C#**, utilizando **MaterialSkin** para a estilização da interface.

Funcionalidades
---------------

*   Cadastro de Produtos
    
*   Edição e exclusão de Produtos
    
*   Registro de vendas
    
*   Relatório de Vendas
    
*   Relatório de Estoque
    

Tecnologias Utilizadas
----------------------

*   **C#**
    
*   **Windows Forms**
    
*   **MaterialSkin**: Framework para estilização da interface
    
*   **SQL Server**: Banco de dados relacional
    
*   **ADO.NET**: Para interação com o banco de dados
    
*   **Stored Procedures**: Para manipulação de dados no banco de dados
    

Pré-requisitos
--------------

Para executar este projeto, você precisará ter instalado:

*   [Visual Studio 2022](https://visualstudio.microsoft.com/downloads/)
    
*   [.NET Framework 4.7.2 ou superior](https://dotnet.microsoft.com/download/dotnet-framework)
    
*   [SQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-downloads)
    

Configuração do Ambiente
------------------------

### Clonando o repositório

1.  bashCopiar códigogit clone https://github.com/seu-usuario/mix-ti-solucoes-app.gitcd mix-ti-solucoes-app
    

### Configuração do Banco de Dados

1.  Configure um banco de dados **SQL Server** em sua máquina local ou em um servidor.
    
2.  xmlCopiar código
    
3.  sqlCopiar código--
Exemplo do script SQL:CREATE TABLE Produtos ( ProdutoId INT PRIMARY KEY IDENTITY(1,1), Nome NVARCHAR(100) NOT NULL, Preco DECIMAL(18, 2) NOT NULL, QuantidadeEstoque INT NOT NULL);CREATE TABLE Vendas ( VendaId INT PRIMARY KEY IDENTITY(1,1), ProdutoId INT FOREIGN KEY REFERENCES Produtos(ProdutoId), QuantidadeVendida INT NOT NULL, DataVenda DATETIME NOT NULL DEFAULT GETDATE());-- Stored ProceduresCREATE PROCEDURE sp\_RelatorioVendasASBEGIN SELECT V.VendaId, P.Nome AS NomeProduto, V.QuantidadeVendida, V.DataVenda FROM Vendas V JOIN Produtos P ON V.ProdutoId = P.ProdutoId;END;
    

### Executando a Aplicação

1.  Abra o projeto no **Visual Studio**.
    
2.  Compile o projeto para restaurar todos os pacotes NuGet e garantir que o projeto está sem erros.
    
3.  Execute o projeto pressionando F5 ou clicando no botão de "Iniciar".
    

### Funcionalidades do Sistema

#### Gerenciar Produtos

*   Adicione, edite e exclua produtos no sistema. Cada produto tem nome, preço e quantidade em estoque.
    

#### Registrar Vendas

*   Registre as vendas realizadas no sistema. Escolha o produto e insira a quantidade vendida.
    

#### Relatório de Vendas

*   Gere um relatório detalhado de todas as vendas realizadas. O relatório contém o ID da venda, nome do produto, quantidade vendida e data da venda.
    

#### Relatório de Estoque

*   Gere um relatório detalhado do estoque atual. O relatório contém o ID do produto, nome e quantidade em estoque.
    

### Estrutura de Pastas

├── MixTiSolucoesApp/              # Diretório do código principal da aplicação  │   ├── Forms/                     # Formulários da aplicação (Windows Forms)  │   ├── Properties/                # Arquivos de configuração do Visual Studio  │   └── Resources/                 # Imagens e ícones usados no projeto  │  ├── scripts/                       # Scripts SQL para criação e população do banco de dados  │   └── create_database.sql        # Script para criação do banco de dados  │  └── README.md                      # Documentação do projeto   `

Como Contribuir
---------------

Se desejar contribuir com o projeto, siga estas etapas:

1.  Fork o repositório.
    
2.  Crie um branch com sua nova feature (git checkout -b minha-feature).
    
3.  Commit suas alterações (git commit -am 'Adiciona nova feature').
    
4.  Push para o branch (git push origin minha-feature).
    
5.  Abra um Pull Request.
    

Licença
-------

Este projeto é licenciado sob a licença MIT.
