using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MixTiSolucoesApp
{
    public partial class FormGerenciarProdutos : Form
    {
        public FormGerenciarProdutos()
        {
            InitializeComponent();
        }

        // Método para carregar os produtos no DataGridView
        private void CarregarProdutos()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["MixTiSolucoesDB"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand("SELECT ProdutoId, Nome, Preco, QuantidadeEstoque FROM Produtos", conn);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dataGridViewProdutos.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao carregar os produtos: " + ex.Message);
                }
            }
        }

        private void FormGerenciarProdutos_Load(object sender, EventArgs e)
        {
            // Definir para true para que as colunas sejam geradas automaticamente
            dataGridViewProdutos.AutoGenerateColumns = true;

            CarregarProdutos(); // Carregar os produtos ao abrir o formulário
        }

        // Botão para atualizar a lista de produtos
        private void btnAtualizarLista_Click(object sender, EventArgs e)
        {
            CarregarProdutos(); // Recarregar os produtos
        }

        // Botão para adicionar um novo produto
        private void btnAdicionarProduto_Click(object sender, EventArgs e)
        {
            // Validar os campos
            if (string.IsNullOrEmpty(txtNomeProduto.Text) || string.IsNullOrEmpty(txtPrecoProduto.Text) || string.IsNullOrEmpty(txtQuantidadeProduto.Text))
            {
                MessageBox.Show("Por favor, preencha todos os campos.");
                return;
            }

            // Inserir o produto no banco de dados
            string connectionString = ConfigurationManager.ConnectionStrings["MixTiSolucoesDB"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand("INSERT INTO Produtos (Nome, Preco, QuantidadeEstoque) VALUES (@Nome, @Preco, @QuantidadeEstoque)", conn);
                    cmd.Parameters.AddWithValue("@Nome", txtNomeProduto.Text);
                    cmd.Parameters.AddWithValue("@Preco", decimal.Parse(txtPrecoProduto.Text));
                    cmd.Parameters.AddWithValue("@QuantidadeEstoque", int.Parse(txtQuantidadeProduto.Text));

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Produto adicionado com sucesso!");

                    // Limpar os campos
                    txtNomeProduto.Clear();
                    txtPrecoProduto.Clear();
                    txtQuantidadeProduto.Clear();

                    // Recarregar a lista de produtos
                    CarregarProdutos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao adicionar o produto: " + ex.Message);
                }
            }
        }

        // Botão para editar o produto selecionado
        private void btnEditarProduto_Click(object sender, EventArgs e)
        {
            if (dataGridViewProdutos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, selecione um produto para editar.");
                return;
            }

            // Capturar o ProdutoId da linha selecionada
            int produtoId = Convert.ToInt32(dataGridViewProdutos.SelectedRows[0].Cells["ProdutoId"].Value);

            // Abrir um formulário para edição (passaremos o ProdutoId para ele)
            FormEditarProduto formEditar = new FormEditarProduto(produtoId);
            formEditar.ShowDialog();

            // Após editar, recarregar a lista de produtos
            CarregarProdutos();
        }

        // Botão para excluir o produto selecionado
        private void btnExcluirProduto_Click(object sender, EventArgs e)
        {
            if (dataGridViewProdutos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, selecione um produto para excluir.");
                return;
            }

            int produtoId = Convert.ToInt32(dataGridViewProdutos.SelectedRows[0].Cells["ProdutoId"].Value);

            // Confirmar a exclusão
            DialogResult result = MessageBox.Show("Você tem certeza que deseja excluir este produto?", "Confirmação", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                // Excluir o produto do banco de dados
                ExcluirProduto(produtoId);
                CarregarProdutos(); // Recarregar a lista após exclusão
            }
        }

        // Método para excluir o produto
        private void ExcluirProduto(int produtoId)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["MixTiSolucoesDB"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand("DELETE FROM Produtos WHERE ProdutoId = @ProdutoId", conn);
                    cmd.Parameters.AddWithValue("@ProdutoId", produtoId);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Produto excluído com sucesso!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao excluir o produto: " + ex.Message);
                }
            }
        }

        // Habilitar os botões quando uma linha é selecionada
        private void dataGridViewProdutos_SelectionChanged(object sender, EventArgs e)
        {
            btnEditarProduto.Enabled = dataGridViewProdutos.SelectedRows.Count > 0;
            btnExcluirProduto.Enabled = dataGridViewProdutos.SelectedRows.Count > 0;
        }

        private void txtNomeProduto_Enter(object sender, EventArgs e)
        {
            if (txtNomeProduto.Text == "Nome do Produto")
            {
                txtNomeProduto.Text = "";
                txtNomeProduto.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void txtNomeProduto_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNomeProduto.Text))
            {
                txtNomeProduto.Text = "Nome do Produto";
                txtNomeProduto.ForeColor = System.Drawing.Color.Gray;
            }
        }

        private void txtPrecoProduto_Enter(object sender, EventArgs e)
        {
            if (txtPrecoProduto.Text == "Preço do Produto")
            {
                txtPrecoProduto.Text = "";
                txtPrecoProduto.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void txtPrecoProduto_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPrecoProduto.Text))
            {
                txtPrecoProduto.Text = "Preço do Produto";
                txtPrecoProduto.ForeColor = System.Drawing.Color.Gray;
            }
        }

        private void txtQuantidadeProduto_Enter(object sender, EventArgs e)
        {
            if (txtQuantidadeProduto.Text == "Quantidade")
            {
                txtQuantidadeProduto.Text = "";
                txtQuantidadeProduto.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void txtQuantidadeProduto_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtQuantidadeProduto.Text))
            {
                txtQuantidadeProduto.Text = "Quantidade";
                txtQuantidadeProduto.ForeColor = System.Drawing.Color.Gray;
            }
        }

        private void dataGridViewProdutos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Adicione sua lógica aqui (se necessário)
        }
    }
}
