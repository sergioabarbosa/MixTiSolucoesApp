namespace MixTiSolucoesApp
{
    partial class FormMain
    {
        private System.ComponentModel.IContainer components = null;

        // Declaração dos controles
        private MaterialSkin.Controls.MaterialButton btnGerenciarProdutos;
        private MaterialSkin.Controls.MaterialButton btnRelatorioVendas;
        private MaterialSkin.Controls.MaterialButton btnRelatorioEstoque;
        private MaterialSkin.Controls.MaterialButton btnVender;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código Gerado pelo Designer

        private void InitializeComponent()
        {
            // Todos os botões terão o mesmo tamanho de 200x40
            int buttonWidth = 200;
            int buttonHeight = 40;

            this.btnGerenciarProdutos = new MaterialSkin.Controls.MaterialButton();
            this.btnRelatorioVendas = new MaterialSkin.Controls.MaterialButton();
            this.btnRelatorioEstoque = new MaterialSkin.Controls.MaterialButton();
            this.btnVender = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();

            // 
            // btnGerenciarProdutos
            // 
            this.btnGerenciarProdutos.AutoSize = false;
            this.btnGerenciarProdutos.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnGerenciarProdutos.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnGerenciarProdutos.Depth = 0;
            this.btnGerenciarProdutos.HighEmphasis = true;
            this.btnGerenciarProdutos.Icon = null;
            this.btnGerenciarProdutos.Location = new System.Drawing.Point(259, 99);
            this.btnGerenciarProdutos.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnGerenciarProdutos.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnGerenciarProdutos.Name = "btnGerenciarProdutos";
            this.btnGerenciarProdutos.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnGerenciarProdutos.Size = new System.Drawing.Size(buttonWidth, buttonHeight); // Definindo o tamanho
            this.btnGerenciarProdutos.TabIndex = 0;
            this.btnGerenciarProdutos.Text = "Gerenciar Produtos";
            this.btnGerenciarProdutos.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnGerenciarProdutos.UseAccentColor = false;
            this.btnGerenciarProdutos.UseVisualStyleBackColor = true;
            this.btnGerenciarProdutos.Click += new System.EventHandler(this.btnGerenciarProdutos_Click);

            // 
            // btnRelatorioVendas
            // 
            this.btnRelatorioVendas.AutoSize = false;
            this.btnRelatorioVendas.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnRelatorioVendas.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnRelatorioVendas.Depth = 0;
            this.btnRelatorioVendas.HighEmphasis = true;
            this.btnRelatorioVendas.Icon = null;
            this.btnRelatorioVendas.Location = new System.Drawing.Point(259, 147);
            this.btnRelatorioVendas.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnRelatorioVendas.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnRelatorioVendas.Name = "btnRelatorioVendas";
            this.btnRelatorioVendas.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnRelatorioVendas.Size = new System.Drawing.Size(buttonWidth, buttonHeight); // Definindo o tamanho
            this.btnRelatorioVendas.TabIndex = 1;
            this.btnRelatorioVendas.Text = "Relatório de Vendas";
            this.btnRelatorioVendas.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnRelatorioVendas.UseAccentColor = false;
            this.btnRelatorioVendas.UseVisualStyleBackColor = true;
            this.btnRelatorioVendas.Click += new System.EventHandler(this.btnRelatorioVendas_Click);

            // 
            // btnRelatorioEstoque
            // 
            this.btnRelatorioEstoque.AutoSize = false;
            this.btnRelatorioEstoque.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnRelatorioEstoque.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnRelatorioEstoque.Depth = 0;
            this.btnRelatorioEstoque.HighEmphasis = true;
            this.btnRelatorioEstoque.Icon = null;
            this.btnRelatorioEstoque.Location = new System.Drawing.Point(259, 195);
            this.btnRelatorioEstoque.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnRelatorioEstoque.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnRelatorioEstoque.Name = "btnRelatorioEstoque";
            this.btnRelatorioEstoque.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnRelatorioEstoque.Size = new System.Drawing.Size(buttonWidth, buttonHeight); // Definindo o tamanho
            this.btnRelatorioEstoque.TabIndex = 2;
            this.btnRelatorioEstoque.Text = "Relatório de Estoque";
            this.btnRelatorioEstoque.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnRelatorioEstoque.UseAccentColor = false;
            this.btnRelatorioEstoque.UseVisualStyleBackColor = true;
            this.btnRelatorioEstoque.Click += new System.EventHandler(this.btnRelatorioEstoque_Click);

            // 
            // btnVender
            // 
            this.btnVender.AutoSize = false;
            this.btnVender.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnVender.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnVender.Depth = 0;
            this.btnVender.HighEmphasis = true;
            this.btnVender.Icon = null;
            this.btnVender.Location = new System.Drawing.Point(259, 243);
            this.btnVender.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnVender.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnVender.Name = "btnVender";
            this.btnVender.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnVender.Size = new System.Drawing.Size(buttonWidth, buttonHeight); // Definindo o tamanho
            this.btnVender.TabIndex = 3;
            this.btnVender.Text = "Vender";
            this.btnVender.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnVender.UseAccentColor = false;
            this.btnVender.UseVisualStyleBackColor = true;
            this.btnVender.Click += new System.EventHandler(this.btnVender_Click);

            // 
            // FormMain
            // 
            this.ClientSize = new System.Drawing.Size(718, 385);
            this.Controls.Add(this.btnVender);
            this.Controls.Add(this.btnGerenciarProdutos);
            this.Controls.Add(this.btnRelatorioVendas);
            this.Controls.Add(this.btnRelatorioEstoque);
            this.Name = "FormMain";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
    }
}
