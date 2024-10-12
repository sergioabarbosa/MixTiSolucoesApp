using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Windows.Forms;

namespace MixTiSolucoesApp
{
    public partial class FormMain : MaterialForm
    {
        private MaterialSkinManager materialSkinManager;

        public FormMain()
        {
            InitializeComponent();

            // Configuração do MaterialSkinManager
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Blue600, Primary.Blue700,
                Primary.Blue500, Accent.LightBlue200,
                TextShade.WHITE
            );
        }

        // Eventos dos botões
        private void btnGerenciarProdutos_Click(object sender, EventArgs e)
        {
            FormGerenciarProdutos formGerenciarProdutos = new FormGerenciarProdutos();
            formGerenciarProdutos.ShowDialog();
        }

        private void btnRelatorioVendas_Click(object sender, EventArgs e)
        {
            FormRelatorioVendas formRelatorioVendas = new FormRelatorioVendas();
            formRelatorioVendas.ShowDialog();
        }

        private void btnRelatorioEstoque_Click(object sender, EventArgs e)
        {
            FormRelatorioEstoque formRelatorioEstoque = new FormRelatorioEstoque();
            formRelatorioEstoque.ShowDialog();
        }

        private void btnVender_Click(object sender, EventArgs e)
        {
            FormRegistrarVenda formRegistrarVenda = new FormRegistrarVenda();
            formRegistrarVenda.ShowDialog();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }
    }
}
