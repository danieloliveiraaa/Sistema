using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Formulario
{
    public partial class frmCliente : Form
    {
        public frmCliente()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

            SqlConnection ds = new SqlConnection(@"Data Source=DESKTOP-9BS0DO1\SQLEXPRESS;Initial Catalog=Software;User ID=sa;Password=28052018");
            string sql = "insert into Cliente (Id_cli, Nome, Endereco, cpf, rg, email, telefone) values(@Id_cli, @Nome, @Endereco, @cpf, @rg, @email, @telefone)";


            try
            {

                //ANTES SE INSERIR, VERIFICAR SE ALGUNS DOS CAMPOS ABAIXO ESTÃO VAZIOS.
                if ((txtId.Text == "") | (txtNome.Text == "") | (txtCpf.Text == "") | (txtEmail.Text == "") | (txtEnd.Text == "") | (txtTelefone.Text == "") | (txtRg.Text == ""))
                {
                    MessageBox.Show("HÁ CAMPOS EM BRANCO, POR FAVOR VERIFIQUE !", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                //VERIFICA SE OS CAMPOS CPF, RG E WHATSAPP ESTÃO COM AS QUATIDADES CERTAS.
                else if ((txtCpf.Text.Length < 11) | (txtRg.Text.Length < 9) | (txtTelefone.Text.Length < 9))
                {
                    MessageBox.Show("Erro nos seguintes campos: \n-CPF \n-RG \n-Celular \nDescrição: Os seguintes campos, estão faltando caracteres", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                //VERIFICA SE TODOS OS CAMPOS SAO VAZIOS.
                else if ((txtId.Text == "") & (txtNome.Text == "") & (txtCpf.Text == "") & (txtEmail.Text == "") & (txtEnd.Text == "") & (txtTelefone.Text == "") & (txtRg.Text == ""))
                {
                    MessageBox.Show("NÃO FOI POSSIVEL REALIZAR O CADASTRO,\nPOIS TODOS OS CAMPOS ESTÃO EM BRANCO. \nPOR FAVOR VERIFIQUE.", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                else if ((txtId.BackColor == Color.LightCoral) | (txtCpf.BackColor == Color.LightCoral) | (txtRg.BackColor == Color.LightCoral))
                {
                    MessageBox.Show("OS CAMPOS EM VERMELHO, JÁ CONSTAM NO SISTEMA !", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }



                else
                {
                    SqlCommand cmd = new SqlCommand(sql, ds);
                    cmd.Parameters.Add(new SqlParameter("@Id_cli", this.txtId.Text));
                    cmd.Parameters.Add(new SqlParameter("@Nome", this.txtNome.Text));
                    cmd.Parameters.Add(new SqlParameter("@Endereco", this.txtEmail.Text));
                    cmd.Parameters.Add(new SqlParameter("@cpf", this.txtCpf.Text));
                    cmd.Parameters.Add(new SqlParameter("@rg", this.txtRg.Text));
                    cmd.Parameters.Add(new SqlParameter("@email", this.txtEmail.Text));
                    cmd.Parameters.Add(new SqlParameter("@telefone", this.txtTelefone.Text));

                    //Abre a conexão com o banco de dados
                    ds.Open();

                    //Executa o comando sql
                    cmd.ExecuteNonQuery();


                    //LIMPA OS CAMPOS
                    txtId.Text = "";
                    txtNome.Text = "";
                    txtEnd.Text = "";
                    txtCpf.Text = "";
                    txtRg.Text = "";
                    txtEmail.Text = "";
                    txtTelefone.Text = "";

                    //Mensagem de sucesso para o usuário
                    MessageBox.Show("CLIENTE CADASTRADO !", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);


                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Alerta de Erro" + ex.Number, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                ds.Close();
            }


        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((txtId.Text == "") && (txtNome.Text == "") && (txtCpf.Text == "") && (txtEmail.Text == "") && (txtEnd.Text == "") && (txtTelefone.Text == "") && (txtRg.Text == ""))
            {
                MessageBox.Show("OS CAMPOS JÁ ESTÃO EM BRANCO", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                //LIMPA OS CAMPOS
                txtId.Text = "";
                txtNome.Text = "";
                txtEnd.Text = "";
                txtCpf.Text = "";
                txtRg.Text = "";
                txtEmail.Text = "";
                txtTelefone.Text = "";

                MessageBox.Show("LIMPOS !", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-9BS0DO1\SQLEXPRESS;Initial Catalog=Software;User ID=sa;Password=28052018");

            //conta os id existentes
            string id = "SELECT COUNT (*) AS CONT_ID FROM Cliente WHERE Id_cli = '" + txtId.Text + "';";

            SqlCommand cmd_id = new SqlCommand(id, cn);

            cn.Open();

            //LÊ O COUNT ID
            SqlDataReader read_id = cmd_id.ExecuteReader();


            if (read_id.Read())
            {
                id = read_id["CONT_ID"].ToString();

                //CASO A CAIXA TEXTO E/OU A VARIAVEL id SEJAM VAZIAS... 
                if ((txtId.Text == "" || id == "") || (txtId.Text == "" && id == ""))
                {
                    pctId_Erro.Visible = false;

                    txtId.BackColor = Color.White;

                    id1.Visible = false;
                }

                //EXISTINDO ESSE ID NO BANCO...
                else if (id == "1")
                {
                    pctId_Erro.Visible = true;
                    pctId_Erro.BackgroundImage = Properties.Resources.erro1;

                    txtId.BackColor = Color.LightCoral;

                    id1.Visible = true;
                }

                else
                {
                    pctId_Erro.Visible = true;

                    txtId.BackColor = Color.LightGreen;
                    pctId_Erro.BackgroundImage = Properties.Resources.esta_bem;

                    id1.Visible = false;
                }
            }

            else
            {


            }

            cn.Close();
        }

        private void txtCpf_TextChanged(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-9BS0DO1\SQLEXPRESS;Initial Catalog=Software;User ID=sa;Password=28052018");

            //conta os cpf's existentes
            string cpf = "SELECT COUNT (*) AS CONT_CPF FROM Cliente WHERE cpf = '" + txtCpf.Text + "';";

            SqlCommand cmd_cpf = new SqlCommand(cpf, cn);

            cn.Open();

            //LÊ O COUNT CPF
            SqlDataReader read_cpf = cmd_cpf.ExecuteReader();


            if (read_cpf.Read())
            {
                cpf = read_cpf["CONT_CPF"].ToString();

                //CASO A CAIXA TEXTO E/OU A VARIAVEL id SEJAM VAZIAS...
                if ((txtCpf.Text == "" || cpf == "") || (txtCpf.Text == "" && cpf == ""))
                {
                    pctCpf_Erro.Visible = false;

                    txtCpf.BackColor = Color.White;

                    cpf1.Visible = false;
                }

                //EXISTINDO ESSE ID NO BANCO...
                else if (cpf == "1")
                {
                    pctCpf_Erro.Visible = true;

                    pctCpf_Erro.BackgroundImage = Properties.Resources.erro1;

                    txtCpf.BackColor = Color.LightCoral;

                    cpf1.Visible = true;
                }


                else
                {
                    pctCpf_Erro.Visible = true;

                    txtCpf.BackColor = Color.LightGreen;
                    pctCpf_Erro.BackgroundImage = Properties.Resources.esta_bem;

                    cpf1.Visible = false;
                }

            }
            else
            {

            }

            cn.Close();
        }

        private void txtRg_TextChanged(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-9BS0DO1\SQLEXPRESS;Initial Catalog=Software;User ID=sa;Password=28052018");

            //conta os rg's existentes
            string rg = "SELECT COUNT (*) AS CONT_RG FROM Cliente WHERE rg = '" + txtRg.Text + "';";

            SqlCommand cmd_rg = new SqlCommand(rg, cn);

            cn.Open();

            //LÊ O COUNT CPF
            SqlDataReader read_rg = cmd_rg.ExecuteReader();


            if (read_rg.Read())
            {
                rg = read_rg["CONT_RG"].ToString();

                //CASO A CAIXA TEXTO E/OU A VARIAVEL id SEJAM VAZIAS...
                if ((txtRg.Text == "" || rg == "") || (txtRg.Text == "" && rg == ""))
                {
                    pctRg_Erro.Visible = false;

                    txtRg.BackColor = Color.White;

                    rg1.Visible = false;
                }

                //EXISTINDO ESSE ID NO BANCO...
                else if (rg == "1")
                {
                    pctRg_Erro.Visible = true;

                    pctRg_Erro.BackgroundImage = Properties.Resources.erro1;

                    txtRg.BackColor = Color.LightCoral;

                    rg1.Visible = true;
                }

                else
                {
                    pctRg_Erro.Visible = true;

                    txtRg.BackColor = Color.LightGreen;
                    pctRg_Erro.BackgroundImage = Properties.Resources.esta_bem;

                    rg1.Visible = false;
                }
            }
            else
            {

            }
            cn.Close();
        }

        private void rg1_Click(object sender, EventArgs e)
        {

        }
    }
}



