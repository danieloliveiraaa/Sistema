using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Net.Mail;
using System.Windows.Forms;


namespace Formulario
{
    public partial class EsqueceSenha : Form
    {
        public EsqueceSenha()
        {
            InitializeComponent();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {

            // Conexão com o banco de dados
            SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-9BS0DO1\SQLEXPRESS;Initial Catalog=Software;User ID=sa;Password=28052018");

            //String para buscar no banco de dados, na tabela LoginCliente, no campo Email que corresponda ao email digitado na caixa txtEmail
            string sql = "SELECT * FROM login_usuario WHERE email_usuario = '" + txtEmail.Text + "';";


            //Comando SQL para executar a Conexão com o banco de dados(cn) e executar a String SQL acima (sql)
            SqlCommand cmd = new SqlCommand(sql, cn);

            try
            {
                //abre o banco de dados
                cn.Open();

                //executa a função de ler os dados do banco, e jogar os valores para as 
                //caixas de texto(txtExibeEmail e txtExibeSenha), de acordo com o email que foi digitado na txtEmail.
                SqlDataReader Buscar = cmd.ExecuteReader();

                if (Buscar.Read())
                {
                    txtExibeId.Text = Buscar["id_usuario"].ToString();
                    txtExibeSenha.Text = Buscar["senha_usuario"].ToString();
                    txtExibeNome.Text = Buscar["nome_usuario"].ToString();

                }
                else
                {
                    MessageBox.Show("EMAIL INVÁLIDO !", "Alerta", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Alerta" + ex.Number, MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }

            finally
            {
                cn.Close();
            }




            //CODIGO QUE SERÁ ENVIADO POR EMAIL PARA REDEFINIÇÃO

            /////////////////////////////////////////////////////////////////////////////////
            

            Random aleatorio = new Random();
            string codigo = Convert.ToString(aleatorio.Next());


            /////////////////////////////////////////////////////////////////////////////////



            System.Net.Mail.SmtpClient client = new System.Net.Mail.SmtpClient();

            //Host seria no caso o tipo do email a ser usado, por exemplo Gmail,Outlook e Yahoo.
            client.Host = "smtp-mail.outlook.com";

            client.EnableSsl = true;

            client.Port = 587;


            //Abre o Outlook,Gmail e etc, com email e senha.
            client.Credentials = new System.Net.NetworkCredential("danisilvi.oli@hotmail.com", "danielonet321");

            

            //Instância para criação da mensagem.
            MailMessage mail = new MailMessage();

            //Email que será o remetente.
            mail.From = new MailAddress("danisilvi.oli@hotmail.com");

            //Email destinatario que será, o email inserido na caixa de texto.

            mail.To.Add(new MailAddress(txtEmail.Text));

            //Titulo do email.
            mail.Subject = "-- CODIGO ALTERAÇÃO DE SENHA --";

            /*
            //A mensagem que será enviada.

            mail.Body = (txtExibeNome.Text + "\nOlá, Tudo Bem?" +
            "\nAqui estão suas crendênciais de LOGIN:" + "\n\nSeu Login: " + txtExibeId.Text + "\nSenha: " + txtExibeSenha.Text);
            */

            //A mensagem que será enviada.
            mail.Body = ("Olá "+ txtExibeNome.Text +
            "\nSEGUE ABAIXO SEU CODIGO DE RECUPERAÇÃO:" + codigo);


            mail.Priority = MailPriority.High;


            try
            {
                //Realiza o envio.
                client.Send(mail);
                MessageBox.Show("EMAIL ENVIADO PARA SUA CAIXA DE ENTRADA!!");

                btnEnviar.Visible = false;
                lblDica.Visible = false;
                txtEmail.Visible = false;
                gpgControle.Visible = false;

                btnEnviarNova.Visible = true;
                lblAqui.Visible = true;
                lblVerifique.Visible = true;

            }
            catch (System.Exception)
            {
                //trata erro.
            }
            finally
            {
                //Após a operação o email, retorna como nulo.
                mail = null;
            }





        }

        private void btnEnviarNova_Click(object sender, EventArgs e)
        {
            System.Net.Mail.SmtpClient client = new System.Net.Mail.SmtpClient();
            client.Host = "smtp-mail.outlook.com";

            client.EnableSsl = true;

            client.Port = 587;

            client.Credentials = new System.Net.NetworkCredential("danisilvi.oli@hotmail.com", "danielonet321");


            MailMessage mail = new MailMessage();


            mail.From = new MailAddress("danisilvi.oli@hotmail.com");


            mail.To.Add(new MailAddress(txtEmail.Text));


            mail.Subject = "<-- CREDÊNCIAIS PARA ACESSO AO SOFTWARE -->";

            mail.Body = (txtExibeNome.Text + "\nOlá, Tudo bem? \nSoubemos que você nao recebeu nosso email  , lhe enviamos novamente!!" +
            "\nAqui estão suas crendênciais de login:" + "\nSeu Login: " + txtExibeId.Text + "\nSenha: " + txtExibeSenha.Text);

            mail.Priority = MailPriority.High;


            try
            {
                client.Send(mail);
                MessageBox.Show("EMAIL ENVIADO PARA SUA CAIXA DE ENTRADA!!");

            }
            catch (System.Exception)
            {
                //trata erro.
            }
            finally
            {
                mail = null;
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            LOGIN home = new LOGIN();
            this.Close();
            home.Show();


        }







        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-9BS0DO1\SQLEXPRESS;Initial Catalog=Software;User ID=sa;Password=28052018");

            //conta os id existentes
            string id = "SELECT COUNT (*) AS CONT_EMAIL FROM login_usuario WHERE email_usuario = '" + txtEmail.Text + "';";

            SqlCommand cmd_id = new SqlCommand(id, cn);

            cn.Open();

            //LÊ O COUNT ID
            SqlDataReader read_email = cmd_id.ExecuteReader();


            if (read_email.Read())
            {
                lbmail.Text = read_email["CONT_EMAIL"].ToString();

                if (lbmail.Text == "0")
                {
                    pctEmail_Erro.Visible = true;

                    pctEmail_Erro.BackgroundImage = Properties.Resources.erro1;

                    txtEmail.BackColor = Color.LightCoral;

                    mail1.Visible = true;

                    btnEnviar.Enabled = false;
                }

                else if (lbmail.Text == "")
                {
                    pctEmail_Erro.Visible = false;

                    //pctId_Erro.BackgroundImage = Properties.Resources.esta_bem;

                    txtEmail.BackColor = Color.White;

                    mail1.Visible = false;

                    btnEnviar.Enabled = false;
                }

                else if (txtEmail.Text == "")
                {
                    pctEmail_Erro.Visible = false;

                    txtEmail.BackColor = Color.White;

                    mail1.Visible = false;

                    btnEnviar.Enabled = false;

                }

                else
                {
                    pctEmail_Erro.Visible = true;

                    txtEmail.BackColor = Color.LightGreen;
                    pctEmail_Erro.BackgroundImage = Properties.Resources.esta_bem;

                    mail1.Visible = false;

                    btnEnviar.Enabled = true;
                }
            }

            else
            {


            }

            cn.Close();
        }
    }
}


