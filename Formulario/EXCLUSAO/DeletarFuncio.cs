using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Formulario
{
    public partial class DeletarFuncio : Form
    {
        public DeletarFuncio()
        {
            InitializeComponent();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-9BS0DO1\SQLEXPRESS;Initial Catalog=Software;User ID=sa;Password=28052018");
            string sql = "select * from funcionario where Id_func= '" + txtId.Text + "';";
            SqlCommand cmd = new SqlCommand(sql, cn);

            try
            {
                cn.Open();
                SqlDataReader Buscar = cmd.ExecuteReader();

                if (Buscar.Read())
                {
                    txtNome.Text = (Buscar["nome"]).ToString();
                    txtEnde.Text = (Buscar["endereco"]).ToString();
                    txtcpf.Text = (Buscar["cpf"]).ToString();
                    txtrg.Text = (Buscar["rg"]).ToString();
                    txtempresa.Text = (Buscar["empresa"]).ToString();
                    txttelefone.Text = (Buscar["telefone"]).ToString();
                    cbocargo.Text = (Buscar["cargo"]).ToString();
                    txtemail.Text = (Buscar["email"]).ToString();
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

                if (txtNome.Text != "")
                {
                    btnDeleta.Enabled = true;
                    btnLimpar.Enabled = true;
                }
            }
        }

        private void btnDeleta_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-9BS0DO1\SQLEXPRESS;Initial Catalog=Software;User ID=sa;Password=28052018");
            string sql = "delete from funcionario where Id_func = '" + txtId.Text + "';";
            SqlCommand cmd = new SqlCommand(sql, cn);
            try
            {
                cn.Open();
                cmd.ExecuteNonQuery();

                MessageBox.Show("Apagado com Sucesso", "Informação", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Alerta" + ex.Number, MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNome.Text = "";
            txtEnde.Text = "";
            txtcpf.Text = "";
            txtrg.Text = "";
            txtempresa.Text = "";
            txttelefone.Text = "";
            cbocargo.Text = "";
            txtemail.Text = "";
        }

        private void btnLimparCodigo_Click(object sender, EventArgs e)
        {
            txtId.Text = "";
        }
    }
}
