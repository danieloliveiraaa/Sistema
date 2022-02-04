namespace Formulario
{
    partial class LOGIN
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
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lkEsqueceSenha = new System.Windows.Forms.LinkLabel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Revela = new System.Windows.Forms.PictureBox();
            this.btnSair = new System.Windows.Forms.Button();
            this.pctImage = new System.Windows.Forms.PictureBox();
            this.btnCadastro_Usu = new System.Windows.Forms.Button();
            this.btnEntrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Revela)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctImage)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSenha
            // 
            this.txtSenha.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.Location = new System.Drawing.Point(160, 270);
            this.txtSenha.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(135, 29);
            this.txtSenha.TabIndex = 41;
            // 
            // txtId
            // 
            this.txtId.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(160, 193);
            this.txtId.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(135, 29);
            this.txtId.TabIndex = 40;
            this.txtId.TextChanged += new System.EventHandler(this.txtId_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(222, 40);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 18);
            this.label2.TabIndex = 44;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.BackColor = System.Drawing.Color.LightPink;
            this.lblNome.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(133, 15);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(48, 16);
            this.lblNome.TabIndex = 48;
            this.lblNome.Text = "LOGIN";
            // 
            // lkEsqueceSenha
            // 
            this.lkEsqueceSenha.AutoSize = true;
            this.lkEsqueceSenha.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lkEsqueceSenha.LinkColor = System.Drawing.Color.Black;
            this.lkEsqueceSenha.Location = new System.Drawing.Point(160, 309);
            this.lkEsqueceSenha.Name = "lkEsqueceSenha";
            this.lkEsqueceSenha.Size = new System.Drawing.Size(111, 16);
            this.lkEsqueceSenha.TabIndex = 50;
            this.lkEsqueceSenha.TabStop = true;
            this.lkEsqueceSenha.Text = "Esqueci Minha Senha";
            this.lkEsqueceSenha.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::Formulario.Properties.Resources.homem_usuario;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(113, 193);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(42, 29);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 71;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Formulario.Properties.Resources.senha;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(113, 270);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(42, 29);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 70;
            this.pictureBox1.TabStop = false;
            // 
            // Revela
            // 
            this.Revela.BackgroundImage = global::Formulario.Properties.Resources.cilios;
            this.Revela.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Revela.Location = new System.Drawing.Point(300, 270);
            this.Revela.Name = "Revela";
            this.Revela.Size = new System.Drawing.Size(41, 29);
            this.Revela.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Revela.TabIndex = 69;
            this.Revela.TabStop = false;
            this.Revela.MouseEnter += new System.EventHandler(this.Revela_MouseEnter);
            this.Revela.MouseLeave += new System.EventHandler(this.Revela_MouseLeave);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.Transparent;
            this.btnSair.BackgroundImage = global::Formulario.Properties.Resources.sair;
            this.btnSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSair.Location = new System.Drawing.Point(12, 425);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(60, 40);
            this.btnSair.TabIndex = 68;
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.button4_Click);
            // 
            // pctImage
            // 
            this.pctImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pctImage.Location = new System.Drawing.Point(12, 12);
            this.pctImage.Name = "pctImage";
            this.pctImage.Size = new System.Drawing.Size(104, 125);
            this.pctImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctImage.TabIndex = 51;
            this.pctImage.TabStop = false;
            // 
            // btnCadastro_Usu
            // 
            this.btnCadastro_Usu.BackColor = System.Drawing.Color.Transparent;
            this.btnCadastro_Usu.BackgroundImage = global::Formulario.Properties.Resources.adicionar_usuario;
            this.btnCadastro_Usu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCadastro_Usu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCadastro_Usu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastro_Usu.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCadastro_Usu.Location = new System.Drawing.Point(374, 425);
            this.btnCadastro_Usu.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnCadastro_Usu.Name = "btnCadastro_Usu";
            this.btnCadastro_Usu.Size = new System.Drawing.Size(60, 42);
            this.btnCadastro_Usu.TabIndex = 40;
            this.btnCadastro_Usu.UseVisualStyleBackColor = false;
            this.btnCadastro_Usu.Click += new System.EventHandler(this.btnCadastro_Usu_Click);
            // 
            // btnEntrar
            // 
            this.btnEntrar.BackColor = System.Drawing.Color.Transparent;
            this.btnEntrar.BackgroundImage = global::Formulario.Properties.Resources.enter;
            this.btnEntrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEntrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEntrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntrar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnEntrar.Location = new System.Drawing.Point(183, 390);
            this.btnEntrar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(79, 73);
            this.btnEntrar.TabIndex = 39;
            this.btnEntrar.UseVisualStyleBackColor = false;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // LOGIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(5F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(443, 498);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Revela);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.pctImage);
            this.Controls.Add(this.lkEsqueceSenha);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.btnCadastro_Usu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnEntrar);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtId);
            this.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "LOGIN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Revela)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Button btnEntrar;
        private System.Windows.Forms.Button btnCadastro_Usu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.LinkLabel lkEsqueceSenha;
        private System.Windows.Forms.PictureBox pctImage;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.PictureBox Revela;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}