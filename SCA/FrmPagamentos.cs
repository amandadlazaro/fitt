using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using SCA_BLL;

namespace FittSistema.View
{
    public partial class FrmPagamentos : Form
    {
        public FrmPagamentos()
        {
            InitializeComponent();
        }

        PagamentoBLL pagamentoBLL = new PagamentoBLL();

        #region Functions

        private void listarAlunos()
        {
            dgvPagamento.DataSource = pagamentoBLL.LerBoleto();
        }

        #endregion

        #region Form

        private void btnFecharTela_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmMenu menu = new FrmMenu();
            menu.ShowDialog();
            this.Close();
        }

        private void FrmPagamentos_Load(object sender, EventArgs e)
        {
            listarAlunos();
        }

        #endregion
    }
}
