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
    public partial class FrmGerarPagamento : Form
    {
        public FrmGerarPagamento(bool editar = false)
        {
            InitializeComponent();

            if (editar) ModoEditar();
            else ModoCadastrar();
        }
        #region functions
        
        private void ModoCadastrar()
        {
            txtNome.Text = GerarPagamentoBLL.Nome;
        }

        private void ModoEditar()
        {

        }

        #endregion

        private void btnFecharTela_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmMenu menu = new FrmMenu();
            menu.ShowDialog();
            this.Close();
        }
    }
}
