using System;
using System.Windows.Forms;

namespace Formulario
{
    public partial class btnSair : Form
    {
        public btnSair()
        {
            InitializeComponent();
        }

        private void btnCadastroCli_Click(object sender, EventArgs e)
        {
            frmCliente cad_clie = new frmCliente();
            cad_clie.StartPosition = FormStartPosition.CenterScreen;
            cad_clie.Show();
        }

        private void btnCadastroFunc_Click(object sender, EventArgs e)
        {
            frmFuncionario cad_func = new frmFuncionario();
            cad_func.StartPosition = FormStartPosition.CenterScreen;
            cad_func.Show();
        }

        private void btnCadastroEst_Click(object sender, EventArgs e)
        {
            Cadastro_Estoq cad_est = new Cadastro_Estoq();
            cad_est.StartPosition = FormStartPosition.CenterScreen;
            cad_est.Show();
        }

        private void btnAlteraCli_Click(object sender, EventArgs e)
        {
            AlterarCliente alter_clie = new AlterarCliente();
            alter_clie.StartPosition = FormStartPosition.CenterScreen;
            alter_clie.Show();
        }

        private void btnAlteraFunc_Click(object sender, EventArgs e)
        {
            AlterarFunc alter_func = new AlterarFunc();
            alter_func.StartPosition = FormStartPosition.CenterScreen;
            alter_func.Show();
        }

        private void btnAlteraEst_Click(object sender, EventArgs e)
        {
            AlterarEsto alter_est = new AlterarEsto();
            alter_est.StartPosition = FormStartPosition.CenterScreen;
            alter_est.Show();
        }

        private void btnDeleteCli_Click(object sender, EventArgs e)
        {
            DeletarClie del_clie = new DeletarClie();
            del_clie.StartPosition = FormStartPosition.CenterScreen;
            del_clie.Show();

        }

        private void btnDeleteFunc_Click(object sender, EventArgs e)
        {
            DeletarFuncio del_func = new DeletarFuncio();
            del_func.StartPosition = FormStartPosition.CenterScreen;
            del_func.Show();
        }

        private void btnDeleteEst_Click(object sender, EventArgs e)
        {
            DeletarEstoq del_est = new DeletarEstoq();
            del_est.StartPosition = FormStartPosition.CenterScreen;
            del_est.Show();
        }

        private void btnRelatorioFunc_Click(object sender, EventArgs e)
        {
            //DECLARA PASTA DA TELA, E POR FIM A TELA
            EXCEL_RELATORIOS.Exporta_Funcionario excel_func = new EXCEL_RELATORIOS.Exporta_Funcionario();
            excel_func.StartPosition = FormStartPosition.CenterScreen;
            excel_func.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LOGIN log = new LOGIN();
            this.Close();
            log.Show();
        }

        private void btnSair_Load(object sender, EventArgs e)
        {

        }
    }
}
