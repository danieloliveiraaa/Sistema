namespace Formulario
{
    partial class AlterarCliente
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
            this.txtId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.txtRg = new System.Windows.Forms.TextBox();
            this.txtEnd = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtCpf = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblWhats = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblRg = new System.Windows.Forms.Label();
            this.lblCpf = new System.Windows.Forms.Label();
            this.lblEnd = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.cpf1 = new System.Windows.Forms.Label();
            this.pctCpf = new System.Windows.Forms.PictureBox();
            this.rg1 = new System.Windows.Forms.Label();
            this.pctRg = new System.Windows.Forms.PictureBox();
            this.lbEditar = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.id1 = new System.Windows.Forms.Label();
            this.pctId_Erro = new System.Windows.Forms.PictureBox();
            this.btnAltera = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctCpf)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctRg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctId_Erro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtId
            // 
            this.txtId.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(85, 64);
            this.txtId.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtId.MaxLength = 3;
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(82, 25);
            this.txtId.TabIndex = 48;
            this.txtId.TextChanged += new System.EventHandler(this.txtId_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(56, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 15);
            this.label1.TabIndex = 47;
            this.label1.Text = "ID:";
            // 
            // txtTelefone
            // 
            this.txtTelefone.Enabled = false;
            this.txtTelefone.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefone.Location = new System.Drawing.Point(86, 256);
            this.txtTelefone.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTelefone.MaxLength = 10;
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(216, 25);
            this.txtTelefone.TabIndex = 62;
            // 
            // txtRg
            // 
            this.txtRg.Enabled = false;
            this.txtRg.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRg.Location = new System.Drawing.Point(403, 193);
            this.txtRg.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtRg.MaxLength = 9;
            this.txtRg.Name = "txtRg";
            this.txtRg.Size = new System.Drawing.Size(216, 25);
            this.txtRg.TabIndex = 61;
            this.txtRg.TextChanged += new System.EventHandler(this.txtRg_TextChanged);
            // 
            // txtEnd
            // 
            this.txtEnd.Enabled = false;
            this.txtEnd.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEnd.Location = new System.Drawing.Point(403, 128);
            this.txtEnd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEnd.MaxLength = 100;
            this.txtEnd.Name = "txtEnd";
            this.txtEnd.Size = new System.Drawing.Size(216, 25);
            this.txtEnd.TabIndex = 60;
            // 
            // txtEmail
            // 
            this.txtEmail.Enabled = false;
            this.txtEmail.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(86, 193);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEmail.MaxLength = 100;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(216, 25);
            this.txtEmail.TabIndex = 59;
            // 
            // txtCpf
            // 
            this.txtCpf.Enabled = false;
            this.txtCpf.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCpf.Location = new System.Drawing.Point(403, 256);
            this.txtCpf.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCpf.MaxLength = 11;
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(216, 25);
            this.txtCpf.TabIndex = 58;
            this.txtCpf.TextChanged += new System.EventHandler(this.txtCpf_TextChanged);
            // 
            // txtNome
            // 
            this.txtNome.Enabled = false;
            this.txtNome.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(86, 128);
            this.txtNome.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNome.MaxLength = 50;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(216, 25);
            this.txtNome.TabIndex = 57;
            // 
            // lblWhats
            // 
            this.lblWhats.AutoSize = true;
            this.lblWhats.BackColor = System.Drawing.Color.Transparent;
            this.lblWhats.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWhats.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblWhats.Location = new System.Drawing.Point(18, 260);
            this.lblWhats.Name = "lblWhats";
            this.lblWhats.Size = new System.Drawing.Size(57, 15);
            this.lblWhats.TabIndex = 56;
            this.lblWhats.Text = "Telefone:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.BackColor = System.Drawing.Color.Transparent;
            this.lblEmail.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblEmail.Location = new System.Drawing.Point(34, 197);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(46, 15);
            this.lblEmail.TabIndex = 55;
            this.lblEmail.Text = "E-mail:";
            // 
            // lblRg
            // 
            this.lblRg.AutoSize = true;
            this.lblRg.BackColor = System.Drawing.Color.Transparent;
            this.lblRg.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRg.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblRg.Location = new System.Drawing.Point(368, 198);
            this.lblRg.Name = "lblRg";
            this.lblRg.Size = new System.Drawing.Size(28, 15);
            this.lblRg.TabIndex = 54;
            this.lblRg.Text = "RG:";
            // 
            // lblCpf
            // 
            this.lblCpf.AutoSize = true;
            this.lblCpf.BackColor = System.Drawing.Color.Transparent;
            this.lblCpf.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCpf.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblCpf.Location = new System.Drawing.Point(359, 261);
            this.lblCpf.Name = "lblCpf";
            this.lblCpf.Size = new System.Drawing.Size(34, 15);
            this.lblCpf.TabIndex = 53;
            this.lblCpf.Text = "CPF:";
            // 
            // lblEnd
            // 
            this.lblEnd.AutoSize = true;
            this.lblEnd.BackColor = System.Drawing.Color.Transparent;
            this.lblEnd.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnd.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblEnd.Location = new System.Drawing.Point(336, 133);
            this.lblEnd.Name = "lblEnd";
            this.lblEnd.Size = new System.Drawing.Size(63, 15);
            this.lblEnd.TabIndex = 52;
            this.lblEnd.Text = "Endereço:";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.BackColor = System.Drawing.Color.Transparent;
            this.lblNome.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblNome.Location = new System.Drawing.Point(35, 133);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(44, 15);
            this.lblNome.TabIndex = 51;
            this.lblNome.Text = "Nome:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Pink;
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btnCancelar);
            this.groupBox1.Controls.Add(this.cpf1);
            this.groupBox1.Controls.Add(this.pctCpf);
            this.groupBox1.Controls.Add(this.rg1);
            this.groupBox1.Controls.Add(this.pctRg);
            this.groupBox1.Controls.Add(this.lbEditar);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.id1);
            this.groupBox1.Controls.Add(this.pctId_Erro);
            this.groupBox1.Controls.Add(this.txtRg);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtId);
            this.groupBox1.Controls.Add(this.btnAltera);
            this.groupBox1.Controls.Add(this.btnSalvar);
            this.groupBox1.Controls.Add(this.lblNome);
            this.groupBox1.Controls.Add(this.txtTelefone);
            this.groupBox1.Controls.Add(this.lblEnd);
            this.groupBox1.Controls.Add(this.lblCpf);
            this.groupBox1.Controls.Add(this.txtEnd);
            this.groupBox1.Controls.Add(this.lblRg);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.lblEmail);
            this.groupBox1.Controls.Add(this.txtCpf);
            this.groupBox1.Controls.Add(this.lblWhats);
            this.groupBox1.Controls.Add(this.txtNome);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Arial Narrow", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(116, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(724, 462);
            this.groupBox1.TabIndex = 65;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "EDITAR CLIENTE";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(550, 348);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 14);
            this.label5.TabIndex = 73;
            this.label5.Text = "Descartar";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackgroundImage = global::Formulario.Properties.Resources.excluir;
            this.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCancelar.Enabled = false;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelar.Location = new System.Drawing.Point(536, 367);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(84, 68);
            this.btnCancelar.TabIndex = 72;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // cpf1
            // 
            this.cpf1.AutoSize = true;
            this.cpf1.BackColor = System.Drawing.Color.Transparent;
            this.cpf1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpf1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cpf1.Location = new System.Drawing.Point(406, 237);
            this.cpf1.Name = "cpf1";
            this.cpf1.Size = new System.Drawing.Size(67, 14);
            this.cpf1.TabIndex = 71;
            this.cpf1.Text = "Já existente!";
            this.cpf1.Visible = false;
            // 
            // pctCpf
            // 
            this.pctCpf.BackColor = System.Drawing.Color.Transparent;
            this.pctCpf.BackgroundImage = global::Formulario.Properties.Resources.erro1;
            this.pctCpf.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pctCpf.Image = global::Formulario.Properties.Resources.erro;
            this.pctCpf.Location = new System.Drawing.Point(625, 256);
            this.pctCpf.Name = "pctCpf";
            this.pctCpf.Size = new System.Drawing.Size(24, 25);
            this.pctCpf.TabIndex = 70;
            this.pctCpf.TabStop = false;
            this.pctCpf.Visible = false;
            // 
            // rg1
            // 
            this.rg1.AutoSize = true;
            this.rg1.BackColor = System.Drawing.Color.Transparent;
            this.rg1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rg1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rg1.Location = new System.Drawing.Point(406, 174);
            this.rg1.Name = "rg1";
            this.rg1.Size = new System.Drawing.Size(70, 14);
            this.rg1.TabIndex = 69;
            this.rg1.Text = "Já existente! ";
            this.rg1.Visible = false;
            // 
            // pctRg
            // 
            this.pctRg.BackColor = System.Drawing.Color.Transparent;
            this.pctRg.BackgroundImage = global::Formulario.Properties.Resources.erro1;
            this.pctRg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pctRg.Image = global::Formulario.Properties.Resources.erro;
            this.pctRg.Location = new System.Drawing.Point(625, 193);
            this.pctRg.Name = "pctRg";
            this.pctRg.Size = new System.Drawing.Size(24, 25);
            this.pctRg.TabIndex = 68;
            this.pctRg.TabStop = false;
            this.pctRg.Visible = false;
            // 
            // lbEditar
            // 
            this.lbEditar.AutoSize = true;
            this.lbEditar.BackColor = System.Drawing.Color.Transparent;
            this.lbEditar.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEditar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbEditar.Location = new System.Drawing.Point(105, 347);
            this.lbEditar.Name = "lbEditar";
            this.lbEditar.Size = new System.Drawing.Size(36, 14);
            this.lbEditar.TabIndex = 67;
            this.lbEditar.Text = "Editar";
            this.lbEditar.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(332, 348);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 14);
            this.label3.TabIndex = 66;
            this.label3.Text = "Salvar";
            // 
            // id1
            // 
            this.id1.AutoSize = true;
            this.id1.BackColor = System.Drawing.Color.Transparent;
            this.id1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.id1.Location = new System.Drawing.Point(205, 69);
            this.id1.Name = "id1";
            this.id1.Size = new System.Drawing.Size(75, 14);
            this.id1.TabIndex = 64;
            this.id1.Text = "Não existente!";
            this.id1.Visible = false;
            // 
            // pctId_Erro
            // 
            this.pctId_Erro.BackColor = System.Drawing.Color.Transparent;
            this.pctId_Erro.BackgroundImage = global::Formulario.Properties.Resources.erro1;
            this.pctId_Erro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pctId_Erro.Image = global::Formulario.Properties.Resources.erro;
            this.pctId_Erro.Location = new System.Drawing.Point(175, 63);
            this.pctId_Erro.Name = "pctId_Erro";
            this.pctId_Erro.Size = new System.Drawing.Size(24, 25);
            this.pctId_Erro.TabIndex = 63;
            this.pctId_Erro.TabStop = false;
            this.pctId_Erro.Visible = false;
            // 
            // btnAltera
            // 
            this.btnAltera.BackgroundImage = global::Formulario.Properties.Resources.lapis;
            this.btnAltera.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAltera.Enabled = false;
            this.btnAltera.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAltera.Location = new System.Drawing.Point(85, 367);
            this.btnAltera.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAltera.Name = "btnAltera";
            this.btnAltera.Size = new System.Drawing.Size(81, 68);
            this.btnAltera.TabIndex = 42;
            this.btnAltera.UseVisualStyleBackColor = true;
            this.btnAltera.Visible = false;
            this.btnAltera.Click += new System.EventHandler(this.btnAltera_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackgroundImage = global::Formulario.Properties.Resources.salve_;
            this.btnSalvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSalvar.Enabled = false;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSalvar.Location = new System.Drawing.Point(309, 367);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(84, 68);
            this.btnSalvar.TabIndex = 43;
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::Formulario.Properties.Resources.cliente;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(12, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(74, 457);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // AlterarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightPink;
            this.ClientSize = new System.Drawing.Size(852, 526);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "AlterarCliente";
            this.Text = "Alterar Cliente";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctCpf)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctRg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctId_Erro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnAltera;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.TextBox txtRg;
        private System.Windows.Forms.TextBox txtEnd;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtCpf;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblWhats;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblRg;
        private System.Windows.Forms.Label lblCpf;
        private System.Windows.Forms.Label lblEnd;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label id1;
        private System.Windows.Forms.PictureBox pctId_Erro;
        private System.Windows.Forms.Label lbEditar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label cpf1;
        private System.Windows.Forms.PictureBox pctCpf;
        private System.Windows.Forms.Label rg1;
        private System.Windows.Forms.PictureBox pctRg;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCancelar;
    }
}