using SCA_BLL;
using System;
using System.Windows.Forms;

namespace FittSistema
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            LoginBLL control = new LoginBLL();
            var existenoBD = control.checar(txtCampoUsuario.Text, txtCampoSenha.Text);
            if (existenoBD)
            {
                this.Hide();
                View.FrmMenu menu = new View.FrmMenu();
                menu.ShowDialog();
                this.Close();
                txtCampoUsuario.Clear();
                txtCampoSenha.Clear();
            }
            else
            {
                MessageBox.Show("Verificar Login e/ou Senha", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
