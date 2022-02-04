using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Formulario
{
    public partial class AlterarFunc : Form
    {
        public AlterarFunc()
        {
            InitializeComponent();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-9BS0DO1\SQLEXPRESS;Initial Catalog=Software;User ID=sa;Password=28052018");
            string sql = "select * from funcionario where Id_func = '" + txtId.Text + "';";
            SqlCommand cmd = new SqlCommand(sql, cn);

            try
            {
                cn.Open();
                SqlDataReader Buscar = cmd.ExecuteReader();

                if (Buscar.Read())
                {
                    txtNome.Text = (Buscar["nome"]).ToString();
                    txtEndereco.Text = (Buscar["endereco"]).ToString();
                    txtCpf.Text = (Buscar["cpf"]).ToString();
                    txtRg.Text = (Buscar["rg"]).ToString();
                    txtEmpresa.Text = (Buscar["empresa"]).ToString();
                    txtTelefone.Text = (Buscar["telefone"]).ToString();
                    cboCargo.Text = (Buscar["cargo"]).ToString();
                    txtEmail.Text = (Buscar["email"]).ToString();
                }
                else
                {
                    MessageBox.Show("Nenhum usuario encontrado", "Alerta", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
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
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            //HABILITA OS CAMPOS TEXTO PARA EDIÇÃO.
            txtNome.Enabled = true;
            txtEndereco.Enabled = true;
            txtCpf.Enabled = true;
            txtRg.Enabled = true;
            txtEmpresa.Enabled = true;
            txtTelefone.Enabled = true;
            cboCargo.Enabled = true;
            txtEmail.Enabled = true;

            //HABILITA OS BOTÕES CANCELAR E SALVAR.
            btnSalvar.Enabled = true;
            btnCancela.Enabled = true;

            //E DESABILITA O BOTÃO ALTERAR
            //POIS JA FOI CLICADO.
            btnAlterar.Enabled = false;

            //DESABILITA O CAMPO ID
            //ALTERAÇÃO ESTA SENDO FEITA COM BASE NELE.
            txtId.Enabled = false;




        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {
            if (txtId.Text == "")
            {
                btnAlterar.Enabled = false;
                btnAlterar.Visible = false;
                lbEditar.Visible = false;
            }
            else
            {
                btnAlterar.Enabled = true;
                btnAlterar.Visible = true;
                lbEditar.Visible = true;
            }
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


                //VERIFICAR PRIMEIRAMENTE SE A TEXT BOX ESTA VAZIA.
                //EM TODOS AS VALIDAÇÕES
                if ((txtId.Text == "" || id == "") || (txtId.Text == "" && id == ""))
                {
                    pctId_Erro.Visible = false;

                    txtId.BackColor = Color.White;

                    id1.Visible = false;

                    txtNome.Text = "";
                    txtEmail.Text = "";
                    cboCargo.Text = "";
                    txtEmpresa.Text = "";
                    txtTelefone.Text = "";
                    txtEndereco.Text = "";
                    txtCpf.Text = "";
                    txtRg.Text = "";
                }

                //caso não encontre o funcionario, com o ID que foi digitado
                //roda a instrução abaixo
                else if (id == "0")
                {

                    pctId_Erro.Visible = true;

                    pctId_Erro.BackgroundImage = Properties.Resources.erro1;

                    txtId.BackColor = Color.LightCoral;

                    id1.Visible = true;

                    txtNome.Text = "";
                    txtEmail.Text = "";
                    cboCargo.Text = "";
                    txtEmpresa.Text = "";
                    txtTelefone.Text = "";
                    txtEndereco.Text = "";
                    txtCpf.Text = "";
                    txtRg.Text = "";

                }

                //encontrando...

                else /*if (id == "1")*/
                {
                    pctId_Erro.Visible = true;

                    pctId_Erro.BackgroundImage = Properties.Resources.esta_bem;

                    id1.Visible = false;

                    txtId.BackColor = Color.LightGreen;

                    //MOSTRAR AO USUARIO O CLIENTE REFERENTE AO ID SELECIONADO.
                    SqlConnection cn1 = new SqlConnection(@"Data Source=DESKTOP-9BS0DO1\SQLEXPRESS;Initial Catalog=Software;User ID=sa;Password=28052018");
                    string sql = "SELECT * FROM Funcionario WHERE Id_func = '" + txtId.Text + "';";
                    SqlCommand cmd = new SqlCommand(sql, cn1);

                    cn1.Open();

                    try
                    {

                        SqlDataReader Buscar = cmd.ExecuteReader();

                        if (Buscar.Read())
                        {
                            txtId.Text = Buscar["Id_func"].ToString();
                            txtNome.Text = Buscar["nome"].ToString();
                            txtEmail.Text = Buscar["email"].ToString();
                            cboCargo.Text = Buscar["cargo"].ToString();
                            txtEmpresa.Text = Buscar["empresa"].ToString();
                            txtTelefone.Text = Buscar["telefone"].ToString();
                            txtEndereco.Text = Buscar["endereco"].ToString();
                            txtCpf.Text = Buscar["cpf"].ToString();
                            txtRg.Text = Buscar["rg"].ToString();
                        }
                        else
                        {
                            MessageBox.Show("FUNCIONARIO NÃO ENCONTRADO !", "Alerta", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                        }
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show(ex.Message, "Alerta" + ex.Number, MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    }

                    finally
                    {
                        cn1.Close();
                    }
                }
            }
            else
            {
                //NULL
                //NADA
            }
            cn.Close();
        }

        private void btnSalvar_Click_1(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-9BS0DO1\SQLEXPRESS;Initial Catalog=Software;User ID=sa;Password=28052018");

            string sql = String.Format("UPDATE Funcionario SET nome = '{0}', email = '{1}', cargo = '{2}', empresa = '{3}', telefone = '{4}', endereco = '{5}', cpf = '{6}', rg = '{7}' WHERE Id_func = '{8}'",
            txtNome.Text, txtEmail.Text, cboCargo.Text, txtEmpresa.Text, txtTelefone.Text, txtEndereco.Text, txtCpf.Text, txtRg.Text, txtId.Text);

            SqlCommand cmd = new SqlCommand(sql, cn);
            try
            {
                cn.Open();
                cmd.ExecuteNonQuery();

                MessageBox.Show("FUNCIONARIO ALTERADO COM SUCESSO !", "Informação", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

                txtId.Text = "";
                txtNome.Text = "";
                txtEmail.Text = "";
                cboCargo.Text = "";
                txtEmpresa.Text = "";
                txtTelefone.Text = "";
                txtEndereco.Text = "";
                txtCpf.Text = "";
                txtRg.Text = "";


                txtNome.Enabled = false;
                txtEmail.Enabled = false;
                cboCargo.Enabled = false;
                txtEmpresa.Enabled = false;
                txtTelefone.Enabled = false;
                txtEndereco.Enabled = false;
                txtCpf.Enabled = false;
                txtRg.Enabled = false;


                txtId.Enabled = true;

                btnAlterar.Enabled = true;
                btnCancela.Enabled = false;
                btnSalvar.Enabled = false;

                txtId.Focus();



            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Alerta" + ex.Number, MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            finally
            {
                cn.Close();
            }
        }

        private void txtCpf_TextChanged(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-9BS0DO1\SQLEXPRESS;Initial Catalog=Software;User ID=sa;Password=28052018");

            //conta os RG's existentes referente a este ID
            string cpf = "SELECT COUNT (*) AS CONT_CPF FROM Funcionario WHERE cpf = '" + txtCpf.Text + "';";

            string cpf_id = "SELECT COUNT (*) AS CONT_CPF_ID FROM Funcionario WHERE cpf = '" + txtCpf.Text + "' AND Id_func = '" + txtId.Text + "';";

            SqlCommand cmd_cpf = new SqlCommand(cpf, cn);

            SqlCommand cmd_cpf_id = new SqlCommand(cpf_id, cn);

            cn.Open();

            //LÊ O COUNT ID
            SqlDataReader read_cpf = cmd_cpf.ExecuteReader();




            if (txtCpf.Enabled == true)
            {
                if (read_cpf.Read())
                {
                    cpf = read_cpf["CONT_CPF"].ToString();



                    //VERIFICA SE A VARIAVEL E/OU O CAMPO TEXTO DE RG SÃO VAZIOS/NULOS

                    if ((txtCpf.Text == "" || cpf == "") || (txtCpf.Text == "" && cpf == ""))
                    {
                        pctCpf.Visible = false;

                        //pctCpf.BackgroundImage = Properties.Resources.esta_bem;

                        txtCpf.BackColor = Color.White;

                        cpf1.Visible = false;

                    }


                    //SE A CONTAGEM DE CPF'S EXISTENTES FOR IGUAL A 1
                    //FAZ OUTRA VERIFICAÇÃO...

                    else if (cpf == "1")
                    {
                        read_cpf.Close();

                        SqlDataReader read_cpf_id = cmd_cpf_id.ExecuteReader();

                        read_cpf_id.Read();

                        cpf_id = read_cpf_id["CONT_CPF_ID"].ToString();

                        //VERIFICA SE A CONTAGEM DO CPF DIGITADO REFERENTE AO ID DIGITADO FOR IGUAL A 1, ESTÁ OK.
                        //POIS SIGNIFICA, QUE O CPF DIGITADO PERTENCE A SOMENTE 1 ID NA TABELA CLIENTES
                        if (cpf_id == "1")
                        {
                            pctCpf.Visible = true;
                            pctCpf.BackgroundImage = Properties.Resources.esta_bem;
                            txtCpf.BackColor = Color.LightGreen;
                            cpf1.Visible = false;
                        }

                        //SE O CPF DIGITADO PERTENCER A OUTRO ID, RODA A VERIFICAÇÃO ABAIXO
                        //NÃO PODE HAVER DOIS CPFs IGUAIS VINCULADOS A IDs DIFERENTES.
                        else
                        {
                            pctCpf.Visible = true;
                            pctCpf.BackgroundImage = Properties.Resources.erro1;
                            txtCpf.BackColor = Color.LightCoral;
                            cpf1.Visible = true;
                            cpf1.Text = "CPF PERTENCE A OUTRO ID !";
                        }

                    }


                    else
                    {
                        pctCpf.Visible = false;

                        txtCpf.BackColor = Color.Empty;

                        cpf1.Visible = false;

                    }
                }
                else
                {

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

            //conta os RG's existentes referente a este ID
            string rg = "SELECT COUNT (*) AS CONT_RG FROM Funcionario WHERE rg = '" + txtRg.Text + "';";

            string rg_id = "SELECT COUNT (*) AS CONT_RG_ID FROM Funcionario WHERE rg = '" + txtRg.Text + "' AND Id_func = '" + txtId.Text + "';";

            SqlCommand cmd_rg = new SqlCommand(rg, cn);

            SqlCommand cmd_rg_id = new SqlCommand(rg_id, cn);

            cn.Open();

            //LÊ O COUNT ID
            SqlDataReader read_rg = cmd_rg.ExecuteReader();




            if (txtRg.Enabled == true)
            {
                if (read_rg.Read())
                {
                    rg = read_rg["CONT_RG"].ToString();



                    //VERIFICA SE A VARIAVEL E/OU O CAMPO TEXTO DE RG SÃO VAZIOS/NULOS

                    if ((txtRg.Text == "" || rg == "") || (txtRg.Text == "" && rg == ""))
                    {
                        pctRg.Visible = false;

                        //pctRg.BackgroundImage = Properties.Resources.esta_bem;

                        txtRg.BackColor = Color.White;

                        rg1.Visible = false;

                    }


                    //SE A CONTAGEM DE RG'S EXISTENTES FOR IGUAL A 1
                    //FAZ OUTRA VERIFICAÇÃO...

                    else if (rg == "1")
                    {
                        read_rg.Close();

                        SqlDataReader read_rg_id = cmd_rg_id.ExecuteReader();

                        read_rg_id.Read();

                        rg_id = read_rg_id["CONT_RG_ID"].ToString();

                        //VERIFICA SE A CONTAGEM DO RG DIGITADO REFERENTE AO ID DIGITADO FOR IGUAL A 1, ESTÁ OK.
                        //POIS SIGNIFICA, QUE O RG DIGITADO PERTENCE A SOMENTE 1 ID NA TABELA CLIENTES
                        if (rg_id == "1")
                        {
                            pctRg.Visible = true;
                            pctRg.BackgroundImage = Properties.Resources.esta_bem;
                            txtRg.BackColor = Color.LightGreen;
                            rg1.Visible = false;
                        }

                        //SE O RG DIGITADO PERTENCER A OUTRO ID, RODA A VERIFICAÇÃO ABAIXO
                        //NÃO PODE HAVER DOIS RGs IGUAIS VINCULADOS A IDs DIFERENTES.
                        else
                        {
                            pctRg.Visible = true;
                            pctRg.BackgroundImage = Properties.Resources.erro1;
                            txtRg.BackColor = Color.LightCoral;
                            rg1.Visible = true;
                            rg1.Text = "RG PERTENCE A OUTRO ID !";
                        }

                    }

                    else if (rg == "0")
                    {
                        pctRg.Visible = false;

                        txtRg.BackColor = Color.White;

                        rg1.Visible = false;
                    }
                }
                else
                {

                }
            }
            else
            {

            }
            cn.Close();
        }

        private void btnCancela_Click(object sender, EventArgs e)
        {
            //limpa os campos
            txtId.Text = "";
            txtNome.Text = "";
            txtEmail.Text = "";
            cboCargo.Text = "";
            txtEmpresa.Text = "";
            txtTelefone.Text = "";
            txtEndereco.Text = "";
            txtCpf.Text = "";
            txtRg.Text = "";

            //habilita novamente o botão de alterar
            btnAlterar.Enabled = true;

            //e setar enable = false nos campos
            txtNome.Enabled = false;
            txtEmail.Enabled = false;
            cboCargo.Enabled = false;
            txtEmpresa.Enabled = false;
            txtTelefone.Enabled = false;
            txtEndereco.Enabled = false;
            txtCpf.Enabled = false;
            txtRg.Enabled = false;

            //COLOCA O FOCO NO TXT ID
            txtId.Focus();
            txtId.Enabled = true;


            //DESABILITA A SI PROPRIO
            btnCancela.Enabled = false;

            //desabilita o botao salvar
            btnSalvar.Enabled = false;
        }
    }
}
