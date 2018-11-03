﻿using System;
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
using System.Globalization;


namespace FittSistema.View
{
    public partial class FrmAdministrador : Form
    {
        public FrmAdministrador()
        {
            InitializeComponent();
        }

        //AdministradorBLL administradorBLL = new AdministradorBLL();

        private void btnEditarAdministrador_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Alterar esses dados?", "Alterar Professor", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (ValidaCampos() != "")
                {
                    MessageBox.Show(ValidaCampos(), "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    var adm = new Administrador
                    {
                        email=txtEmail.Text,
                        senha=txtEmail.Text

                    };
                //    object administradorBLL = administradorBLL;
                 //   MessageBox.Show(administradorBLL.AlterarAdministrador(adm));
                    listarAdministrador();
                    grpAdministrador.Show();
                    btnCadastrarAdministrador.Show();

                    btnVoltar.Hide();
                }
            }

        }

        private void listarAdministrador()
        {
        //    var administrador = administradorBLL.LerAdministrador();
           // grpAdministrador.DataSource = administrador.ToList();
        }

        private string ValidaCampos()
        {
            string erro = "";
            if (string.IsNullOrEmpty(txtEmail.Text))
            {
                erro = "Preencha o campo E-mail";
            }
            else if (!Util.Util.validarEmail(txtEmail.Text))
            {
                erro = "E-mail inválido";
            }
            else if (string.IsNullOrEmpty(txtSenha.Text))
            {
                erro = "Preencha o campo Senha";
            }
            else if (txtSenha.Text.Length < 8)
            {
                erro = "Senha inválida";
            }
            return erro;
        }

        private void limpaCampos()
        {
            foreach (Control c in this.Controls)
            {
                if (c is TextBox || c is MaskedTextBox)
                {
                    c.Text = "";
                }
            }
        }

        private void btnCadastrarAdministrador_Click(object sender, EventArgs e)
        {
            if (grpAdministrador.Visible == true)
            {
                grpAdministrador.Hide();
                btnVoltar.Show();
                limpaCampos();
            }
            else if (ValidaCampos() != "")
            {
                MessageBox.Show(ValidaCampos(), "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var adm = new Administrador
                {
                    email = txtEmail.Text,
                    senha = txtSenha.Text

                };
               // MessageBox.Show(administradorBLL. AdicionarAdministrador(adm));
                listarAdministrador();
                btnVoltar.Hide();
                grpAdministrador.Show();
            }
        }

        private void grpAdministrador_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void FrmAdministrador_Load(object sender, EventArgs e)
        {

        }

        private void grpAdministrador_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (grpAdministrador.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in grpAdministrador.SelectedRows)
                {

                    txtEmail.Text = row.Cells[6].Value.ToString();
                    txtSenha.Text = row.Cells[7].Value.ToString();
                }
                grpAdministrador.Hide();
                btnCadastrarAdministrador.Hide();
                btnEditarAdministrador.Show();
                btnVoltar.Show();
            }
        }

        private void btnBusca_Click(object sender, EventArgs e)
        {

        }

        private void btnVoltar_Click_1(object sender, EventArgs e)
        {
            grpAdministrador.Show();
            btnCadastrarAdministrador.Show();
            btnVoltar.Hide();
        }

        private void btnFecharTela_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            FrmMenu menu = new FrmMenu();
            menu.ShowDialog();
            this.Close();

        }
    }
}