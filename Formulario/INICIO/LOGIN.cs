using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Formulario
{
    public partial class LOGIN : Form
    {
        public LOGIN()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            bool resultado = false;

            SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-9BS0DO1\SQLEXPRESS;Initial Catalog=Software;User ID=sa;Password=28052018");

            try
            {

                string sql = "select * from login_usuario where id_usuario = '" + txtId.Text + "' and senha_usuario = '" + txtSenha.Text + "';";
                SqlCommand cmd = new SqlCommand(sql, cn);

                cn.Open();
                SqlDataReader Senhas = cmd.ExecuteReader();

                

                resultado = Senhas.HasRows;



            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Alerta" + ex.Number, MessageBoxButtons.OKCancel, MessageBoxIcon.Error);

            }
            finally
            {
                cn.Close();
            }
            if (resultado)
            {
                this.Hide();
                btnSair tela = new btnSair();
                tela.Show();
                MessageBox.Show("Seja Bem Vindo " + lblNome.Text);


            }
            else
            {
                MessageBox.Show("USUÁRIO OU SENHA INVÁLIDOS");
            }
        }


        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.Enter:
                    btnEntrar.Select();
                    break;

                case Keys.Escape:
                    Close();
                    break;

                case Keys.Control | Keys.L:
                    txtId.Text = "";
                    txtSenha.Text = "";
                    break;

                case Keys.F1:
                    txtId.Text = "sa";
                    txtSenha.Text = "28052018";
                    break;
            }


            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            EsqueceSenha esquece = new EsqueceSenha();
            this.Hide();
            esquece.Show();
        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {

            //Conexao com banco
            SqlConnection cn1 = new SqlConnection(@"Data Source=DESKTOP-9BS0DO1\SQLEXPRESS;Initial Catalog=Software;User ID=sa;Password=28052018");

            //CONDIÇÃO A SER BUSCADA NO BANCO
            string sql_nome = "select nome_usuario from login_usuario where id_usuario = '" + txtId.Text + "';";

            //EXECUTA OS COMANDOS SQL
            SqlCommand cmd1 = new SqlCommand(sql_nome, cn1);

            //ABRE A CONEXAO
            cn1.Open();

            //LEITURA DOS DADOS
            SqlDataReader Nome = cmd1.ExecuteReader();

            if (Nome.Read())
            {
                lblNome.Text = Nome["nome_usuario"].ToString();
                pctImage.Load("C:/Users/Daniels/Pictures/Saved Pictures/software dan.jpg");


            }
            else
            {
                lblNome.Text = "LOGIN";
                pctImage.Image = default;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCadastro_Usu_Click(object sender, EventArgs e)
        {
            USUARIO_NOVO U = new USUARIO_NOVO();
            this.Hide();
            U.Show();
        }

        private void Revela_MouseEnter(object sender, EventArgs e)
        {
            txtSenha.PasswordChar = default;
            Revela.BackgroundImage = Properties.Resources.olho_meio_aberto;
        }

        private void Revela_MouseLeave(object sender, EventArgs e)
        {
            txtSenha.PasswordChar = '*';
            Revela.BackgroundImage = Properties.Resources.cilios;
        }
    }

}

