using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Formulario
{
    public partial class AlterarEsto : Form
    {
        public AlterarEsto()
        {
            InitializeComponent();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-9BS0DO1\SQLEXPRESS;Initial Catalog=Software;User ID=sa;Password=28052018");
            string sql = "select * from estoque where Id_Prod= '" + txtId.Text + "';";
            SqlCommand cmd = new SqlCommand(sql, cn);

            try
            {
                cn.Open();
                SqlDataReader Buscar = cmd.ExecuteReader();

                if (Buscar.Read())
                {
                    txtNome.Text = (Buscar["Nome"]).ToString();
                    txtTipo.Text = (Buscar["Tipo"]).ToString();
                    txtQuant.Text = (Buscar["Quantidade"]).ToString();
                    txtFornecedor.Text = (Buscar["Fornecedor"]).ToString();
                    txtPreco.Text = (Buscar["Preco"]).ToString();

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
                    btnAltera.Enabled = true;
                    btnLimpar.Enabled = true;
                }
            }
        }

        private void btnLimparCodigo_Click(object sender, EventArgs e)
        {
            txtId.Text = "";
        }

        private void btnAltera_Click(object sender, EventArgs e)
        {
            txtNome.Enabled = true;
            txtTipo.Enabled = true;
            txtQuant.Enabled = true;
            txtFornecedor.Enabled = true;
            txtPreco.Enabled = true;


            btnSalvar.Enabled = true;
            btnAltera.Enabled = false;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-9BS0DO1\SQLEXPRESS;Initial Catalog=Software;User ID=sa;Password=28052018");
            string sql = String.Format("update estoque set Nome = '{0}', Tipo = '{1}', Quantidade = '{2}', Fornecedor = '{3}', Preco = '{4}' where Id_Prod = '{5}'",
                txtNome.Text, txtTipo.Text, txtQuant.Text, txtFornecedor.Text, txtPreco.Text, txtId.Text);
            SqlCommand cmd = new SqlCommand(sql, cn);
            try
            {
                cn.Open();
                cmd.ExecuteNonQuery();

                MessageBox.Show("Registro Salvo com Sucesso", "Informação", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Alerta" + ex.Number, MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }
    }
}
