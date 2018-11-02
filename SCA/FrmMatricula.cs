using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FittSistema.View
{
    public partial class FrmMatricula : Form
    {
        public FrmMatricula()
        {
            InitializeComponent();
        }

        private void btnFecharTela_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmMenu menu = new FrmMenu();
            menu.ShowDialog();
            this.Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos())
            {
                return;
            }

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void lblDataNasc_Click(object sender, EventArgs e)
        {


        }

        private bool ValidarCampos()
        {
            return false;
        }
    }
}
