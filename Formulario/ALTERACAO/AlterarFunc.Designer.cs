namespace Formulario
{
    partial class AlterarFunc
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCpf = new System.Windows.Forms.TextBox();
            this.txtRg = new System.Windows.Forms.TextBox();
            this.txtEmpresa = new System.Windows.Forms.TextBox();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cboCargo = new System.Windows.Forms.ComboBox();
            this.grpFuncio = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.btnCancela = new System.Windows.Forms.Button();
            this.lbEditar = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.cpf1 = new System.Windows.Forms.Label();
            this.pctCpf = new System.Windows.Forms.PictureBox();
            this.rg1 = new System.Windows.Forms.Label();
            this.pctRg = new System.Windows.Forms.PictureBox();
            this.id1 = new System.Windows.Forms.Label();
            this.pctId_Erro = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.grpFuncio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctCpf)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctRg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctId_Erro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtId
            // 
            this.txtId.Font = new System.Drawing.Font("Arial Narrow", 11.25F);
            this.txtId.Location = new System.Drawing.Point(93, 52);
            this.txtId.MaxLength = 3;
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(82, 25);
            this.txtId.TabIndex = 2;
            this.txtId.TextChanged += new System.EventHandler(this.txtId_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Italic);
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(33, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "CPF:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Italic);
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(372, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Endereço:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Italic);
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(407, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "RG:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Italic);
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(13, 253);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 16);
            this.label6.TabIndex = 7;
            this.label6.Text = "Empresa:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Italic);
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(28, 118);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 16);
            this.label7.TabIndex = 8;
            this.label7.Text = "Nome:";
            // 
            // txtCpf
            // 
            this.txtCpf.Enabled = false;
            this.txtCpf.Font = new System.Drawing.Font("Arial Narrow", 11.25F);
            this.txtCpf.Location = new System.Drawing.Point(93, 184);
            this.txtCpf.MaxLength = 11;
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(186, 25);
            this.txtCpf.TabIndex = 9;
            this.txtCpf.TextChanged += new System.EventHandler(this.txtCpf_TextChanged);
            // 
            // txtRg
            // 
            this.txtRg.Enabled = false;
            this.txtRg.Font = new System.Drawing.Font("Arial Narrow", 11.25F);
            this.txtRg.Location = new System.Drawing.Point(461, 184);
            this.txtRg.MaxLength = 9;
            this.txtRg.Name = "txtRg";
            this.txtRg.Size = new System.Drawing.Size(181, 25);
            this.txtRg.TabIndex = 10;
            this.txtRg.TextChanged += new System.EventHandler(this.txtRg_TextChanged);
            // 
            // txtEmpresa
            // 
            this.txtEmpresa.Enabled = false;
            this.txtEmpresa.Font = new System.Drawing.Font("Arial Narrow", 11.25F);
            this.txtEmpresa.Location = new System.Drawing.Point(93, 251);
            this.txtEmpresa.Name = "txtEmpresa";
            this.txtEmpresa.Size = new System.Drawing.Size(186, 25);
            this.txtEmpresa.TabIndex = 11;
            // 
            // txtEndereco
            // 
            this.txtEndereco.Enabled = false;
            this.txtEndereco.Font = new System.Drawing.Font("Arial Narrow", 11.25F);
            this.txtEndereco.Location = new System.Drawing.Point(461, 111);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(181, 25);
            this.txtEndereco.TabIndex = 12;
            // 
            // txtNome
            // 
            this.txtNome.Enabled = false;
            this.txtNome.Font = new System.Drawing.Font("Arial Narrow", 11.25F);
            this.txtNome.Location = new System.Drawing.Point(93, 115);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(235, 25);
            this.txtNome.TabIndex = 13;
            // 
            // txtEmail
            // 
            this.txtEmail.Enabled = false;
            this.txtEmail.Font = new System.Drawing.Font("Arial Narrow", 11.25F);
            this.txtEmail.Location = new System.Drawing.Point(461, 316);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(181, 25);
            this.txtEmail.TabIndex = 15;
            // 
            // txtTelefone
            // 
            this.txtTelefone.Enabled = false;
            this.txtTelefone.Font = new System.Drawing.Font("Arial Narrow", 11.25F);
            this.txtTelefone.Location = new System.Drawing.Point(461, 251);
            this.txtTelefone.MaxLength = 10;
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(181, 25);
            this.txtTelefone.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Italic);
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(399, 322);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 16);
            this.label8.TabIndex = 17;
            this.label8.Text = "Email:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Italic);
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(28, 321);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 16);
            this.label9.TabIndex = 18;
            this.label9.Text = "Cargo:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Italic);
            this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label10.Location = new System.Drawing.Point(386, 257);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 16);
            this.label10.TabIndex = 19;
            this.label10.Text = "Telefone:";
            // 
            // cboCargo
            // 
            this.cboCargo.Enabled = false;
            this.cboCargo.Font = new System.Drawing.Font("Arial Narrow", 11.25F);
            this.cboCargo.FormattingEnabled = true;
            this.cboCargo.Items.AddRange(new object[] {
            "Gerente",
            "Gerente Operacional",
            "Analista de Sistemas",
            "Desenvolvedor Java",
            "DBA",
            "Repositor",
            "Atendente",
            "Balconista",
            "Padeiro",
            "Açougueiro"});
            this.cboCargo.Location = new System.Drawing.Point(93, 318);
            this.cboCargo.Name = "cboCargo";
            this.cboCargo.Size = new System.Drawing.Size(186, 28);
            this.cboCargo.TabIndex = 20;
            // 
            // grpFuncio
            // 
            this.grpFuncio.Controls.Add(this.label14);
            this.grpFuncio.Controls.Add(this.btnCancela);
            this.grpFuncio.Controls.Add(this.lbEditar);
            this.grpFuncio.Controls.Add(this.label15);
            this.grpFuncio.Controls.Add(this.btnAlterar);
            this.grpFuncio.Controls.Add(this.btnSalvar);
            this.grpFuncio.Controls.Add(this.cpf1);
            this.grpFuncio.Controls.Add(this.pctCpf);
            this.grpFuncio.Controls.Add(this.rg1);
            this.grpFuncio.Controls.Add(this.pctRg);
            this.grpFuncio.Controls.Add(this.id1);
            this.grpFuncio.Controls.Add(this.pctId_Erro);
            this.grpFuncio.Controls.Add(this.label2);
            this.grpFuncio.Controls.Add(this.txtNome);
            this.grpFuncio.Controls.Add(this.label7);
            this.grpFuncio.Controls.Add(this.txtEndereco);
            this.grpFuncio.Controls.Add(this.label4);
            this.grpFuncio.Controls.Add(this.txtCpf);
            this.grpFuncio.Controls.Add(this.label3);
            this.grpFuncio.Controls.Add(this.txtRg);
            this.grpFuncio.Controls.Add(this.label5);
            this.grpFuncio.Controls.Add(this.txtId);
            this.grpFuncio.Controls.Add(this.label8);
            this.grpFuncio.Controls.Add(this.cboCargo);
            this.grpFuncio.Controls.Add(this.txtEmail);
            this.grpFuncio.Controls.Add(this.label9);
            this.grpFuncio.Controls.Add(this.txtEmpresa);
            this.grpFuncio.Controls.Add(this.label10);
            this.grpFuncio.Controls.Add(this.label6);
            this.grpFuncio.Controls.Add(this.txtTelefone);
            this.grpFuncio.Font = new System.Drawing.Font("Arial Narrow", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.grpFuncio.Location = new System.Drawing.Point(107, 24);
            this.grpFuncio.Name = "grpFuncio";
            this.grpFuncio.Size = new System.Drawing.Size(792, 523);
            this.grpFuncio.TabIndex = 27;
            this.grpFuncio.TabStop = false;
            this.grpFuncio.Text = "EDITAR FUNCIONARIO";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label14.Location = new System.Drawing.Point(551, 412);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(56, 14);
            this.label14.TabIndex = 79;
            this.label14.Text = "Descartar";
            // 
            // btnCancela
            // 
            this.btnCancela.BackgroundImage = global::Formulario.Properties.Resources.excluir;
            this.btnCancela.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCancela.Enabled = false;
            this.btnCancela.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancela.Location = new System.Drawing.Point(537, 431);
            this.btnCancela.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancela.Name = "btnCancela";
            this.btnCancela.Size = new System.Drawing.Size(84, 68);
            this.btnCancela.TabIndex = 78;
            this.btnCancela.UseVisualStyleBackColor = true;
            this.btnCancela.Click += new System.EventHandler(this.btnCancela_Click);
            // 
            // lbEditar
            // 
            this.lbEditar.AutoSize = true;
            this.lbEditar.BackColor = System.Drawing.Color.Transparent;
            this.lbEditar.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEditar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbEditar.Location = new System.Drawing.Point(106, 411);
            this.lbEditar.Name = "lbEditar";
            this.lbEditar.Size = new System.Drawing.Size(36, 14);
            this.lbEditar.TabIndex = 77;
            this.lbEditar.Text = "Editar";
            this.lbEditar.Visible = false;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label15.Location = new System.Drawing.Point(333, 412);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(38, 14);
            this.label15.TabIndex = 76;
            this.label15.Text = "Salvar";
            // 
            // btnAlterar
            // 
            this.btnAlterar.BackgroundImage = global::Formulario.Properties.Resources.lapis;
            this.btnAlterar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAlterar.Enabled = false;
            this.btnAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAlterar.Location = new System.Drawing.Point(86, 431);
            this.btnAlterar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(81, 68);
            this.btnAlterar.TabIndex = 74;
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Visible = false;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackgroundImage = global::Formulario.Properties.Resources.salve_;
            this.btnSalvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSalvar.Enabled = false;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSalvar.Location = new System.Drawing.Point(310, 431);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(84, 68);
            this.btnSalvar.TabIndex = 75;
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click_1);
            // 
            // cpf1
            // 
            this.cpf1.AutoSize = true;
            this.cpf1.BackColor = System.Drawing.Color.Transparent;
            this.cpf1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpf1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cpf1.Location = new System.Drawing.Point(96, 166);
            this.cpf1.Name = "cpf1";
            this.cpf1.Size = new System.Drawing.Size(75, 14);
            this.cpf1.TabIndex = 70;
            this.cpf1.Text = "Não existente!";
            this.cpf1.Visible = false;
            // 
            // pctCpf
            // 
            this.pctCpf.BackColor = System.Drawing.Color.Transparent;
            this.pctCpf.BackgroundImage = global::Formulario.Properties.Resources.erro1;
            this.pctCpf.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pctCpf.Image = global::Formulario.Properties.Resources.erro;
            this.pctCpf.Location = new System.Drawing.Point(286, 184);
            this.pctCpf.Name = "pctCpf";
            this.pctCpf.Size = new System.Drawing.Size(24, 25);
            this.pctCpf.TabIndex = 69;
            this.pctCpf.TabStop = false;
            this.pctCpf.Visible = false;
            // 
            // rg1
            // 
            this.rg1.AutoSize = true;
            this.rg1.BackColor = System.Drawing.Color.Transparent;
            this.rg1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rg1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rg1.Location = new System.Drawing.Point(463, 166);
            this.rg1.Name = "rg1";
            this.rg1.Size = new System.Drawing.Size(75, 14);
            this.rg1.TabIndex = 68;
            this.rg1.Text = "Não existente!";
            this.rg1.Visible = false;
            // 
            // pctRg
            // 
            this.pctRg.BackColor = System.Drawing.Color.Transparent;
            this.pctRg.BackgroundImage = global::Formulario.Properties.Resources.erro1;
            this.pctRg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pctRg.Image = global::Formulario.Properties.Resources.erro;
            this.pctRg.Location = new System.Drawing.Point(649, 184);
            this.pctRg.Name = "pctRg";
            this.pctRg.Size = new System.Drawing.Size(24, 25);
            this.pctRg.TabIndex = 67;
            this.pctRg.TabStop = false;
            this.pctRg.Visible = false;
            // 
            // id1
            // 
            this.id1.AutoSize = true;
            this.id1.BackColor = System.Drawing.Color.Transparent;
            this.id1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.id1.Location = new System.Drawing.Point(225, 58);
            this.id1.Name = "id1";
            this.id1.Size = new System.Drawing.Size(75, 14);
            this.id1.TabIndex = 66;
            this.id1.Text = "Não existente!";
            this.id1.Visible = false;
            // 
            // pctId_Erro
            // 
            this.pctId_Erro.BackColor = System.Drawing.Color.Transparent;
            this.pctId_Erro.BackgroundImage = global::Formulario.Properties.Resources.erro1;
            this.pctId_Erro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pctId_Erro.Image = global::Formulario.Properties.Resources.erro;
            this.pctId_Erro.Location = new System.Drawing.Point(195, 52);
            this.pctId_Erro.Name = "pctId_Erro";
            this.pctId_Erro.Size = new System.Drawing.Size(24, 25);
            this.pctId_Erro.TabIndex = 65;
            this.pctId_Erro.TabStop = false;
            this.pctId_Erro.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Italic);
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(51, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 16);
            this.label2.TabIndex = 21;
            this.label2.Text = "ID:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::Formulario.Properties.Resources.funcionarios;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(12, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(74, 523);
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // AlterarFunc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightPink;
            this.ClientSize = new System.Drawing.Size(932, 575);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.grpFuncio);
            this.Name = "AlterarFunc";
            this.Text = "Editar Funcionario";
            this.grpFuncio.ResumeLayout(false);
            this.grpFuncio.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctCpf)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctRg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctId_Erro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCpf;
        private System.Windows.Forms.TextBox txtRg;
        private System.Windows.Forms.TextBox txtEmpresa;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cboCargo;
        private System.Windows.Forms.GroupBox grpFuncio;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label id1;
        private System.Windows.Forms.PictureBox pctId_Erro;
        private System.Windows.Forms.Label cpf1;
        private System.Windows.Forms.PictureBox pctCpf;
        private System.Windows.Forms.Label rg1;
        private System.Windows.Forms.PictureBox pctRg;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnCancela;
        private System.Windows.Forms.Label lbEditar;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnSalvar;
    }
}