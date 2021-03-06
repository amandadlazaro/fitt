﻿using SCA_BLL;
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
            var adm = control.checar(txtCampoUsuario.Text, Util.Util.criptografarSenha(txtCampoSenha.Text));
            var prof = control.checaProf(txtCampoUsuario.Text, Util.Util.criptografarSenha(txtCampoSenha.Text));
            if (adm)
            {
                this.Hide();
                View.FrmMenu menu = new View.FrmMenu();
                menu.ShowDialog();
                this.Close();
                txtCampoUsuario.Clear();
                txtCampoSenha.Clear();
            }
            else if (prof)
            {
                this.Hide();
                View.FrmMenu2 menu2 = new View.FrmMenu2();
                menu2.ShowDialog();
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

        private void txtCampoUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                txtCampoSenha.Focus();
        }

        private void txtCampoSenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                btnLogin.PerformClick();
        }
    }
}
