using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Formulario
{
    public partial class DeletarEstoq : Form
    {
        public DeletarEstoq()
        {
            InitializeComponent();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-9BS0DO1\SQLEXPRESS;Initial Catalog=Software;User ID=sa;Password=28052018");
            string sql = "select * from estoque where Id_Prod = '" + txtId.Text + "';";
            SqlCommand cmd = new SqlCommand(sql, cn);

            try
            {
                cn.Open();
                SqlDataReader Buscar = cmd.ExecuteReader();

                if (Buscar.Read())
                {
                    txtId.Text = Buscar["Id_Prod"].ToString();
                    txtNome.Text = Buscar["Nome"].ToString();
                    txtTipo.Text = Buscar["Tipo"].ToString();
                    txtQuant.Text = Buscar["Quantidade"].ToString();
                    txtFornecedor.Text = Buscar["Fornecedor"].ToString();
                    txtPreco.Text = Buscar["Preco"].ToString();

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
                    btnLimpar.Enabled = true;
                }
            }
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-9BS0DO1\SQLEXPRESS;Initial Catalog=Software;User ID=sa;Password=28052018");
            string sql = "delete from estoque where Id_Prod = '" + txtId.Text + "';";
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
            txtTipo.Text = "";
            txtQuant.Text = "";
            txtFornecedor.Text = "";
            txtPreco.Text = "";
        }

        private void btnLimparCodigo_Click(object sender, EventArgs e)
        {
            txtId.Text = "";
        }
    }
}
