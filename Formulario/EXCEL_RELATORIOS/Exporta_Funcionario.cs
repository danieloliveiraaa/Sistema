using ClosedXML.Excel;
using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;


namespace Formulario.EXCEL_RELATORIOS
{
    public partial class Exporta_Funcionario : Form
    {
        public Exporta_Funcionario()
        {
            InitializeComponent();
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-9BS0DO1\SQLEXPRESS;Initial Catalog=Software;User ID=sa;Password=28052018");

            //conta os id existentes
            string id = "SELECT COUNT (*) AS CONT_ID FROM Funcionario WHERE Id_Func = '" + txtId.Text + "';";

            SqlCommand cmd_id = new SqlCommand(id, cn);

            cn.Open();

            //LÊ O COUNT ID
            SqlDataReader read_id = cmd_id.ExecuteReader();


            if (read_id.Read())
            {
                lteste.Text = read_id["CONT_ID"].ToString();

                if (lteste.Text != "0")
                {
                    pctId.Visible = true;

                    pctId.BackgroundImage = Properties.Resources.esta_bem;

                    txtId.BackColor = Color.LightGreen;

                    id1.Visible = false;

                    cn.Close();


                    //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


                    SqlConnection cn2 = new SqlConnection(@"Data Source=DESKTOP-9BS0DO1\SQLEXPRESS;Initial Catalog=Software;User ID=sa;Password=28052018");

                    string sql = "Select * from Funcionario where Id_func = '" + txtId.Text + "';";

                    SqlCommand cmd = new SqlCommand(sql, cn);

                    try
                    {
                        cn.Open();
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
                            txtCPF.Text = Buscar["cpf"].ToString();
                            txtRG.Text = Buscar["rg"].ToString();
                        }
                        else
                        {
                            MessageBox.Show("Funcionário Não Encontrado!", "Alerta", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
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

                else if (lteste.Text == "")
                {
                    pctId.Visible = false;

                    //pctId_Erro.BackgroundImage = Properties.Resources.esta_bem;

                    txtId.BackColor = Color.White;

                    id1.Visible = false;

                    txtNome.Text = "";
                    txtEmail.Text = "";
                    cboCargo.Text = "";
                    txtEmpresa.Text = "";
                    txtTelefone.Text = "";
                    txtEndereco.Text = "";
                    txtCPF.Text = "";
                    txtRG.Text = "";


                }

                else if (txtId.Text == "")
                {
                    pctId.Visible = false;

                    txtId.BackColor = Color.White;

                    id1.Visible = false;

                    txtNome.Text = "";
                    txtEmail.Text = "";
                    cboCargo.Text = "";
                    txtEmpresa.Text = "";
                    txtTelefone.Text = "";
                    txtEndereco.Text = "";
                    txtCPF.Text = "";
                    txtRG.Text = "";

                }

                else
                {
                    pctId.Visible = true;

                    txtId.BackColor = Color.LightCoral;
                    pctId.BackgroundImage = Properties.Resources.erro1;

                    id1.Visible = true;

                    txtNome.Text = "";
                    txtEmail.Text = "";
                    cboCargo.Text = "";
                    txtEmpresa.Text = "";
                    txtTelefone.Text = "";
                    txtEndereco.Text = "";
                    txtCPF.Text = "";
                    txtRG.Text = "";
                }
            }

            else
            {


            }


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pgsBar.Value >= 100)
            {
                timer1.Enabled = false;
                lblStatus.Visible = true;
                pgsBar.Visible = false;
                pgsBar.Value = 0;
            }
            else
            {
                lblStatus.Visible = true;
                pgsBar.Visible = true;
                pgsBar.Value++;

                if (pgsBar.Value == 10)
                {
                    lblStatus.Text = "Preparando Planilha...";

                }
                else if (pgsBar.Value == 30)
                {
                    lblStatus.Text = "Organizando Informações...";

                }
                else if (pgsBar.Value == 60)
                {
                    lblStatus.Text = "Armazenando no disco...";

                }
                else if (pgsBar.Value == 90)
                {
                    lblStatus.Text = "Finalizando...";
                }
                else if (pgsBar.Value == 100)
                {
                    lblStatus.Text = "Relatório Salvo no Disco E:";

                }

            }

        }

        private void btnExportarExcel_Click(object sender, EventArgs e)
        {
            var wb = new XLWorkbook();
            var ws = wb.Worksheets.Add("Planilha");

            //Titulo do Ralatório
            ws.Cells("B1").Value = "RELATÓRIO FUNCIONÁRIOS";
            var range = ws.Range("B2:I2");



            //Cabeçalhos
            ws.Cells("B3").Value = "Codigo";
            ws.Cells("C3").Value = "Nome";
            ws.Cells("D3").Value = "Email";
            ws.Cells("E3").Value = "Cargo";
            ws.Cells("F3").Value = "Empresa";
            ws.Cells("G3").Value = "Telefone";
            ws.Cells("H3").Value = "CPF";
            ws.Cells("I3").Value = "RG";

            //Linhas
            //var linha = 4;

            //for (int i = 0; i < 20; i++)
            //{
            //    ws.Cells("B" + linha.ToString()).Value = txtCodigo.Text;
            //    ws.Cells("C" + linha.ToString()).Value = txtNome.Text;
            //    ws.Cells("D" + linha.ToString()).Value = txtEmail.Text;
            //    ws.Cells("E" + linha.ToString()).Value = cboCargo.Text;
            //    ws.Cells("F" + linha.ToString()).Value = txtEmpresa.Text;
            //    ws.Cells("G" + linha.ToString()).Value = txtTelefone.Text;
            //    ws.Cells("H" + linha.ToString()).Value = txtCPF.Text;
            //    ws.Cells("I" + linha.ToString()).Value = txtRG.Text;

            //    linha++;
            //}

            //ajustar as numeração da linha
            //linha--;

            ws.Cells("B" + "4").Value = txtId.Text;
            ws.Cells("C" + "4").Value = txtNome.Text;
            ws.Cells("D" + "4").Value = txtEmail.Text;
            ws.Cells("E" + "4").Value = cboCargo.Text;
            ws.Cells("F" + "4").Value = txtEmpresa.Text;
            ws.Cells("G" + "4").Value = txtTelefone.Text;
            ws.Cells("H" + "4").Value = txtCPF.Text;
            ws.Cells("I" + "4").Value = txtRG.Text;


            //Formatação por exemplo do tipo 'data'
            //ws.Range("I4:F" + linha.ToString()).Style.NumberFormat = "R$"

            //Cria a tabela

            range = ws.Range("B3:I" + 5);
            range.CreateTable();

            //Ajustar tamanho da coluna
            ws.Columns("2-5").AdjustToContents();

            //Salvamento
            wb.SaveAs(@"E:\Relatório.xlsx");




            timer1.Enabled = true;
            pgsBar.Visible = true;


        }
    }
}
