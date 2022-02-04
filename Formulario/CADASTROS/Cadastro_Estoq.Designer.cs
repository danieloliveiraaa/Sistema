namespace Formulario
{
    partial class Cadastro_Estoq
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
            System.Windows.Forms.Label preco_VendaLabel;
            System.Windows.Forms.Label fornecedorLabel;
            System.Windows.Forms.Label quantidadeLabel;
            System.Windows.Forms.Label tipoLabel;
            System.Windows.Forms.Label nomeLabel;
            System.Windows.Forms.Label códigoLabel;
            this.btnEnviar = new System.Windows.Forms.Button();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.txtFornecedor = new System.Windows.Forms.TextBox();
            this.txtQuant = new System.Windows.Forms.TextBox();
            this.txtTipo = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.grpEstoque = new System.Windows.Forms.GroupBox();
            this.id1 = new System.Windows.Forms.Label();
            this.pctId_Erro = new System.Windows.Forms.PictureBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            preco_VendaLabel = new System.Windows.Forms.Label();
            fornecedorLabel = new System.Windows.Forms.Label();
            quantidadeLabel = new System.Windows.Forms.Label();
            tipoLabel = new System.Windows.Forms.Label();
            nomeLabel = new System.Windows.Forms.Label();
            códigoLabel = new System.Windows.Forms.Label();
            this.grpEstoque.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctId_Erro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // preco_VendaLabel
            // 
            preco_VendaLabel.AutoSize = true;
            preco_VendaLabel.BackColor = System.Drawing.Color.Transparent;
            preco_VendaLabel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            preco_VendaLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            preco_VendaLabel.Location = new System.Drawing.Point(428, 240);
            preco_VendaLabel.Name = "preco_VendaLabel";
            preco_VendaLabel.Size = new System.Drawing.Size(46, 16);
            preco_VendaLabel.TabIndex = 62;
            preco_VendaLabel.Text = "Preço:";
            // 
            // fornecedorLabel
            // 
            fornecedorLabel.AutoSize = true;
            fornecedorLabel.BackColor = System.Drawing.Color.Transparent;
            fornecedorLabel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            fornecedorLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            fornecedorLabel.Location = new System.Drawing.Point(392, 147);
            fornecedorLabel.Name = "fornecedorLabel";
            fornecedorLabel.Size = new System.Drawing.Size(77, 16);
            fornecedorLabel.TabIndex = 59;
            fornecedorLabel.Text = "Fornecedor:";
            // 
            // quantidadeLabel
            // 
            quantidadeLabel.AutoSize = true;
            quantidadeLabel.BackColor = System.Drawing.Color.Transparent;
            quantidadeLabel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            quantidadeLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            quantidadeLabel.Location = new System.Drawing.Point(41, 239);
            quantidadeLabel.Name = "quantidadeLabel";
            quantidadeLabel.Size = new System.Drawing.Size(78, 16);
            quantidadeLabel.TabIndex = 57;
            quantidadeLabel.Text = "Quantidade:";
            // 
            // tipoLabel
            // 
            tipoLabel.AutoSize = true;
            tipoLabel.BackColor = System.Drawing.Color.Transparent;
            tipoLabel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tipoLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            tipoLabel.Location = new System.Drawing.Point(434, 63);
            tipoLabel.Name = "tipoLabel";
            tipoLabel.Size = new System.Drawing.Size(37, 16);
            tipoLabel.TabIndex = 55;
            tipoLabel.Text = "Tipo:";
            // 
            // nomeLabel
            // 
            nomeLabel.AutoSize = true;
            nomeLabel.BackColor = System.Drawing.Color.Transparent;
            nomeLabel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nomeLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            nomeLabel.Location = new System.Drawing.Point(61, 147);
            nomeLabel.Name = "nomeLabel";
            nomeLabel.Size = new System.Drawing.Size(57, 16);
            nomeLabel.TabIndex = 53;
            nomeLabel.Text = "Produto:";
            // 
            // códigoLabel
            // 
            códigoLabel.AutoSize = true;
            códigoLabel.BackColor = System.Drawing.Color.Transparent;
            códigoLabel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            códigoLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            códigoLabel.Location = new System.Drawing.Point(73, 65);
            códigoLabel.Name = "códigoLabel";
            códigoLabel.Size = new System.Drawing.Size(52, 16);
            códigoLabel.TabIndex = 52;
            códigoLabel.Text = "Código:";
            // 
            // btnEnviar
            // 
            this.btnEnviar.BackgroundImage = global::Formulario.Properties.Resources.salve_;
            this.btnEnviar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEnviar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnviar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEnviar.Location = new System.Drawing.Point(127, 385);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(122, 107);
            this.btnEnviar.TabIndex = 2;
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // txtPreco
            // 
            this.txtPreco.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPreco.Location = new System.Drawing.Point(483, 235);
            this.txtPreco.MaxLength = 10;
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(190, 26);
            this.txtPreco.TabIndex = 63;
            // 
            // txtFornecedor
            // 
            this.txtFornecedor.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFornecedor.Location = new System.Drawing.Point(483, 142);
            this.txtFornecedor.MaxLength = 50;
            this.txtFornecedor.Name = "txtFornecedor";
            this.txtFornecedor.Size = new System.Drawing.Size(190, 26);
            this.txtFornecedor.TabIndex = 61;
            // 
            // txtQuant
            // 
            this.txtQuant.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuant.Location = new System.Drawing.Point(129, 235);
            this.txtQuant.MaxLength = 5;
            this.txtQuant.Name = "txtQuant";
            this.txtQuant.Size = new System.Drawing.Size(162, 26);
            this.txtQuant.TabIndex = 60;
            // 
            // txtTipo
            // 
            this.txtTipo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTipo.Location = new System.Drawing.Point(483, 59);
            this.txtTipo.MaxLength = 50;
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.Size = new System.Drawing.Size(190, 26);
            this.txtTipo.TabIndex = 58;
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(129, 142);
            this.txtNome.MaxLength = 50;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(162, 26);
            this.txtNome.TabIndex = 56;
            // 
            // txtId
            // 
            this.txtId.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(129, 59);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(50, 26);
            this.txtId.TabIndex = 54;
            this.txtId.TextChanged += new System.EventHandler(this.txtId_TextChanged);
            // 
            // grpEstoque
            // 
            this.grpEstoque.BackColor = System.Drawing.Color.LightPink;
            this.grpEstoque.Controls.Add(this.label2);
            this.grpEstoque.Controls.Add(this.label1);
            this.grpEstoque.Controls.Add(this.id1);
            this.grpEstoque.Controls.Add(this.pctId_Erro);
            this.grpEstoque.Controls.Add(this.btnLimpar);
            this.grpEstoque.Controls.Add(this.btnEnviar);
            this.grpEstoque.Controls.Add(this.txtFornecedor);
            this.grpEstoque.Controls.Add(this.txtId);
            this.grpEstoque.Controls.Add(códigoLabel);
            this.grpEstoque.Controls.Add(preco_VendaLabel);
            this.grpEstoque.Controls.Add(this.txtNome);
            this.grpEstoque.Controls.Add(this.txtPreco);
            this.grpEstoque.Controls.Add(nomeLabel);
            this.grpEstoque.Controls.Add(fornecedorLabel);
            this.grpEstoque.Controls.Add(this.txtTipo);
            this.grpEstoque.Controls.Add(tipoLabel);
            this.grpEstoque.Controls.Add(quantidadeLabel);
            this.grpEstoque.Controls.Add(this.txtQuant);
            this.grpEstoque.Font = new System.Drawing.Font("Arial Narrow", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpEstoque.Location = new System.Drawing.Point(132, 23);
            this.grpEstoque.Name = "grpEstoque";
            this.grpEstoque.Size = new System.Drawing.Size(851, 514);
            this.grpEstoque.TabIndex = 67;
            this.grpEstoque.TabStop = false;
            this.grpEstoque.Text = "CADASTRO DE ESTOQUE";
            // 
            // id1
            // 
            this.id1.AutoSize = true;
            this.id1.BackColor = System.Drawing.Color.Transparent;
            this.id1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.id1.Location = new System.Drawing.Point(124, 38);
            this.id1.Name = "id1";
            this.id1.Size = new System.Drawing.Size(85, 14);
            this.id1.TabIndex = 66;
            this.id1.Text = "Este ID já existe!";
            this.id1.Visible = false;
            // 
            // pctId_Erro
            // 
            this.pctId_Erro.BackColor = System.Drawing.Color.Transparent;
            this.pctId_Erro.BackgroundImage = global::Formulario.Properties.Resources.erro1;
            this.pctId_Erro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pctId_Erro.Image = global::Formulario.Properties.Resources.erro;
            this.pctId_Erro.Location = new System.Drawing.Point(194, 57);
            this.pctId_Erro.Name = "pctId_Erro";
            this.pctId_Erro.Size = new System.Drawing.Size(27, 29);
            this.pctId_Erro.TabIndex = 65;
            this.pctId_Erro.TabStop = false;
            this.pctId_Erro.Visible = false;
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackgroundImage = global::Formulario.Properties.Resources.borracha;
            this.btnLimpar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnLimpar.Location = new System.Drawing.Point(551, 385);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(122, 107);
            this.btnLimpar.TabIndex = 64;
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::Formulario.Properties.Resources.estoque;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(9, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(99, 509);
            this.pictureBox1.TabIndex = 69;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(165, 363);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 14);
            this.label1.TabIndex = 67;
            this.label1.Text = "Gravar";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(595, 363);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 14);
            this.label2.TabIndex = 68;
            this.label2.Text = "Limpar";
            this.label2.Visible = false;
            // 
            // Cadastro_Estoq
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(998, 558);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.grpEstoque);
            this.Name = "Cadastro_Estoq";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.grpEstoque.ResumeLayout(false);
            this.grpEstoque.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctId_Erro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.TextBox txtFornecedor;
        private System.Windows.Forms.TextBox txtQuant;
        private System.Windows.Forms.TextBox txtTipo;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.GroupBox grpEstoque;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label id1;
        private System.Windows.Forms.PictureBox pctId_Erro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}