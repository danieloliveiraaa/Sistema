using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Formulario
{
    public partial class AlterarCliente : Form
    {
        public AlterarCliente()
        {
            InitializeComponent();

        }

        private void btnAltera_Click(object sender, EventArgs e)
        {

            txtNome.Enabled = true;
            txtEnd.Enabled = true;
            txtCpf.Enabled = true;
            txtRg.Enabled = true;
            txtEmail.Enabled = true;
            txtTelefone.Enabled = true;

            btnSalvar.Enabled = true;
            btnAltera.Enabled = false;

            btnCancelar.Enabled = true;

            btnSalvar.Enabled = true;

            txtId.Enabled = false;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
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
                MessageBox.Show("OS CAMPOS EM VERMELHO, JÁ CONSTAM NO SISTEMA !\n\nUM RG/CPF NÃO PODEM ESTAR VINCULADOS A DOIS IDs SIMULTÂNEAMENTE.", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {


                SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-9BS0DO1\SQLEXPRESS;Initial Catalog=Software;User ID=sa;Password=28052018");
                string sql = String.Format("UPDATE Cliente SET Nome = '{0}', Endereco = '{1}', cpf = '{2}', rg = '{3}', email = '{4}', telefone = '{5}' WHERE Id_cli = '{6}'",
                                                               txtNome.Text, txtEnd.Text, txtCpf.Text, txtRg.Text, txtEmail.Text, txtTelefone.Text, txtId.Text);

                SqlCommand cmd = new SqlCommand(sql, cn);
                try
                {
                    cn.Open();
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("CLIENTE ATUALIZADO COM SUCESSO !", "Informação", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

                    txtId.Text = "";
                    txtNome.Text = "";
                    txtEnd.Text = "";
                    txtCpf.Text = "";
                    txtRg.Text = "";
                    txtEmail.Text = "";
                    txtTelefone.Text = "";

                    txtId.Enabled = true;
                    txtNome.Enabled = false;
                    txtEnd.Enabled = false;
                    txtCpf.Enabled = false;
                    txtRg.Enabled = false;
                    txtEmail.Enabled = false;
                    txtTelefone.Enabled = false;

                    btnAltera.Enabled = true;
                    btnCancelar.Enabled = false;

                    btnSalvar.Enabled = false;



                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message, "Alerta" + ex.Number, MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
            }
        }



        //VERIFICAR SE OS DADOS DIGITADOS SÃOE EXISTENTES.
        private void txtId_TextChanged(object sender, EventArgs e)
        {
            if (txtId.Text == "")
            {
                btnAltera.Enabled = false;
                btnAltera.Visible = false;
                lbEditar.Visible = false;
            }
            else
            {
                btnAltera.Enabled = true;
                btnAltera.Visible = true;
                lbEditar.Visible = true;
            }
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


                //VERIFICAR PRIMEIRAMENTE SE A TEXT BOX ESTA VAZIA.
                //EM TODOS AS VALIDAÇÕES
                if ((txtId.Text == "" || id == "") || (txtId.Text == "" && id == ""))
                {
                    pctId_Erro.Visible = false;

                    txtId.BackColor = Color.White;

                    id1.Visible = false;

                    txtNome.Text = "";
                    txtEnd.Text = "";
                    txtCpf.Text = "";
                    txtRg.Text = "";
                    txtEmail.Text = "";
                    txtTelefone.Text = "";
                }

                else if (id == "0")
                {
                    pctId_Erro.Visible = true;

                    pctId_Erro.BackgroundImage = Properties.Resources.erro1;

                    txtId.BackColor = Color.LightCoral;

                    id1.Visible = true;

                    txtNome.Text = "";
                    txtEnd.Text = "";
                    txtCpf.Text = "";
                    txtRg.Text = "";
                    txtEmail.Text = "";
                    txtTelefone.Text = "";
                }

                else /*if (id == "1")*/
                {
                    pctId_Erro.Visible = true;

                    pctId_Erro.BackgroundImage = Properties.Resources.esta_bem;

                    id1.Visible = false;

                    txtId.BackColor = Color.LightGreen;

                    //MOSTRAR AO USUARIO O CLIENTE REFERENTE AO ID SELECIONADO.
                    SqlConnection cn1 = new SqlConnection(@"Data Source=DESKTOP-9BS0DO1\SQLEXPRESS;Initial Catalog=Software;User ID=sa;Password=28052018");
                    string sql = "SELECT * FROM Cliente WHERE Id_cli = '" + txtId.Text + "';";
                    SqlCommand cmd = new SqlCommand(sql, cn1);

                    cn1.Open();

                    try
                    {

                        SqlDataReader Buscar = cmd.ExecuteReader();

                        if (Buscar.Read())
                        {
                            txtId.Text = Buscar["Id_cli"].ToString();
                            txtNome.Text = Buscar["Nome"].ToString();
                            txtEnd.Text = Buscar["Endereco"].ToString();
                            txtCpf.Text = Buscar["cpf"].ToString();
                            txtRg.Text = Buscar["rg"].ToString();
                            txtEmail.Text = Buscar["email"].ToString();
                            txtTelefone.Text = Buscar["telefone"].ToString();
                        }
                        else
                        {
                            MessageBox.Show("CLIENTE NÃO ENCONTRADO !", "Alerta", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
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


            }

            cn.Close();
        }

























        private void txtRg_TextChanged(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-9BS0DO1\SQLEXPRESS;Initial Catalog=Software;User ID=sa;Password=28052018");

            //conta os RG's existentes referente a este ID
            string rg = "SELECT COUNT (*) AS CONT_RG FROM Cliente WHERE rg = '" + txtRg.Text + "';";

            string rg_id = "SELECT COUNT (*) AS CONT_RG_ID FROM Cliente WHERE rg = '" + txtRg.Text + "' AND Id_cli = '" + txtId.Text + "';";

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

        private void txtCpf_TextChanged(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-9BS0DO1\SQLEXPRESS;Initial Catalog=Software;User ID=sa;Password=28052018");

            //conta os RG's existentes referente a este ID
            string cpf = "SELECT COUNT (*) AS CONT_CPF FROM Cliente WHERE cpf = '" + txtCpf.Text + "';";

            string cpf_id = "SELECT COUNT (*) AS CONT_CPF_ID FROM Cliente WHERE cpf = '" + txtCpf.Text + "' AND Id_cli = '" + txtId.Text + "';";

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

        private void btnCancelar_Click(object sender, EventArgs e)
        {

            //limpa os campos
            txtId.Text = "";
            txtNome.Text = "";
            txtEnd.Text = "";
            txtCpf.Text = "";
            txtRg.Text = "";
            txtEmail.Text = "";
            txtTelefone.Text = "";

            //habilita novamente o botão de alterar
            btnAltera.Enabled = true;

            //e setar enable = false nos campos
            txtNome.Enabled = false;
            txtEnd.Enabled = false;
            txtCpf.Enabled = false;
            txtRg.Enabled = false;
            txtEmail.Enabled = false;
            txtTelefone.Enabled = false;

            //COLOCA O FOCO NO TXT ID e HABILITA
            txtId.Focus();
            txtId.Enabled = true;

            //DESABILITA A SI PROPRIO
            btnCancelar.Enabled = false;

            //desabilita o botao salvar
            btnSalvar.Enabled = false;
        }
    }
}

