using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MixTiSolucoesApp
{
    public partial class FormEditarProduto : Form
    {
        private int _produtoId;

        public FormEditarProduto(int produtoId)
        {
            InitializeComponent();
            _produtoId = produtoId;
        }

        private void FormEditarProduto_Load(object sender, EventArgs e)
        {
            // Carregar os dados do produto selecionado para edição
            CarregarProduto();
        }

        private void CarregarProduto()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["MixTiSolucoesDB"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("SELECT Nome, Preco, QuantidadeEstoque FROM Produtos WHERE ProdutoId = @ProdutoId", conn);
                    cmd.Parameters.AddWithValue("@ProdutoId", _produtoId);

                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        txtNome.Text = reader["Nome"].ToString();
                        txtPreco.Text = reader["Preco"].ToString();
                        txtQuantidadeEstoque.Text = reader["QuantidadeEstoque"].ToString();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao carregar o produto: " + ex.Message);
                }
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            AtualizarProduto();
            this.Close();
        }

        private void AtualizarProduto()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["MixTiSolucoesDB"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE Produtos SET Nome = @Nome, Preco = @Preco, QuantidadeEstoque = @QuantidadeEstoque WHERE ProdutoId = @ProdutoId", conn);

                    cmd.Parameters.AddWithValue("@Nome", txtNome.Text);
                    cmd.Parameters.AddWithValue("@Preco", decimal.Parse(txtPreco.Text));
                    cmd.Parameters.AddWithValue("@QuantidadeEstoque", int.Parse(txtQuantidadeEstoque.Text));
                    cmd.Parameters.AddWithValue("@ProdutoId", _produtoId);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Produto atualizado com sucesso!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao atualizar o produto: " + ex.Message);
                }
            }
        }

        // Método de evento adicionado para evitar erros no designer
        private void contextMenuStrip1_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            // Pode ficar vazio
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            // Você pode adicionar qualquer lógica que deseja executar quando o texto do campo txtNome mudar.
            // Caso não precise de nenhuma funcionalidade nesse evento, deixe o método vazio.
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            // Fechar o formulário sem salvar
            this.Close();
        }


    }
}
