using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Formulario
{
    public partial class Cadastro_Estoq : Form
    {
        public Cadastro_Estoq()
        {
            InitializeComponent();
        }
        private void btnEnviar_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-9BS0DO1\SQLEXPRESS;Initial Catalog=Software;User ID=sa;Password=28052018");
            string sql = "insert into estoque (Id_Prod, Nome, Tipo, Quantidade, Fornecedor, Preco) values(@Id_Prod, @Nome, @Tipo, @Quantidade, @Fornecedor, @Preco)";
            try
            {
                //ANTES SE INSERIR, VERIFICAR SE ALGUNS DOS CAMPOS ABAIXO ESTÃO VAZIOS.
                if ((txtId.Text == "") | (txtNome.Text == "") | (txtQuant.Text == "") | (txtTipo.Text == "") | (txtFornecedor.Text == "") | (txtPreco.Text == ""))
                {
                    MessageBox.Show("HÁ CAMPOS EM BRANCO, POR FAVOR VERIFIQUE !", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                //VERIFICA SE TODOS OS CAMPOS SAO VAZIOS.
                else if ((txtId.Text == "") & (txtNome.Text == "") & (txtQuant.Text == "") & (txtTipo.Text == "") & (txtFornecedor.Text == "") & (txtPreco.Text == ""))
                {
                    MessageBox.Show("NÃO FOI POSSIVEL REALIZAR O CADASTRO,\nPOIS TODOS OS CAMPOS ESTÃO EM BRANCO. \nPOR FAVOR VERIFIQUE.", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                else if ((txtId.BackColor == Color.LightCoral))
                {
                    MessageBox.Show("OS CAMPOS EM VERMELHO, JÁ CONSTAM NO SISTEMA !", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }



                else
                {
                    SqlCommand cmd = new SqlCommand(sql, cn);
                    cmd.Parameters.Add(new SqlParameter("@Id_Prod", this.txtId.Text));
                    cmd.Parameters.Add(new SqlParameter("@Nome", this.txtNome.Text));
                    cmd.Parameters.Add(new SqlParameter("@Tipo", this.txtTipo.Text));
                    cmd.Parameters.Add(new SqlParameter("@Quantidade", this.txtQuant.Text));
                    cmd.Parameters.Add(new SqlParameter("@Fornecedor", this.txtFornecedor.Text));
                    cmd.Parameters.Add(new SqlParameter("@Preco", this.txtPreco.Text));

                    //Abre a conexão com o banco de dados
                    cn.Open();

                    //Executa o comando sql
                    cmd.ExecuteNonQuery();

                    //Mensagem de sucesso para o usuário
                    MessageBox.Show("INCLUÍDO NO ESTOQUE", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
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


        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
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
                //-------------------//
            }

            cn.Close();
        }

        private void btnLimpar_Click_1(object sender, EventArgs e)
        {
            txtId.Text = "";
            txtNome.Text = "";
            txtTipo.Text = "";
            txtQuant.Text = "";
            txtFornecedor.Text = "";
            txtPreco.Text = "";

            txtId.Focus();
        }
    }
}
