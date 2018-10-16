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
    public partial class FrmAnamneses : Form
    {
        public FrmAnamneses()
        {
            InitializeComponent();
        }

        private void btnFecharForm_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmMenu menu = new FrmMenu();
            menu.ShowDialog();
            this.Close();
        }
    }
}
