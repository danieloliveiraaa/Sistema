
namespace Formulario
{
    partial class EsqueceSenha
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EsqueceSenha));
            this.gpgControle = new System.Windows.Forms.GroupBox();
            this.mail1 = new System.Windows.Forms.Label();
            this.pctEmail_Erro = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblDica = new System.Windows.Forms.Label();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.lblAqui = new System.Windows.Forms.Label();
            this.btnEnviarNova = new System.Windows.Forms.Button();
            this.lblVerifique = new System.Windows.Forms.Label();
            this.txtExibeSenha = new System.Windows.Forms.TextBox();
            this.txtExibeId = new System.Windows.Forms.TextBox();
            this.timer_progress = new System.Windows.Forms.Timer(this.components);
            this.btnClose = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.lbmail = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtExibeNome = new System.Windows.Forms.TextBox();
            this.gpgControle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctEmail_Erro)).BeginInit();
            this.SuspendLayout();
            // 
            // gpgControle
            // 
            this.gpgControle.BackColor = System.Drawing.Color.LightPink;
            this.gpgControle.Controls.Add(this.label2);
            this.gpgControle.Controls.Add(this.mail1);
            this.gpgControle.Controls.Add(this.pctEmail_Erro);
            this.gpgControle.Controls.Add(this.txtEmail);
            this.gpgControle.Controls.Add(this.lblDica);
            this.gpgControle.Controls.Add(this.btnEnviar);
            this.gpgControle.Location = new System.Drawing.Point(76, 109);
            this.gpgControle.Name = "gpgControle";
            this.gpgControle.Size = new System.Drawing.Size(518, 294);
            this.gpgControle.TabIndex = 65;
            this.gpgControle.TabStop = false;
            this.gpgControle.Text = "Controle";
            // 
            // mail1
            // 
            this.mail1.AutoSize = true;
            this.mail1.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mail1.Location = new System.Drawing.Point(92, 95);
            this.mail1.Name = "mail1";
            this.mail1.Size = new System.Drawing.Size(134, 15);
            this.mail1.TabIndex = 68;
            this.mail1.Text = "Este email não é válido !";
            this.mail1.Visible = false;
            // 
            // pctEmail_Erro
            // 
            this.pctEmail_Erro.BackColor = System.Drawing.Color.Transparent;
            this.pctEmail_Erro.BackgroundImage = global::Formulario.Properties.Resources.erro1;
            this.pctEmail_Erro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pctEmail_Erro.Image = global::Formulario.Properties.Resources.erro;
            this.pctEmail_Erro.Location = new System.Drawing.Point(397, 120);
            this.pctEmail_Erro.Name = "pctEmail_Erro";
            this.pctEmail_Erro.Size = new System.Drawing.Size(30, 29);
            this.pctEmail_Erro.TabIndex = 68;
            this.pctEmail_Erro.TabStop = false;
            this.pctEmail_Erro.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(171, 410);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(330, 18);
            this.label1.TabIndex = 53;
            this.label1.Text = "Enviaremos um codigo para redefinição de sua senha!";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(89, 120);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(298, 29);
            this.txtEmail.TabIndex = 46;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            // 
            // lblDica
            // 
            this.lblDica.AutoSize = true;
            this.lblDica.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDica.Location = new System.Drawing.Point(84, 28);
            this.lblDica.Name = "lblDica";
            this.lblDica.Size = new System.Drawing.Size(376, 25);
            this.lblDica.TabIndex = 52;
            this.lblDica.Text = "Digite o email vinculado a sua conta:";
            // 
            // btnEnviar
            // 
            this.btnEnviar.BackColor = System.Drawing.Color.Transparent;
            this.btnEnviar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEnviar.BackgroundImage")));
            this.btnEnviar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEnviar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEnviar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEnviar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnviar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnEnviar.Location = new System.Drawing.Point(210, 200);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(98, 58);
            this.btnEnviar.TabIndex = 49;
            this.btnEnviar.UseVisualStyleBackColor = false;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSair.Location = new System.Drawing.Point(-160, -28);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(51, 38);
            this.btnSair.TabIndex = 64;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            // 
            // lblAqui
            // 
            this.lblAqui.AutoSize = true;
            this.lblAqui.BackColor = System.Drawing.Color.SeaGreen;
            this.lblAqui.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAqui.Location = new System.Drawing.Point(175, 202);
            this.lblAqui.Name = "lblAqui";
            this.lblAqui.Size = new System.Drawing.Size(349, 24);
            this.lblAqui.TabIndex = 63;
            this.lblAqui.Text = "Se nao recebeu o email, clique aqui";
            this.lblAqui.Visible = false;
            // 
            // btnEnviarNova
            // 
            this.btnEnviarNova.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.btnEnviarNova.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEnviarNova.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEnviarNova.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnviarNova.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnEnviarNova.Location = new System.Drawing.Point(254, 255);
            this.btnEnviarNova.Name = "btnEnviarNova";
            this.btnEnviarNova.Size = new System.Drawing.Size(171, 60);
            this.btnEnviarNova.TabIndex = 62;
            this.btnEnviarNova.Text = "Enviar Novamente";
            this.btnEnviarNova.UseVisualStyleBackColor = false;
            this.btnEnviarNova.Visible = false;
            this.btnEnviarNova.Click += new System.EventHandler(this.btnEnviarNova_Click);
            // 
            // lblVerifique
            // 
            this.lblVerifique.AutoSize = true;
            this.lblVerifique.BackColor = System.Drawing.Color.SeaGreen;
            this.lblVerifique.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVerifique.Location = new System.Drawing.Point(114, 162);
            this.lblVerifique.Name = "lblVerifique";
            this.lblVerifique.Size = new System.Drawing.Size(439, 25);
            this.lblVerifique.TabIndex = 61;
            this.lblVerifique.Text = "VERIFIQUE SUA CAIXA DE ENTRADA !! ";
            this.lblVerifique.Visible = false;
            // 
            // txtExibeSenha
            // 
            this.txtExibeSenha.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExibeSenha.Location = new System.Drawing.Point(11, 531);
            this.txtExibeSenha.Name = "txtExibeSenha";
            this.txtExibeSenha.Size = new System.Drawing.Size(24, 29);
            this.txtExibeSenha.TabIndex = 54;
            this.txtExibeSenha.Visible = false;
            // 
            // txtExibeId
            // 
            this.txtExibeId.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExibeId.Location = new System.Drawing.Point(11, 520);
            this.txtExibeId.Name = "txtExibeId";
            this.txtExibeId.Size = new System.Drawing.Size(24, 29);
            this.txtExibeId.TabIndex = 54;
            this.txtExibeId.Visible = false;
            // 
            // timer_progress
            // 
            this.timer_progress.Interval = 500;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClose.BackgroundImage")));
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnClose.Location = new System.Drawing.Point(611, 6);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(40, 38);
            this.btnClose.TabIndex = 67;
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
            this.btnHome.Location = new System.Drawing.Point(11, 6);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(51, 38);
            this.btnHome.TabIndex = 66;
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // lbmail
            // 
            this.lbmail.AutoSize = true;
            this.lbmail.Font = new System.Drawing.Font("Corbel", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbmail.Location = new System.Drawing.Point(625, 551);
            this.lbmail.Name = "lbmail";
            this.lbmail.Size = new System.Drawing.Size(26, 13);
            this.lbmail.TabIndex = 54;
            this.lbmail.Text = "nulo";
            this.lbmail.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(235, 265);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 18);
            this.label2.TabIndex = 68;
            this.label2.Text = "Enviar";
            // 
            // txtExibeNome
            // 
            this.txtExibeNome.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExibeNome.Location = new System.Drawing.Point(11, 509);
            this.txtExibeNome.Name = "txtExibeNome";
            this.txtExibeNome.Size = new System.Drawing.Size(24, 29);
            this.txtExibeNome.TabIndex = 68;
            this.txtExibeNome.Visible = false;
            // 
            // EsqueceSenha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.ClientSize = new System.Drawing.Size(663, 573);
            this.Controls.Add(this.txtExibeNome);
            this.Controls.Add(this.lbmail);
            this.Controls.Add(this.txtExibeId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtExibeSenha);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.gpgControle);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.lblAqui);
            this.Controls.Add(this.btnEnviarNova);
            this.Controls.Add(this.lblVerifique);
            this.Name = "EsqueceSenha";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EsqueceSenha";
            this.gpgControle.ResumeLayout(false);
            this.gpgControle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctEmail_Erro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.GroupBox gpgControle;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblDica;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label lblAqui;
        private System.Windows.Forms.Button btnEnviarNova;
        private System.Windows.Forms.Label lblVerifique;
        
        
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtExibeSenha;
        private System.Windows.Forms.TextBox txtExibeId;
        private System.Windows.Forms.Timer timer_progress;
        private System.Windows.Forms.Label lbmail;
        private System.Windows.Forms.Label mail1;
        private System.Windows.Forms.PictureBox pctEmail_Erro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtExibeNome;
    }
}