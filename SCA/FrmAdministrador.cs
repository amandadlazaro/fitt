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
using SCA;
using System.Globalization;


namespace FittSistema.View
{
    public partial class FrmAdministrador : Form
    {
        public FrmAdministrador()
        {
            InitializeComponent();
        }
        
        AdministradorBLL administradorBLL = new AdministradorBLL();
        AdministradorBLL.DadosAdministrador admdados = new AdministradorBLL.DadosAdministrador();
        Administrador adm = new Administrador();
        int ID;
        bool emailMudou = false;

        public int testaSenha(string senha)
        {
            FrmSenha frmSenha = new FrmSenha();
            DialogResult dialogResult = frmSenha.ShowDialog(this);

            if (dialogResult == DialogResult.OK)
            {
                string pass = frmSenha.Password;
                admdados.Senha = pass;
                pass = Util.Util.criptografarSenha(pass);

                if (pass == senha)
                    return 1;
                else
                    return 2;
            }
            else
                return 3;
        }

        private void FrmAdministrador_Load(object sender, EventArgs e)
        {
            listarAdministrador();
            grpAdministrador.Columns.RemoveAt(0);
        }

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
                    if (emailMudou)
                    {
                        grpAdministrador.DataSource = administradorBLL.ProcurarEmail(txtEmail.Text.ToString());
                        if (grpAdministrador.Rows.Count > 0)
                        {
                            grpAdministrador.DataSource = administradorBLL.ProcurarEmailcomID(txtEmail.Text.ToString(), ID);
                            if (!(grpAdministrador.Rows.Count > 0))
                            {
                                MessageBox.Show("Email já Cadastrado");
                                return;
                            }
                        }
                    }

                    adm = new Administrador
                    {
                        idAdm = ID,
                        email = txtEmail.Text,
                        senha = Util.Util.criptografarSenha(txtSenha.Text)

                    };
                    MessageBox.Show(administradorBLL.AlterarAdministrador(adm));
                    listarAdministrador();
                    grpAdministrador.Columns.RemoveAt(0);
                    grpAdministrador.Show();
                    btnCadastrarAdministrador.Show();
                    btnVoltar.Hide();
                    btnEditarAdministrador.Hide();
                    btnExcluirAdm.Hide();
                }
            }

        }

        private void listarAdministrador()
        {
            var administrador = administradorBLL.LerAdministradorSemSenha();
            grpAdministrador.DataSource = administrador.ToList();
            grpAdministrador.Columns.RemoveAt(2);
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
                grpAdministrador.DataSource = administradorBLL.ProcurarEmail(txtEmail.Text.ToString());
                if (grpAdministrador.Rows.Count > 0)
                {
                    MessageBox.Show("Email já Cadastrado");
                    return;
                }

                var adm = new Administrador
                {
                    email = txtEmail.Text,
                    senha = Util.Util.criptografarSenha(txtSenha.Text)

                };
                MessageBox.Show(administradorBLL.AdicionarAdministrador(adm));
                listarAdministrador();
                grpAdministrador.Columns.RemoveAt(0);
                btnVoltar.Hide();
                grpAdministrador.Show();
            }
        }

        private void grpAdministrador_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            grpAdministrador.DataSource = administradorBLL.ProcurarEmailComSenha(grpAdministrador.CurrentRow.Cells["Email"].Value.ToString());


            ID = int.Parse(grpAdministrador.CurrentRow.Cells["ID"].Value.ToString());
            

            string senha = grpAdministrador.CurrentRow.Cells["Senha"].Value.ToString();
            grpAdministrador.Columns.RemoveAt(2);
            grpAdministrador.Columns.RemoveAt(0);

            int result = testaSenha(senha);
            if (result == 2)
            {
                listarAdministrador();
                grpAdministrador.Columns.RemoveAt(0);
                MessageBox.Show("Senha incorreta");
                return;
            }
            else if (result == 3)
                return;

            if (grpAdministrador.Rows.Count > 0)
            {
                limpaCampos();
                admdados.Email = grpAdministrador.CurrentRow.Cells["Email"].Value.ToString();
                txtEmail.Text = admdados.Email;
                txtSenha.Text = admdados.Senha;

                grpAdministrador.Hide();
                btnCadastrarAdministrador.Hide();
                btnEditarAdministrador.Show();
                btnExcluirAdm.Show();
                btnVoltar.Show();
            }
        }

        private void btnVoltar_Click_1(object sender, EventArgs e)
        {
            listarAdministrador();
            grpAdministrador.Columns.RemoveAt(0);
            grpAdministrador.Show();
            btnCadastrarAdministrador.Show();
            btnVoltar.Hide();
            btnEditarAdministrador.Hide();
            btnExcluirAdm.Hide();
        }

        private void btnFecharTela_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            FrmMenu menu = new FrmMenu();
            menu.ShowDialog();
            this.Close();

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            emailMudou = true;
        }

        private void txtSenha_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void btnExcluirAdm_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Deletar esses dados?", "Deletar Administrador", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                grpAdministrador.DataSource = administradorBLL.LerAdministrador();
                if (grpAdministrador.Rows.Count == 1)
                {
                    MessageBox.Show("Não é possível excluir Administrador, pois só há um Administrador", "Erro ao deletar Administrador");
                    return;
                }
                if (ValidaCampos() != "")
                {
                    MessageBox.Show(ValidaCampos(), "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    adm = new Administrador
                    {
                        idAdm = ID,
                        email = txtEmail.Text,
                        senha = Util.Util.criptografarSenha(txtSenha.Text)
                    };

                    MessageBox.Show(administradorBLL.DeletarAdministrador(adm));
                    listarAdministrador();
                    grpAdministrador.Columns.RemoveAt(0);
                    grpAdministrador.Show();
                    btnCadastrarAdministrador.Show();
                    btnVoltar.Hide();
                    btnEditarAdministrador.Hide();
                    btnExcluirAdm.Hide();
                }
            }
        }
    }
}
