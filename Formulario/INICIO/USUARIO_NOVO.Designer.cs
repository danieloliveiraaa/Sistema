
namespace Formulario
{
    partial class USUARIO_NOVO
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
            this.grpUsu = new System.Windows.Forms.GroupBox();
            this.email1 = new System.Windows.Forms.Label();
            this.pctEmail = new System.Windows.Forms.PictureBox();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.id1 = new System.Windows.Forms.Label();
            this.pctId = new System.Windows.Forms.PictureBox();
            this.mail1 = new System.Windows.Forms.Label();
            this.pctEmail_Erro = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lbid = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.lbemail = new System.Windows.Forms.Label();
            this.grpUsu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctEmail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctEmail_Erro)).BeginInit();
            this.SuspendLayout();
            // 
            // grpUsu
            // 
            this.grpUsu.BackColor = System.Drawing.Color.LightPink;
            this.grpUsu.Controls.Add(this.email1);
            this.grpUsu.Controls.Add(this.pctEmail);
            this.grpUsu.Controls.Add(this.btnEnviar);
            this.grpUsu.Controls.Add(this.id1);
            this.grpUsu.Controls.Add(this.pctId);
            this.grpUsu.Controls.Add(this.mail1);
            this.grpUsu.Controls.Add(this.pctEmail_Erro);
            this.grpUsu.Controls.Add(this.label4);
            this.grpUsu.Controls.Add(this.txtSenha);
            this.grpUsu.Controls.Add(this.label3);
            this.grpUsu.Controls.Add(this.txtNome);
            this.grpUsu.Controls.Add(this.label1);
            this.grpUsu.Controls.Add(this.txtId);
            this.grpUsu.Controls.Add(this.label2);
            this.grpUsu.Controls.Add(this.txtEmail);
            this.grpUsu.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpUsu.Location = new System.Drawing.Point(29, 100);
            this.grpUsu.Name = "grpUsu";
            this.grpUsu.Size = new System.Drawing.Size(737, 327);
            this.grpUsu.TabIndex = 71;
            this.grpUsu.TabStop = false;
            this.grpUsu.Text = "NOVO USUÁRIO";
            // 
            // email1
            // 
            this.email1.AutoSize = true;
            this.email1.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email1.Location = new System.Drawing.Point(632, 67);
            this.email1.Name = "email1";
            this.email1.Size = new System.Drawing.Size(79, 15);
            this.email1.TabIndex = 74;
            this.email1.Text = "Email em uso!";
            this.email1.Visible = false;
            // 
            // pctEmail
            // 
            this.pctEmail.BackColor = System.Drawing.Color.Transparent;
            this.pctEmail.BackgroundImage = global::Formulario.Properties.Resources.erro1;
            this.pctEmail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pctEmail.Image = global::Formulario.Properties.Resources.erro;
            this.pctEmail.Location = new System.Drawing.Point(598, 62);
            this.pctEmail.Name = "pctEmail";
            this.pctEmail.Size = new System.Drawing.Size(27, 26);
            this.pctEmail.TabIndex = 75;
            this.pctEmail.TabStop = false;
            this.pctEmail.Visible = false;
            // 
            // btnEnviar
            // 
            this.btnEnviar.BackColor = System.Drawing.Color.Transparent;
            this.btnEnviar.BackgroundImage = global::Formulario.Properties.Resources._1212;
            this.btnEnviar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEnviar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEnviar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEnviar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnviar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnEnviar.Location = new System.Drawing.Point(274, 255);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(110, 64);
            this.btnEnviar.TabIndex = 72;
            this.btnEnviar.UseVisualStyleBackColor = false;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // id1
            // 
            this.id1.AutoSize = true;
            this.id1.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id1.Location = new System.Drawing.Point(186, 67);
            this.id1.Name = "id1";
            this.id1.Size = new System.Drawing.Size(77, 15);
            this.id1.TabIndex = 72;
            this.id1.Text = "Login em uso!";
            this.id1.Visible = false;
            // 
            // pctId
            // 
            this.pctId.BackColor = System.Drawing.Color.Transparent;
            this.pctId.BackgroundImage = global::Formulario.Properties.Resources.erro1;
            this.pctId.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pctId.Image = global::Formulario.Properties.Resources.erro;
            this.pctId.Location = new System.Drawing.Point(152, 62);
            this.pctId.Name = "pctId";
            this.pctId.Size = new System.Drawing.Size(27, 26);
            this.pctId.TabIndex = 73;
            this.pctId.TabStop = false;
            this.pctId.Visible = false;
            // 
            // mail1
            // 
            this.mail1.AutoSize = true;
            this.mail1.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mail1.Location = new System.Drawing.Point(169, -82);
            this.mail1.Name = "mail1";
            this.mail1.Size = new System.Drawing.Size(134, 15);
            this.mail1.TabIndex = 70;
            this.mail1.Text = "Este email não é válido !";
            this.mail1.Visible = false;
            // 
            // pctEmail_Erro
            // 
            this.pctEmail_Erro.BackColor = System.Drawing.Color.Transparent;
            this.pctEmail_Erro.BackgroundImage = global::Formulario.Properties.Resources.erro1;
            this.pctEmail_Erro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pctEmail_Erro.Image = global::Formulario.Properties.Resources.erro;
            this.pctEmail_Erro.Location = new System.Drawing.Point(313, -60);
            this.pctEmail_Erro.Name = "pctEmail_Erro";
            this.pctEmail_Erro.Size = new System.Drawing.Size(30, 29);
            this.pctEmail_Erro.TabIndex = 71;
            this.pctEmail_Erro.TabStop = false;
            this.pctEmail_Erro.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(354, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Senha:";
            // 
            // txtSenha
            // 
            this.txtSenha.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.Location = new System.Drawing.Point(350, 147);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(168, 26);
            this.txtSenha.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(49, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Login:";
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(45, 147);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(230, 26);
            this.txtNome.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome:";
            // 
            // txtId
            // 
            this.txtId.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(45, 62);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(96, 26);
            this.txtId.TabIndex = 4;
            this.txtId.TextChanged += new System.EventHandler(this.txtId_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(354, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Email:";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(350, 62);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(237, 26);
            this.txtEmail.TabIndex = 2;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            // 
            // lbid
            // 
            this.lbid.AutoSize = true;
            this.lbid.Font = new System.Drawing.Font("Corbel", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbid.Location = new System.Drawing.Point(26, 508);
            this.lbid.Name = "lbid";
            this.lbid.Size = new System.Drawing.Size(90, 13);
            this.lbid.TabIndex = 69;
            this.lbid.Text = "ARMAZENA QT ID";
            this.lbid.Visible = false;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.BackgroundImage = global::Formulario.Properties.Resources.sair;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnClose.Location = new System.Drawing.Point(723, 8);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(61, 38);
            this.btnClose.TabIndex = 69;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.Transparent;
            this.btnHome.BackgroundImage = global::Formulario.Properties.Resources.pagina_inicial;
            this.btnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnHome.Location = new System.Drawing.Point(10, 9);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(52, 38);
            this.btnHome.TabIndex = 68;
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // lbemail
            // 
            this.lbemail.AutoSize = true;
            this.lbemail.Font = new System.Drawing.Font("Corbel", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbemail.Location = new System.Drawing.Point(26, 539);
            this.lbemail.Name = "lbemail";
            this.lbemail.Size = new System.Drawing.Size(116, 13);
            this.lbemail.TabIndex = 72;
            this.lbemail.Text = "ARMAZENA QT EMAILS";
            this.lbemail.Visible = false;
            // 
            // USUARIO_NOVO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.ClientSize = new System.Drawing.Size(795, 491);
            this.Controls.Add(this.lbemail);
            this.Controls.Add(this.grpUsu);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lbid);
            this.Controls.Add(this.btnHome);
            this.Name = "USUARIO_NOVO";
            this.Text = "USUARIO_NOVO";
            this.grpUsu.ResumeLayout(false);
            this.grpUsu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctEmail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctEmail_Erro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.GroupBox grpUsu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lbid;
        private System.Windows.Forms.Label mail1;
        private System.Windows.Forms.PictureBox pctEmail_Erro;
        private System.Windows.Forms.Label id1;
        private System.Windows.Forms.PictureBox pctId;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.Label lbemail;
        private System.Windows.Forms.Label email1;
        private System.Windows.Forms.PictureBox pctEmail;
    }
}