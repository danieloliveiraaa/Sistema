using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Formulario
{
    public partial class USUARIO_NOVO : Form
    {
        public USUARIO_NOVO()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            LOGIN home = new LOGIN();
            this.Close();
            home.Show();
        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-9BS0DO1\SQLEXPRESS;Initial Catalog=Software;User ID=sa;Password=28052018");

            //conta os id existentes
            string id = "SELECT COUNT (*) AS CONT_ID FROM login_usuario WHERE id_usuario = '" + txtId.Text + "';";

            SqlCommand cmd_id = new SqlCommand(id, cn);

            cn.Open();

            //LÊ O COUNT ID
            SqlDataReader read_id = cmd_id.ExecuteReader();


            if (read_id.Read())
            {
                lbid.Text = read_id["CONT_ID"].ToString();

                if (lbid.Text != "0")
                {
                    pctId.Visible = true;

                    pctId.BackgroundImage = Properties.Resources.erro1;

                    txtId.BackColor = Color.LightCoral;

                    id1.Visible = true;


                }

                else if (lbid.Text == "")
                {
                    pctId.Visible = false;

                    //pctId_Erro.BackgroundImage = Properties.Resources.esta_bem;

                    txtId.BackColor = Color.White;

                    id1.Visible = false;


                }

                else if (txtId.Text == "")
                {
                    pctId.Visible = false;

                    txtId.BackColor = Color.White;

                    id1.Visible = false;



                }

                else
                {
                    pctId.Visible = true;

                    txtId.BackColor = Color.LightGreen;
                    pctId.BackgroundImage = Properties.Resources.esta_bem;

                    id1.Visible = false;


                }
            }

            else
            {


            }

            cn.Close();
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-9BS0DO1\SQLEXPRESS;Initial Catalog=Software;User ID=sa;Password=28052018");

            //conta os id existentes
            string id = "SELECT COUNT (*) AS CONT_EMAIL FROM login_usuario WHERE email_usuario = '" + txtEmail.Text + "';";

            SqlCommand cmd_email = new SqlCommand(id, cn);

            cn.Open();

            //LÊ O COUNT ID
            SqlDataReader read_email = cmd_email.ExecuteReader();


            if (read_email.Read())
            {
                lbemail.Text = read_email["CONT_EMAIL"].ToString();

                if (lbemail.Text != "0")
                {
                    pctEmail.Visible = true;

                    pctEmail.BackgroundImage = Properties.Resources.erro1;

                    txtEmail.BackColor = Color.LightCoral;

                    email1.Visible = true;


                }

                else if (lbemail.Text == "")
                {
                    pctEmail.Visible = false;

                    //pctId_Erro.BackgroundImage = Properties.Resources.esta_bem;

                    txtEmail.BackColor = Color.White;

                    email1.Visible = false;


                }

                else if (txtEmail.Text == "")
                {
                    pctEmail.Visible = false;

                    txtEmail.BackColor = Color.White;

                    email1.Visible = false;



                }

                else
                {
                    pctEmail.Visible = true;

                    txtEmail.BackColor = Color.LightGreen;

                    pctEmail.BackgroundImage = Properties.Resources.esta_bem;

                    email1.Visible = false;


                }
            }
            else
            {

            }

            cn.Close();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-9BS0DO1\SQLEXPRESS;Initial Catalog=Software;User ID=sa;Password=28052018");

            string sql = "INSERT INTO login_usuario (nome_usuario, email_usuario, id_usuario, senha_usuario) VALUES(@nome_usuario, @email_usuario, @id_usuario, @senha_usuario)";


            try
            {
                if ((txtId.Text == "") | (txtNome.Text == "") | (txtSenha.Text == "") | (txtEmail.Text == ""))
                {
                    MessageBox.Show("HÁ CAMPOS EM BRANCO, POR FAVOR VERIFIQUE !", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                //VERIFICA SE TODOS OS CAMPOS SAO VAZIOS.
                else if ((txtId.Text == "") & (txtNome.Text == "") & (txtSenha.Text == "") & (txtEmail.Text == ""))
                {
                    MessageBox.Show("NÃO FOI POSSIVEL REALIZAR O CADASTRO,\nPOIS TODOS OS CAMPOS ESTÃO EM BRANCO. \nPOR FAVOR VERIFIQUE.", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                else if ((txtId.BackColor == Color.LightCoral) | (txtEmail.BackColor == Color.LightCoral))
                {
                    MessageBox.Show("OS CAMPOS EM VERMELHO, JÁ CONSTAM NO SISTEMA ! \nNÃO PODEM SER DUPLICADOS !", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                else
                {
                    SqlCommand cmd = new SqlCommand(sql, cn);
                    cmd.Parameters.Add(new SqlParameter("@id_usuario", this.txtId.Text));
                    cmd.Parameters.Add(new SqlParameter("@nome_usuario", this.txtNome.Text));
                    cmd.Parameters.Add(new SqlParameter("@email_usuario", this.txtEmail.Text));
                    cmd.Parameters.Add(new SqlParameter("@senha_usuario", this.txtSenha.Text));


                    //Abre a conexão com o banco de dados
                    cn.Open();

                    //Executa o comando sql
                    cmd.ExecuteNonQuery();


                    //LIMPA OS CAMPOS, APÓS REGISTRAR
                    txtId.Text = "";
                    txtNome.Text = "";
                    txtSenha.Text = "";
                    txtEmail.Text = "";


                    //Mensagem de sucesso para o usuário
                    MessageBox.Show("USUÁRIO CADASTRADO !", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);


                }




            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Alerta de Erro" + ex.Number, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                cn.Close();
            }
        }
    }
}
