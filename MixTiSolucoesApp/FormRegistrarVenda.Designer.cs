namespace MixTiSolucoesApp
{
    partial class FormRegistrarVenda
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmbProduto = new System.Windows.Forms.ComboBox();
            this.txtQuantidadeVendida = new System.Windows.Forms.TextBox();
            this.btnFinalizarVenda = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // cmbProduto
            this.cmbProduto.FormattingEnabled = true;
            this.cmbProduto.Location = new System.Drawing.Point(12, 12);
            this.cmbProduto.Name = "cmbProduto";
            this.cmbProduto.Size = new System.Drawing.Size(200, 21);
            this.cmbProduto.TabIndex = 0;

            // txtQuantidadeVendida
            this.txtQuantidadeVendida.Location = new System.Drawing.Point(12, 50);
            this.txtQuantidadeVendida.Name = "txtQuantidadeVendida";
            this.txtQuantidadeVendida.Size = new System.Drawing.Size(100, 20);
            this.txtQuantidadeVendida.TabIndex = 1;

            // btnFinalizarVenda
            this.btnFinalizarVenda.Location = new System.Drawing.Point(12, 90);
            this.btnFinalizarVenda.Name = "btnFinalizarVenda";
            this.btnFinalizarVenda.Size = new System.Drawing.Size(100, 23);
            this.btnFinalizarVenda.TabIndex = 2;
            this.btnFinalizarVenda.Text = "Finalizar Venda";
            this.btnFinalizarVenda.UseVisualStyleBackColor = true;
            this.btnFinalizarVenda.Click += new System.EventHandler(this.btnFinalizarVenda_Click);

            // FormRegistrarVenda
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.cmbProduto);
            this.Controls.Add(this.txtQuantidadeVendida);
            this.Controls.Add(this.btnFinalizarVenda);
            this.Name = "FormRegistrarVenda";
            this.Text = "Registrar Venda";
            this.Load += new System.EventHandler(this.FormRegistrarVenda_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ComboBox cmbProduto;
        private System.Windows.Forms.TextBox txtQuantidadeVendida;
        private System.Windows.Forms.Button btnFinalizarVenda;
    }
}