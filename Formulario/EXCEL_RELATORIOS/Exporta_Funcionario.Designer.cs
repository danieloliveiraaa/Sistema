
namespace Formulario.EXCEL_RELATORIOS
{
    partial class Exporta_Funcionario
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Exporta_Funcionario));
            this.lblStatus = new System.Windows.Forms.Label();
            this.pgsBar = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRG = new System.Windows.Forms.TextBox();
            this.txtCPF = new System.Windows.Forms.TextBox();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.txtEmpresa = new System.Windows.Forms.TextBox();
            this.cboCargo = new System.Windows.Forms.ComboBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblRG = new System.Windows.Forms.Label();
            this.lblCPF = new System.Windows.Forms.Label();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.lblEmpresa = new System.Windows.Forms.Label();
            this.lblCargo = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.btnExportarExcel = new System.Windows.Forms.Button();
            this.grpExcel_Func = new System.Windows.Forms.GroupBox();
            this.id1 = new System.Windows.Forms.Label();
            this.pctId = new System.Windows.Forms.PictureBox();
            this.lteste = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnSair = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.grpExcel_Func.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(400, 333);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(20, 17);
            this.lblStatus.TabIndex = 92;
            this.lblStatus.Text = "...";
            this.lblStatus.Visible = false;
            // 
            // pgsBar
            // 
            this.pgsBar.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.pgsBar.Cursor = System.Windows.Forms.Cursors.Default;
            this.pgsBar.Enabled = false;
            this.pgsBar.Location = new System.Drawing.Point(395, 362);
            this.pgsBar.MarqueeAnimationSpeed = 50;
            this.pgsBar.Name = "pgsBar";
            this.pgsBar.Size = new System.Drawing.Size(439, 37);
            this.pgsBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pgsBar.TabIndex = 91;
            this.pgsBar.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(127, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 24);
            this.label1.TabIndex = 86;
            this.label1.Text = "FUNCIONARIO";
            // 
            // txtRG
            // 
            this.txtRG.BackColor = System.Drawing.Color.White;
            this.txtRG.Enabled = false;
            this.txtRG.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRG.Location = new System.Drawing.Point(395, 139);
            this.txtRG.Name = "txtRG";
            this.txtRG.Size = new System.Drawing.Size(199, 22);
            this.txtRG.TabIndex = 84;
            // 
            // txtCPF
            // 
            this.txtCPF.BackColor = System.Drawing.Color.White;
            this.txtCPF.Enabled = false;
            this.txtCPF.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCPF.Location = new System.Drawing.Point(98, 140);
            this.txtCPF.MaxLength = 11;
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(182, 22);
            this.txtCPF.TabIndex = 83;
            // 
            // txtEndereco
            // 
            this.txtEndereco.BackColor = System.Drawing.Color.White;
            this.txtEndereco.Enabled = false;
            this.txtEndereco.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEndereco.Location = new System.Drawing.Point(739, 214);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(190, 22);
            this.txtEndereco.TabIndex = 82;
            // 
            // txtTelefone
            // 
            this.txtTelefone.BackColor = System.Drawing.Color.White;
            this.txtTelefone.Enabled = false;
            this.txtTelefone.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefone.Location = new System.Drawing.Point(739, 140);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(190, 22);
            this.txtTelefone.TabIndex = 81;
            // 
            // txtEmpresa
            // 
            this.txtEmpresa.BackColor = System.Drawing.Color.White;
            this.txtEmpresa.Enabled = false;
            this.txtEmpresa.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmpresa.Location = new System.Drawing.Point(98, 214);
            this.txtEmpresa.Name = "txtEmpresa";
            this.txtEmpresa.Size = new System.Drawing.Size(182, 22);
            this.txtEmpresa.TabIndex = 80;
            // 
            // cboCargo
            // 
            this.cboCargo.BackColor = System.Drawing.Color.White;
            this.cboCargo.Enabled = false;
            this.cboCargo.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCargo.FormattingEnabled = true;
            this.cboCargo.Items.AddRange(new object[] {
            "Estagiário",
            "Gerente de assistente técnico",
            "Assistente chefe",
            "Auxiliar executivo",
            "Engenheiro elétrico",
            "Analista de web",
            "Arquiteto de sistemas",
            "Assistente de comunicação",
            "Blogueiro",
            "DBA Oracle",
            "DBA SQL",
            "Gerente de segurança da informação ",
            "Instalador de acessórios",
            "Oficial de manutenção",
            "Operador de auidovisual",
            "Operador de áudio",
            "Operador de logistica",
            "Operador de redes",
            "Operador de máquinas",
            "Professor de conhecimento gerais"});
            this.cboCargo.Location = new System.Drawing.Point(395, 212);
            this.cboCargo.Name = "cboCargo";
            this.cboCargo.Size = new System.Drawing.Size(199, 24);
            this.cboCargo.TabIndex = 79;
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.White;
            this.txtEmail.Enabled = false;
            this.txtEmail.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(739, 64);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(190, 22);
            this.txtEmail.TabIndex = 78;
            // 
            // txtNome
            // 
            this.txtNome.BackColor = System.Drawing.Color.White;
            this.txtNome.Enabled = false;
            this.txtNome.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(395, 62);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(199, 22);
            this.txtNome.TabIndex = 77;
            // 
            // txtId
            // 
            this.txtId.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(98, 62);
            this.txtId.MaxLength = 3;
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(47, 22);
            this.txtId.TabIndex = 76;
            this.txtId.TextChanged += new System.EventHandler(this.txtCodigo_TextChanged);
            // 
            // lblRG
            // 
            this.lblRG.AutoSize = true;
            this.lblRG.BackColor = System.Drawing.Color.Transparent;
            this.lblRG.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblRG.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRG.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblRG.Location = new System.Drawing.Point(346, 140);
            this.lblRG.Name = "lblRG";
            this.lblRG.Size = new System.Drawing.Size(34, 17);
            this.lblRG.TabIndex = 75;
            this.lblRG.Text = "RG:";
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.BackColor = System.Drawing.Color.Transparent;
            this.lblCPF.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblCPF.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPF.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblCPF.Location = new System.Drawing.Point(33, 142);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(42, 17);
            this.lblCPF.TabIndex = 74;
            this.lblCPF.Text = "CPF:";
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.BackColor = System.Drawing.Color.Transparent;
            this.lblEndereco.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblEndereco.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndereco.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblEndereco.Location = new System.Drawing.Point(659, 214);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(75, 17);
            this.lblEndereco.TabIndex = 73;
            this.lblEndereco.Text = "Endereço:";
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.BackColor = System.Drawing.Color.Transparent;
            this.lblTelefone.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblTelefone.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefone.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTelefone.Location = new System.Drawing.Point(666, 141);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(66, 17);
            this.lblTelefone.TabIndex = 72;
            this.lblTelefone.Text = "Telefone:";
            // 
            // lblEmpresa
            // 
            this.lblEmpresa.AutoSize = true;
            this.lblEmpresa.BackColor = System.Drawing.Color.Transparent;
            this.lblEmpresa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblEmpresa.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpresa.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblEmpresa.Location = new System.Drawing.Point(20, 215);
            this.lblEmpresa.Name = "lblEmpresa";
            this.lblEmpresa.Size = new System.Drawing.Size(72, 17);
            this.lblEmpresa.TabIndex = 71;
            this.lblEmpresa.Text = "Empresa:";
            // 
            // lblCargo
            // 
            this.lblCargo.AutoSize = true;
            this.lblCargo.BackColor = System.Drawing.Color.Transparent;
            this.lblCargo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblCargo.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCargo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblCargo.Location = new System.Drawing.Point(339, 214);
            this.lblCargo.Name = "lblCargo";
            this.lblCargo.Size = new System.Drawing.Size(52, 17);
            this.lblCargo.TabIndex = 70;
            this.lblCargo.Text = "Cargo:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.BackColor = System.Drawing.Color.Transparent;
            this.lblEmail.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblEmail.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblEmail.Location = new System.Drawing.Point(671, 64);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(49, 17);
            this.lblEmail.TabIndex = 69;
            this.lblEmail.Text = "Email:";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.BackColor = System.Drawing.Color.Transparent;
            this.lblNome.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblNome.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblNome.Location = new System.Drawing.Point(340, 63);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(51, 17);
            this.lblNome.TabIndex = 68;
            this.lblNome.Text = "Nome:";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.BackColor = System.Drawing.Color.Transparent;
            this.lblCodigo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblCodigo.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblCodigo.Location = new System.Drawing.Point(28, 64);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(58, 17);
            this.lblCodigo.TabIndex = 67;
            this.lblCodigo.Text = "Código:";
            // 
            // btnExportarExcel
            // 
            this.btnExportarExcel.BackColor = System.Drawing.Color.DarkGreen;
            this.btnExportarExcel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExportarExcel.BackgroundImage")));
            this.btnExportarExcel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExportarExcel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExportarExcel.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnExportarExcel.Location = new System.Drawing.Point(98, 310);
            this.btnExportarExcel.Name = "btnExportarExcel";
            this.btnExportarExcel.Size = new System.Drawing.Size(95, 89);
            this.btnExportarExcel.TabIndex = 87;
            this.btnExportarExcel.UseVisualStyleBackColor = false;
            this.btnExportarExcel.Click += new System.EventHandler(this.btnExportarExcel_Click);
            // 
            // grpExcel_Func
            // 
            this.grpExcel_Func.BackColor = System.Drawing.Color.SeaGreen;
            this.grpExcel_Func.Controls.Add(this.id1);
            this.grpExcel_Func.Controls.Add(this.pctId);
            this.grpExcel_Func.Controls.Add(this.txtRG);
            this.grpExcel_Func.Controls.Add(this.lblCodigo);
            this.grpExcel_Func.Controls.Add(this.lblStatus);
            this.grpExcel_Func.Controls.Add(this.lblNome);
            this.grpExcel_Func.Controls.Add(this.pgsBar);
            this.grpExcel_Func.Controls.Add(this.lblEmail);
            this.grpExcel_Func.Controls.Add(this.lblCargo);
            this.grpExcel_Func.Controls.Add(this.btnExportarExcel);
            this.grpExcel_Func.Controls.Add(this.lblEmpresa);
            this.grpExcel_Func.Controls.Add(this.lblTelefone);
            this.grpExcel_Func.Controls.Add(this.lblEndereco);
            this.grpExcel_Func.Controls.Add(this.lblCPF);
            this.grpExcel_Func.Controls.Add(this.lblRG);
            this.grpExcel_Func.Controls.Add(this.txtCPF);
            this.grpExcel_Func.Controls.Add(this.txtId);
            this.grpExcel_Func.Controls.Add(this.txtEndereco);
            this.grpExcel_Func.Controls.Add(this.txtNome);
            this.grpExcel_Func.Controls.Add(this.txtTelefone);
            this.grpExcel_Func.Controls.Add(this.txtEmail);
            this.grpExcel_Func.Controls.Add(this.txtEmpresa);
            this.grpExcel_Func.Controls.Add(this.cboCargo);
            this.grpExcel_Func.Font = new System.Drawing.Font("Arial Narrow", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpExcel_Func.Location = new System.Drawing.Point(108, 58);
            this.grpExcel_Func.Name = "grpExcel_Func";
            this.grpExcel_Func.Size = new System.Drawing.Size(988, 426);
            this.grpExcel_Func.TabIndex = 93;
            this.grpExcel_Func.TabStop = false;
            // 
            // id1
            // 
            this.id1.AutoSize = true;
            this.id1.BackColor = System.Drawing.Color.Transparent;
            this.id1.Font = new System.Drawing.Font("Arial Narrow", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.id1.Location = new System.Drawing.Point(184, 64);
            this.id1.Name = "id1";
            this.id1.Size = new System.Drawing.Size(84, 16);
            this.id1.TabIndex = 89;
            this.id1.Text = "Não existente!";
            this.id1.Visible = false;
            // 
            // pctId
            // 
            this.pctId.BackColor = System.Drawing.Color.Transparent;
            this.pctId.BackgroundImage = global::Formulario.Properties.Resources.erro1;
            this.pctId.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pctId.Image = global::Formulario.Properties.Resources.erro;
            this.pctId.Location = new System.Drawing.Point(154, 59);
            this.pctId.Name = "pctId";
            this.pctId.Size = new System.Drawing.Size(24, 26);
            this.pctId.TabIndex = 88;
            this.pctId.TabStop = false;
            this.pctId.Visible = false;
            // 
            // lteste
            // 
            this.lteste.AutoSize = true;
            this.lteste.BackColor = System.Drawing.Color.Transparent;
            this.lteste.Font = new System.Drawing.Font("Arial Narrow", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lteste.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lteste.Location = new System.Drawing.Point(313, 481);
            this.lteste.Name = "lteste";
            this.lteste.Size = new System.Drawing.Size(0, 16);
            this.lteste.TabIndex = 90;
            this.lteste.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.Transparent;
            this.btnSair.BackgroundImage = global::Formulario.Properties.Resources.pagina_inicial;
            this.btnSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSair.Location = new System.Drawing.Point(7, 6);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(85, 37);
            this.btnSair.TabIndex = 94;
            this.btnSair.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::Formulario.Properties.Resources.funcionarios;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(7, 58);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(85, 426);
            this.pictureBox1.TabIndex = 95;
            this.pictureBox1.TabStop = false;
            // 
            // Exporta_Funcionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ClientSize = new System.Drawing.Size(1125, 506);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.lteste);
            this.Controls.Add(this.grpExcel_Func);
            this.Controls.Add(this.label1);
            this.Name = "Exporta_Funcionario";
            this.Text = "Exporta_Funcionario";
            this.grpExcel_Func.ResumeLayout(false);
            this.grpExcel_Func.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ProgressBar pgsBar;
        private System.Windows.Forms.Button btnExportarExcel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRG;
        private System.Windows.Forms.TextBox txtCPF;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.TextBox txtEmpresa;
        private System.Windows.Forms.ComboBox cboCargo;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblRG;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.Label lblEndereco;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.Label lblEmpresa;
        private System.Windows.Forms.Label lblCargo;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.GroupBox grpExcel_Func;
        private System.Windows.Forms.Label id1;
        private System.Windows.Forms.PictureBox pctId;
        private System.Windows.Forms.Label lteste;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}