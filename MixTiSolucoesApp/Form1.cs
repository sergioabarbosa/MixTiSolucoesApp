using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Configuration;

namespace MixTiSolucoesApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Código que será executado quando o formulário for carregado, se necessário
        }

        private void btnCadastrarProduto_Click(object sender, EventArgs e)
        {
            // Capturar os valores dos TextBoxes no formulário
            string nome = textBox1.Text;
            decimal preco;
            int quantidadeEstoque;

            // Verificar se o campo de preço e quantidade são válidos
            if (!decimal.TryParse(textBox2.Text, out preco))
            {
                MessageBox.Show("Por favor, insira um valor válido para o preço.");
                return;
            }

            if (!int.TryParse(txtQuantidadeEstoque.Text, out quantidadeEstoque))
            {
                MessageBox.Show("Por favor, insira um valor válido para a quantidade em estoque.");
                return;
            }

            // Obter a string de conexão do App.config
            string connectionString = ConfigurationManager.ConnectionStrings["MixTiSolucoesDB"].ConnectionString;

            // Abrir uma conexão com o banco de dados
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    // Chamar a stored procedure sp_AdicionarProduto
                    SqlCommand cmd = new SqlCommand("sp_AdicionarProduto", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Passar parâmetros para a procedure
                    cmd.Parameters.AddWithValue("@Nome", nome);
                    cmd.Parameters.AddWithValue("@Preco", preco);
                    cmd.Parameters.AddWithValue("@QuantidadeEstoque", quantidadeEstoque);

                    // Abrir a conexão e executar a procedure
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Produto cadastrado com sucesso!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao cadastrar o produto: " + ex.Message);
                }
            }
        }

        private void btnTestarConexao_Click(object sender, EventArgs e)
        {
            // Obter a string de conexão do App.config
            string connectionString = ConfigurationManager.ConnectionStrings["MixTiSolucoesDB"].ConnectionString;

            // Testar a conexão com o banco de dados
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();  // Tenta abrir a conexão
                    MessageBox.Show("Conexão com o banco de dados bem-sucedida!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao conectar ao banco de dados: " + ex.Message);
                }
                finally
                {
                    conn.Close();  // Garante que a conexão seja fechada, mesmo em caso de erro
                }
            }
        }

        private void btnTestarConexao_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
