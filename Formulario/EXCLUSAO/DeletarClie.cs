using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Formulario
{
    public partial class DeletarClie : Form
    {
        public DeletarClie()
        {
            InitializeComponent();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-9BS0DO1\SQLEXPRESS;Initial Catalog=Software;User ID=sa;Password=28052018");
            string sql = "select * from cliente where Id_cli= '" + txtId.Text + "';";
            SqlCommand cmd = new SqlCommand(sql, cn);

            try
            {
                cn.Open();
                SqlDataReader Buscar = cmd.ExecuteReader();

                if (Buscar.Read())
                {
                    txtNome.Text = (Buscar["nome"]).ToString();
                    txtEnd.Text = (Buscar["endereco"]).ToString();
                    txtCpf.Text = (Buscar["cpf"]).ToString();
                    txtRg.Text = (Buscar["rg"]).ToString();
                    txtEmail.Text = (Buscar["email"]).ToString();
                    txtTelefone.Text = (Buscar["telefone"]).ToString();
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
                    btnDeletar.Enabled = true;
                    btnLimpar2.Enabled = true;
                }
            }
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-9BS0DO1\SQLEXPRESS;Initial Catalog=Software;User ID=sa;Password=28052018");
            string sql = "delete from cliente where Id_cli = '" + txtId.Text + "';";
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

        private void btnLimpar2_Click(object sender, EventArgs e)
        {
            txtNome.Text = "";
            txtEnd.Text = "";
            txtCpf.Text = "";
            txtRg.Text = "";
            txtEmail.Text = "";
            txtTelefone.Text = "";
        }

        private void btnLimparCodigo_Click(object sender, EventArgs e)
        {
            txtId.Text = "";
        }
    }
}