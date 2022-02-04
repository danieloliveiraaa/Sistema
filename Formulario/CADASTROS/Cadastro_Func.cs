using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Formulario
{
    public partial class frmFuncionario : Form
    {
        public frmFuncionario()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            btnSair menu = new btnSair();
            this.Hide();
            menu.Show();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-9BS0DO1\SQLEXPRESS;Initial Catalog=Software;Persist Security Info=True;User ID=sa;Password=28052018");
            string sql = "insert into Funcionario (Id_func, nome, email, cargo, empresa, telefone, endereco, cpf, rg) values(@Id_func, @nome, @email, @cargo, @empresa, @telefone, @endereco, @cpf, @rg)";
            try
            {

                //ANTES SE INSERIR, VERIFICAR SE ALGUNS DOS CAMPOS ABAIXO ESTÃO VAZIOS.
                if ((txtId.Text == "") | (txtNome.Text == "") | (txtCpf.Text == "") | (txtEmail.Text == "") | (txtEndereco.Text == "") | (txtTelefone.Text == "") | (txtRg.Text == ""))
                {
                    MessageBox.Show("HÁ CAMPOS EM BRANCO, POR FAVOR VERIFIQUE !", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                //VERIFICA SE OS CAMPOS CPF, RG E WHATSAPP ESTÃO COM AS QUATIDADES CERTAS.
                else if ((txtCpf.Text.Length < 11) | (txtRg.Text.Length < 9) | (txtTelefone.Text.Length < 9))
                {
                    MessageBox.Show("Erro nos seguintes campos: \n-CPF \n-RG \n-Celular \nDescrição: Os seguintes campos, estão faltando caracteres", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                //VERIFICA SE TODOS OS CAMPOS SAO VAZIOS.
                else if ((txtId.Text == "") & (txtNome.Text == "") & (txtCpf.Text == "") & (txtEmail.Text == "") & (txtEndereco.Text == "") & (txtTelefone.Text == "") & (txtRg.Text == ""))
                {
                    MessageBox.Show("NÃO FOI POSSIVEL REALIZAR O CADASTRO,\nPOIS TODOS OS CAMPOS ESTÃO EM BRANCO. \nPOR FAVOR VERIFIQUE.", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                else if ((txtId.BackColor == Color.LightCoral) | (txtCpf.BackColor == Color.LightCoral) | (txtRg.BackColor == Color.LightCoral))
                {
                    MessageBox.Show("OS CAMPOS EM VERMELHO, JÁ CONSTAM NO SISTEMA !", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }




                SqlCommand cmd = new SqlCommand(sql, cn);
                cmd.Parameters.Add(new SqlParameter("@Id_func", this.txtId.Text));
                cmd.Parameters.Add(new SqlParameter("@nome", this.txtNome.Text));
                cmd.Parameters.Add(new SqlParameter("@email", this.txtEmail.Text));
                cmd.Parameters.Add(new SqlParameter("@cargo", this.cboCargo.Text));
                cmd.Parameters.Add(new SqlParameter("@empresa", this.txtEmpresa.Text));
                cmd.Parameters.Add(new SqlParameter("@telefone", this.txtTelefone.Text));
                cmd.Parameters.Add(new SqlParameter("@endereco", this.txtEndereco.Text));
                cmd.Parameters.Add(new SqlParameter("@cpf", this.txtCpf.Text));
                cmd.Parameters.Add(new SqlParameter("@rg", this.txtRg.Text));
                //Abre a conexão com o banco de dados



                cn.Open();

                //Executa o comando sql
                cmd.ExecuteNonQuery();


                //Mensagem de sucesso para o usuário
                MessageBox.Show("FUNCIONÁRIO CADASTRADO", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtId.Text = "";
                txtNome.Text = "";
                txtEmail.Text = "";
                cboCargo.Text = "";
                txtEmpresa.Text = "";
                txtTelefone.Text = "";
                txtEndereco.Text = "";
                txtCpf.Text = "";
                txtRg.Text = "";

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

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtId.Text = "";
            txtNome.Text = "";
            txtEmail.Text = "";
            cboCargo.Text = "";
            txtEmpresa.Text = "";
            txtTelefone.Text = "";
            txtEndereco.Text = "";
            txtCpf.Text = "";
            txtRg.Text = "";
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-9BS0DO1\SQLEXPRESS;Initial Catalog=Software;User ID=sa;Password=28052018");

            //conta os id existentes
            string id = "SELECT COUNT (*) AS CONT_ID FROM Funcionario WHERE Id_func = '" + txtId.Text + "';";

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

        private void txtCPF_TextChanged(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-9BS0DO1\SQLEXPRESS;Initial Catalog=Software;User ID=sa;Password=28052018");

            //conta os cpf's existentes
            string cpf = "SELECT COUNT (*) AS CONT_CPF FROM Funcionario WHERE cpf = '" + txtCpf.Text + "';";

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

        private void txtRG_TextChanged(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-9BS0DO1\SQLEXPRESS;Initial Catalog=Software;User ID=sa;Password=28052018");

            //conta os rg's existentes
            string rg = "SELECT COUNT (*) AS CONT_RG FROM Funcionario WHERE rg = '" + txtRg.Text + "';";

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
    }
}
