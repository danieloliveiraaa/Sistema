using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formulario
{
    public partial class frmBarra : Form
    {
        public frmBarra()
        {
            InitializeComponent();
        }

        private void frmBarra_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value < 100)
            {
                progressBar1.Value = progressBar1.Value + 5;
            }

            else
            {
                timer1.Enabled = false;
                Principal frm1 = new Principal();
                frm1.Show();
                this.Visible = false;
            }
        }

        
    }
}
