using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SCA
{
    public partial class FrmSenha : Form
    {
        public FrmSenha()
        {
            InitializeComponent();
        }
        
        public string Password
        {
            get { return txtSenha.Text; }
            set { txtSenha.Text = value; }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {

        }
    }
}
