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
    public partial class FrmMenu2 : Form
    {
        public FrmMenu2()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login telaLogin = new Login();
            telaLogin.ShowDialog();

            this.Close();
        }


        private void btnAnamnese_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmAnamneses anamnese = new FrmAnamneses();
            anamnese.ShowDialog();
            this.Close();
        }

     
        private void FrmMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
