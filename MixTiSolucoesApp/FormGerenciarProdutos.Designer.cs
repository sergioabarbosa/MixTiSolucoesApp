using System.Drawing;
using System.Windows.Forms;

namespace MixTiSolucoesApp
{
    partial class FormGerenciarProdutos
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dataGridViewProdutos;
        private System.Windows.Forms.Button btnEditarProduto;
        private System.Windows.Forms.Button btnExcluirProduto;
        private System.Windows.Forms.Button btnAtualizarLista;
        private System.Windows.Forms.Button btnAdicionarProduto;
        private System.Windows.Forms.TextBox txtNomeProduto;
        private System.Windows.Forms.TextBox txtPrecoProduto;
        private System.Windows.Forms.TextBox txtQuantidadeProduto;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGerenciarProdutos));
            this.dataGridViewProdutos = new System.Windows.Forms.DataGridView();
            this.btnEditarProduto = new System.Windows.Forms.Button();
            this.btnExcluirProduto = new System.Windows.Forms.Button();
            this.btnAtualizarLista = new System.Windows.Forms.Button();
            this.btnAdicionarProduto = new System.Windows.Forms.Button();
            this.txtNomeProduto = new System.Windows.Forms.TextBox();
            this.txtPrecoProduto = new System.Windows.Forms.TextBox();
            this.txtQuantidadeProduto = new System.Windows.Forms.TextBox();
            this.lblAddProduct = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProdutos)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewProdutos
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridViewProdutos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewProdutos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewProdutos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewProdutos.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewProdutos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewProdutos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridViewProdutos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewProdutos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewProdutos.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewProdutos.EnableHeadersVisualStyles = false;
            this.dataGridViewProdutos.GridColor = System.Drawing.Color.LightGray;
            this.dataGridViewProdutos.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewProdutos.Name = "dataGridViewProdutos";
            this.dataGridViewProdutos.RowHeadersVisible = false;
            this.dataGridViewProdutos.Size = new System.Drawing.Size(776, 300);
            this.dataGridViewProdutos.TabIndex = 0;
            this.dataGridViewProdutos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewProdutos_CellContentClick);
            // 
            // btnEditarProduto
            // 
            this.btnEditarProduto.Image = ((System.Drawing.Image)(resources.GetObject("btnEditarProduto.Image")));
            this.btnEditarProduto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditarProduto.Location = new System.Drawing.Point(12, 328);
            this.btnEditarProduto.Name = "btnEditarProduto";
            this.btnEditarProduto.Size = new System.Drawing.Size(120, 40);
            this.btnEditarProduto.TabIndex = 1;
            this.btnEditarProduto.Text = "Editar";
            this.btnEditarProduto.UseVisualStyleBackColor = true;
            this.btnEditarProduto.Click += new System.EventHandler(this.btnEditarProduto_Click);
            // 
            // btnExcluirProduto
            // 
            this.btnExcluirProduto.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluirProduto.Image")));
            this.btnExcluirProduto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcluirProduto.Location = new System.Drawing.Point(140, 328);
            this.btnExcluirProduto.Name = "btnExcluirProduto";
            this.btnExcluirProduto.Size = new System.Drawing.Size(120, 40);
            this.btnExcluirProduto.TabIndex = 2;
            this.btnExcluirProduto.Text = "Excluir";
            this.btnExcluirProduto.UseVisualStyleBackColor = true;
            this.btnExcluirProduto.Click += new System.EventHandler(this.btnExcluirProduto_Click);
            // 
            // btnAtualizarLista
            // 
            this.btnAtualizarLista.Image = ((System.Drawing.Image)(resources.GetObject("btnAtualizarLista.Image")));
            this.btnAtualizarLista.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAtualizarLista.Location = new System.Drawing.Point(668, 328);
            this.btnAtualizarLista.Name = "btnAtualizarLista";
            this.btnAtualizarLista.Size = new System.Drawing.Size(120, 40);
            this.btnAtualizarLista.TabIndex = 3;
            this.btnAtualizarLista.Text = "Atualizar";
            this.btnAtualizarLista.UseVisualStyleBackColor = true;
            this.btnAtualizarLista.Click += new System.EventHandler(this.btnAtualizarLista_Click);
            // 
            // btnAdicionarProduto
            // 
            this.btnAdicionarProduto.Image = ((System.Drawing.Image)(resources.GetObject("btnAdicionarProduto.Image")));
            this.btnAdicionarProduto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdicionarProduto.Location = new System.Drawing.Point(668, 397);
            this.btnAdicionarProduto.Name = "btnAdicionarProduto";
            this.btnAdicionarProduto.Size = new System.Drawing.Size(120, 41);
            this.btnAdicionarProduto.TabIndex = 4;
            this.btnAdicionarProduto.Text = "Adicionar";
            this.btnAdicionarProduto.UseVisualStyleBackColor = true;
            this.btnAdicionarProduto.Click += new System.EventHandler(this.btnAdicionarProduto_Click);
            // 
            // txtNomeProduto
            // 
            this.txtNomeProduto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtNomeProduto.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtNomeProduto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNomeProduto.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtNomeProduto.ForeColor = System.Drawing.Color.Gray;
            this.txtNomeProduto.Location = new System.Drawing.Point(12, 413);
            this.txtNomeProduto.Name = "txtNomeProduto";
            this.txtNomeProduto.Size = new System.Drawing.Size(180, 25);
            this.txtNomeProduto.TabIndex = 5;
            this.txtNomeProduto.Text = "Nome do Produto";
            this.txtNomeProduto.Enter += new System.EventHandler(this.txtNomeProduto_Enter);
            this.txtNomeProduto.Leave += new System.EventHandler(this.txtNomeProduto_Leave);
            // 
            // txtPrecoProduto
            // 
            this.txtPrecoProduto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtPrecoProduto.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtPrecoProduto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPrecoProduto.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtPrecoProduto.ForeColor = System.Drawing.Color.Gray;
            this.txtPrecoProduto.Location = new System.Drawing.Point(198, 413);
            this.txtPrecoProduto.Name = "txtPrecoProduto";
            this.txtPrecoProduto.Size = new System.Drawing.Size(180, 25);
            this.txtPrecoProduto.TabIndex = 6;
            this.txtPrecoProduto.Text = "Preço do Produto";
            this.txtPrecoProduto.Enter += new System.EventHandler(this.txtPrecoProduto_Enter);
            this.txtPrecoProduto.Leave += new System.EventHandler(this.txtPrecoProduto_Leave);
            // 
            // txtQuantidadeProduto
            // 
            this.txtQuantidadeProduto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtQuantidadeProduto.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtQuantidadeProduto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtQuantidadeProduto.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtQuantidadeProduto.ForeColor = System.Drawing.Color.Gray;
            this.txtQuantidadeProduto.Location = new System.Drawing.Point(384, 413);
            this.txtQuantidadeProduto.Name = "txtQuantidadeProduto";
            this.txtQuantidadeProduto.Size = new System.Drawing.Size(180, 25);
            this.txtQuantidadeProduto.TabIndex = 7;
            this.txtQuantidadeProduto.Text = "Quantidade";
            this.txtQuantidadeProduto.Enter += new System.EventHandler(this.txtQuantidadeProduto_Enter);
            this.txtQuantidadeProduto.Leave += new System.EventHandler(this.txtQuantidadeProduto_Leave);
            // 
            // lblAddProduct
            // 
            this.lblAddProduct.AutoSize = true;
            this.lblAddProduct.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblAddProduct.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblAddProduct.Location = new System.Drawing.Point(12, 385);
            this.lblAddProduct.Name = "lblAddProduct";
            this.lblAddProduct.Size = new System.Drawing.Size(154, 21);
            this.lblAddProduct.TabIndex = 8;
            this.lblAddProduct.Text = "Adicionar Produto:";
            // 
            // FormGerenciarProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblAddProduct);
            this.Controls.Add(this.txtQuantidadeProduto);
            this.Controls.Add(this.txtPrecoProduto);
            this.Controls.Add(this.txtNomeProduto);
            this.Controls.Add(this.btnAdicionarProduto);
            this.Controls.Add(this.btnAtualizarLista);
            this.Controls.Add(this.btnExcluirProduto);
            this.Controls.Add(this.btnEditarProduto);
            this.Controls.Add(this.dataGridViewProdutos);
            this.Name = "FormGerenciarProdutos";
            this.Text = "Gerenciar Produtos";
            this.Load += new System.EventHandler(this.FormGerenciarProdutos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProdutos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAddProduct;
    }
}
