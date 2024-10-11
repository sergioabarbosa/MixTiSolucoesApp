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

            // Criar o MaterialSkinManager para aplicar o tema
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);

            // Definir tema e cores
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT; // Ou DARK
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Blue600, Primary.Blue700,
                Primary.Blue500, Accent.LightBlue200,
                TextShade.WHITE
            );
        }

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

        private MaterialButton btnGerenciarProdutos;
        private MaterialButton btnRelatorioVendas;
        private MaterialButton btnRelatorioEstoque;

        private void InitializeComponent()
        {
            this.btnGerenciarProdutos = new MaterialSkin.Controls.MaterialButton();
            this.btnRelatorioVendas = new MaterialSkin.Controls.MaterialButton();
            this.btnRelatorioEstoque = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // btnGerenciarProdutos
            // 
            this.btnGerenciarProdutos.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnGerenciarProdutos.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnGerenciarProdutos.Depth = 0;
            this.btnGerenciarProdutos.HighEmphasis = true;
            this.btnGerenciarProdutos.Icon = null;
            this.btnGerenciarProdutos.Location = new System.Drawing.Point(261, 102);
            this.btnGerenciarProdutos.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnGerenciarProdutos.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnGerenciarProdutos.Name = "btnGerenciarProdutos";
            this.btnGerenciarProdutos.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnGerenciarProdutos.Size = new System.Drawing.Size(180, 36);
            this.btnGerenciarProdutos.TabIndex = 0;
            this.btnGerenciarProdutos.Text = "Gerenciar Produtos";
            this.btnGerenciarProdutos.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnGerenciarProdutos.UseAccentColor = false;
            this.btnGerenciarProdutos.UseVisualStyleBackColor = true;
            this.btnGerenciarProdutos.Click += new System.EventHandler(this.btnGerenciarProdutos_Click);
            // 
            // btnRelatorioVendas
            // 
            this.btnRelatorioVendas.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnRelatorioVendas.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnRelatorioVendas.Depth = 0;
            this.btnRelatorioVendas.HighEmphasis = true;
            this.btnRelatorioVendas.Icon = null;
            this.btnRelatorioVendas.Location = new System.Drawing.Point(261, 193);
            this.btnRelatorioVendas.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnRelatorioVendas.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnRelatorioVendas.Name = "btnRelatorioVendas";
            this.btnRelatorioVendas.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnRelatorioVendas.Size = new System.Drawing.Size(181, 36);
            this.btnRelatorioVendas.TabIndex = 1;
            this.btnRelatorioVendas.Text = "Relatório de Vendas";
            this.btnRelatorioVendas.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnRelatorioVendas.UseAccentColor = false;
            this.btnRelatorioVendas.UseVisualStyleBackColor = true;
            this.btnRelatorioVendas.Click += new System.EventHandler(this.btnRelatorioVendas_Click);
            // 
            // btnRelatorioEstoque
            // 
            this.btnRelatorioEstoque.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnRelatorioEstoque.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnRelatorioEstoque.Depth = 0;
            this.btnRelatorioEstoque.HighEmphasis = true;
            this.btnRelatorioEstoque.Icon = null;
            this.btnRelatorioEstoque.Location = new System.Drawing.Point(252, 281);
            this.btnRelatorioEstoque.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnRelatorioEstoque.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnRelatorioEstoque.Name = "btnRelatorioEstoque";
            this.btnRelatorioEstoque.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnRelatorioEstoque.Size = new System.Drawing.Size(189, 36);
            this.btnRelatorioEstoque.TabIndex = 2;
            this.btnRelatorioEstoque.Text = "Relatório de Estoque";
            this.btnRelatorioEstoque.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnRelatorioEstoque.UseAccentColor = false;
            this.btnRelatorioEstoque.UseVisualStyleBackColor = true;
            this.btnRelatorioEstoque.Click += new System.EventHandler(this.btnRelatorioEstoque_Click);
            // 
            // FormMain
            // 
            this.ClientSize = new System.Drawing.Size(718, 385);
            this.Controls.Add(this.btnGerenciarProdutos);
            this.Controls.Add(this.btnRelatorioVendas);
            this.Controls.Add(this.btnRelatorioEstoque);
            this.Name = "FormMain";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
