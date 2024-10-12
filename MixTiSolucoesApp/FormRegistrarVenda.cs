using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MixTiSolucoesApp
{
    public partial class FormRegistrarVenda : Form
    {
        public FormRegistrarVenda()
        {
            InitializeComponent();
        }

        private void FormRegistrarVenda_Load(object sender, EventArgs e)
        {
            // Aqui você pode carregar a lista de produtos para o ComboBox
            CarregarProdutos();
        }

        private void CarregarProdutos()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["MixTiSolucoesDB"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("SELECT ProdutoId, Nome FROM Produtos", conn);
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        cmbProduto.Items.Add(new { ProdutoId = reader["ProdutoId"], Nome = reader["Nome"].ToString() });
                    }

                    cmbProduto.DisplayMember = "Nome";
                    cmbProduto.ValueMember = "ProdutoId";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao carregar os produtos: " + ex.Message);
                }
            }
        }

        private void btnFinalizarVenda_Click(object sender, EventArgs e)
        {
            // Obter os dados da venda do formulário (produto, quantidade, etc.)
            int produtoId = Convert.ToInt32(((dynamic)cmbProduto.SelectedItem).ProdutoId);
            int quantidadeVendida = Convert.ToInt32(txtQuantidadeVendida.Text);

            // Registrar a venda no banco de dados
            RegistrarVenda(produtoId, quantidadeVendida);
        }

        private void RegistrarVenda(int produtoId, int quantidadeVendida)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["MixTiSolucoesDB"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    // Query para inserir a venda na tabela Vendas
                    SqlCommand cmd = new SqlCommand("INSERT INTO Vendas (ProdutoId, QuantidadeVendida, DataVenda) VALUES (@ProdutoId, @QuantidadeVendida, GETDATE())", conn);
                    cmd.Parameters.AddWithValue("@ProdutoId", produtoId);
                    cmd.Parameters.AddWithValue("@QuantidadeVendida", quantidadeVendida);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Venda registrada com sucesso!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao registrar venda: " + ex.Message);
                }
            }
        }
    }
}
