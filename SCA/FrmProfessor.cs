using DAL;
using SCA_BLL;
using System;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace FittSistema.View
{
    public partial class FrmProfessor : Form
    {
        public FrmProfessor()
        {
            InitializeComponent();
        }

        ProfessorBLL professorBLL = new ProfessorBLL();

        private void btnFecharTela_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmMenu menu = new FrmMenu();
            menu.ShowDialog();
            this.Close();
        }

        private void btnCadastrarProfessor_Click(object sender, EventArgs e)
        {
            if (grpProfessores.Visible == true)
            {
                grpProfessores.Hide();
                btnVoltar.Show();
                limpaCampos();
            }
            else if (ValidaCampos() != "")
            {
                MessageBox.Show(ValidaCampos(), "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var prof = new Professor
                {
                    CPF = txtCPF.Text,
                    Nome = txtNome.Text,
                    Telefone = txtTel.Text,
                    Endereco = txtEnd.Text,
                    Sexo = cmbSexo.SelectedItem.ToString(),
                    DataNasc = DateTime.ParseExact(txtDtNasc.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture), 
                    Email = txtEmail.Text,
                    Senha = txtSenha.Text
                };
                MessageBox.Show(professorBLL.AdicionarProfessor(prof));
                listarProfessores();
                btnVoltar.Hide();
                grpProfessores.Show();
            }
        }

        private void btnEditarProfessor_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Alterar esses dados?", "Alterar Professor", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (ValidaCampos() != "")
                {
                    MessageBox.Show(ValidaCampos(), "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    var prof = new Professor
                    {
                        CPF = txtCPF.Text,
                        Nome = txtNome.Text,
                        Telefone = txtTel.Text,
                        Endereco = txtEnd.Text,
                        Sexo = cmbSexo.SelectedItem.ToString(),
                        DataNasc = DateTime.ParseExact(txtDtNasc.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture),
                        Email = txtEmail.Text,
                        Senha = txtSenha.Text
                    };
                    MessageBox.Show(professorBLL.AlterarProfessor(prof));
                    listarProfessores();
                    grpProfessores.Show();
                    btnCadastrarProfessor.Show();
                    btnEditarProfessor.Hide();
                    btnExcluirProfessor.Hide();
                    btnVoltar.Hide();
                }
            }
        }

        private void btnExcluirProfessor_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Deletar esses dados?", "Deletar Professor", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (string.IsNullOrEmpty(txtCPF.Text))
                {
                    MessageBox.Show("Preencha o campo CPF", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    var prof = new Professor
                    {
                        CPF = txtCPF.Text
                    };
                    MessageBox.Show(professorBLL.DeletarProfessor(prof));
                    listarProfessores();
                    grpProfessores.Show();
                    btnCadastrarProfessor.Show();
                    btnEditarProfessor.Hide();
                    btnExcluirProfessor.Hide();
                    btnVoltar.Hide();
                }
            }
        }

        private void grpProfessores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (grpProfessores.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in grpProfessores.SelectedRows)
                {
                    txtCPF.Text = row.Cells[0].Value.ToString();
                    txtNome.Text = row.Cells[1].Value.ToString();
                    txtTel.Text = row.Cells[2].Value.ToString();
                    txtEnd.Text = row.Cells[3].Value.ToString();
                    cmbSexo.SelectedItem = row.Cells[4].Value.ToString();
                    txtDtNasc.Text = row.Cells[5].Value.ToString();
                    txtEmail.Text = row.Cells[6].Value.ToString();
                    txtSenha.Text = row.Cells[7].Value.ToString();
                }
                grpProfessores.Hide();
                btnCadastrarProfessor.Hide();
                btnEditarProfessor.Show();
                btnExcluirProfessor.Show();
                btnVoltar.Show();
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            grpProfessores.Show();
            btnCadastrarProfessor.Show();
            btnEditarProfessor.Hide();
            btnExcluirProfessor.Hide();
            btnVoltar.Hide();
        }

        private void FrmProfessor_Load(object sender, EventArgs e)
        {
            cmbSexo.Items.Add("Feminino");
            cmbSexo.Items.Add("Masculino");
            listarProfessores();
        }

        private void listarProfessores()
        {
            var professores = professorBLL.LerProfessor();
            grpProfessores.DataSource = professores.ToList();
        }

        private string ValidaCampos()
        {
            string erro = "";
            if (string.IsNullOrEmpty(txtCPF.Text))
            {
                erro = "Preencha o campo CPF";
            }
            else if (!Util.Util.validarCPF(txtCPF.Text))
            {
                erro = "CPF inválido";
            }
            else if (string.IsNullOrEmpty(txtNome.Text))
            {
                erro = "Preencha o campo Nome";
            }
            else if (string.IsNullOrEmpty(txtTel.Text))
            {
                erro = "Preencha o campo Telefone";
            }
            else if (!Util.Util.validarTelefone(txtTel.Text))
            {
                erro = "Telefone inválido";
            }
            else if (string.IsNullOrEmpty(txtEnd.Text))
            {
                erro = "Preencha o campo Endereço";
            }
            else if (cmbSexo.SelectedIndex == -1)
            {
                erro = "Selecione um Sexo";
            }
            else if (string.IsNullOrEmpty(txtDtNasc.Text))
            {
                erro = "Preencha o campo Data de Nascimento";
            }
            else if (txtDtNasc.Text.Length != 10)
            {
                erro = "Data inválida";
            }
            else if (string.IsNullOrEmpty(txtEmail.Text))
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
            else if ( txtSenha.Text.Length < 8)
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

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            var professor = professorBLL.LerProfPorNome(txtBusca.Text);
            if (!professor.Any()) MessageBox.Show("Nenhum aluno encontrado");
            else grpProfessores.DataSource = professor.ToList();
        }
    }
}
