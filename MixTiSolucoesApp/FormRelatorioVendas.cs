using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MixTiSolucoesApp
{
    public partial class FormRelatorioVendas : Form
    {
        public FormRelatorioVendas()
        {
            InitializeComponent();
        }

        private void FormRelatorioVendas_Load(object sender, EventArgs e)
        {
            // Obter a string de conexão
            string connectionString = ConfigurationManager.ConnectionStrings["MixTiSolucoesDB"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    // Chamar a stored procedure de relatório de vendas
                    SqlCommand cmd = new SqlCommand("sp_RelatorioVendas", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Preencher o DataGridView com os dados retornados
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    // Exibir os dados no DataGridView
                    dataGridView1.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao gerar o relatório de vendas: " + ex.Message);
                }
            }
        }

        // Método opcional, se você quiser lidar com o clique na célula
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Implementação do evento CellContentClick, se necessário
        }
    }
}
