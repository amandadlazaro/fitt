using DAL;
using SCA_BLL;
using System;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace FittSistema.View
{
    public partial class FrmAlunos : Form
    {
        public FrmAlunos()
        {
            InitializeComponent();
        }
        AlunoBLL alunoBLL = new AlunoBLL();

        private void AlunosMatriculados_Load(object sender, EventArgs e)
        {
            cmbSexo.Items.Add("Feminino");
            cmbSexo.Items.Add("Masculino");

            cmbEstCivil.Items.Add("Solteiro");
            cmbEstCivil.Items.Add("Casado");
            cmbEstCivil.Items.Add("Viúvo");
            cmbEstCivil.Items.Add("Divorciado");

            listarAlunos();
        }

        private void btnFecharTela_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            FrmMenu menu = new FrmMenu();
            menu.ShowDialog();
            this.Close();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            grpAlunos.Show();
            btnCadastrar.Show();
            btnEditar.Hide();
            btnExcluir.Hide();
            btnVoltar.Hide();
            btnMatricula.Hide();
            btnBuscar.Show();
            txtBusca.Show();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Alterar esses dados?", "Alterar Aluno", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (ValidaCampos() != "")
                {
                    MessageBox.Show(ValidaCampos(), "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    var aluno = new Aluno
                    {
                        CPF = txtCPF.Text,
                        Nome = txtNome.Text,
                        Endereco = txtEnd.Text,
                        Telefone = txtTel.Text,
                        DataNasc = DateTime.ParseExact(txtDtNasc.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture),
                        EstCivil = cmbEstCivil.SelectedItem.ToString(),
                        NumFilhos = Convert.ToInt32(txtNumFilhos.Value),
                        Sexo = cmbSexo.SelectedItem.ToString(),
                        Altura = Convert.ToDouble(txtAltura.Text),
                        Email = txtEmail.Text
                    };
                    MessageBox.Show(alunoBLL.AlterarAluno(aluno));
                    listarAlunos();
                    grpAlunos.Show();
                    btnCadastrar.Show();
                    btnEditar.Hide();
                    btnExcluir.Hide();
                    btnVoltar.Hide();
                }
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (grpAlunos.Visible == true)
            {
                grpAlunos.Hide();
                btnVoltar.Show();
                btnMatricula.Show();
                btnCadastrar.Hide();
                btnBuscar.Hide();
                txtBusca.Hide();
                limpaCampos();
            }
           
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Deletar esses dados?", "Deletar Aluno", MessageBoxButtons.YesNo) == DialogResult.Yes)

            {
                if (string.IsNullOrEmpty(txtCPF.Text))
                {
                    MessageBox.Show("Preencha o campo CPF", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    var aluno = new Aluno
                    {
                        CPF = txtCPF.Text
                    };
                    MessageBox.Show(alunoBLL.DeletarAluno(aluno));
                    listarAlunos();
                    grpAlunos.Show();
                    btnCadastrar.Show();
                    btnEditar.Hide();
                    btnExcluir.Hide();
                    btnVoltar.Hide();
                }
            }
        }

        private void listarAlunos()
        {
            var alunos = alunoBLL.LerAlunos();
            grpAlunos.DataSource = alunos.ToList();
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
            else if (string.IsNullOrEmpty(txtEnd.Text))
            {
                erro = "Preencha o campo Endereço";
            }

            else if (string.IsNullOrEmpty(txtTel.Text))
            {
                erro = "Preencha o campo Telefone";
            }
            else if (!Util.Util.validarTelefone(txtTel.Text))
            {
                erro = "Telefone inválido";
            }
            else if (txtDtNasc.Text.Length != 10)
            {
                erro = "Data inválida";
            }
            else if (cmbEstCivil.SelectedIndex == -1)
            {
                erro = "Selecione um Estado Civil";
            }
            else if (cmbSexo.SelectedIndex == -1)
            {
                erro = "Selecione um Sexo";
            }
            else if (string.IsNullOrEmpty(txtAltura.Text))
            {
                erro = "Preencha o campo Altura";
            }
            else if (string.IsNullOrEmpty(txtEmail.Text))
            {
                erro = "Preencha o campo E-mail";
            }
            else if (!Util.Util.validarEmail(txtEmail.Text))
            {
                erro = "E-mail inválido";
            }
            return erro;
        }

        private void limpaCampos()
        {
            foreach (Control c in this.Controls)
            {
                if (c is TextBox || c is MaskedTextBox || c is NumericUpDown)
                {
                    c.Text = "";
                }
            }
        }

 
        private void grpAlunos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            if (grpAlunos.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in grpAlunos.SelectedRows)
                {
                    txtCPF.Text = row.Cells[0].Value.ToString();
                    txtNome.Text = row.Cells[1].Value.ToString();
                    txtEnd.Text = row.Cells[2].Value.ToString();
                    txtTel.Text = row.Cells[3].Value.ToString();
                    txtDtNasc.Text = row.Cells[4].Value.ToString();
                    cmbEstCivil.SelectedItem = row.Cells[5].Value.ToString();
                    txtNumFilhos.Value = Convert.ToDecimal(row.Cells[6].Value);
                    cmbSexo.SelectedItem = row.Cells[7].Value.ToString();
                    txtAltura.Text = row.Cells[8].Value.ToString();
                    txtEmail.Text = row.Cells[9].Value.ToString();
                }
                grpAlunos.Hide();
                btnCadastrar.Hide();
                btnEditar.Show();
                btnExcluir.Show();
                btnVoltar.Show();
                btnBuscar.Hide();
                txtBusca.Hide();
            }
        }

        private void btnMatricula_Click(object sender, EventArgs e)
        {
            if (ValidaCampos() != "")
            {
                MessageBox.Show(ValidaCampos(), "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var aluno = new Aluno
                {
                    CPF = txtCPF.Text,
                    Nome = txtNome.Text,
                    Endereco = txtEnd.Text,
                    Telefone = txtTel.Text,
                    DataNasc = DateTime.ParseExact(txtDtNasc.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    EstCivil = cmbEstCivil.SelectedItem.ToString(),
                    NumFilhos = Convert.ToInt32(txtNumFilhos.Value),
                    Sexo = cmbSexo.SelectedItem.ToString(),
                    Altura = Convert.ToDouble(txtAltura.Text),
                    Email = txtEmail.Text
                };
                MessageBox.Show(alunoBLL.AdicionarAluno(aluno));
                this.Hide();
                FrmMatricula matricula = new FrmMatricula();
                matricula.ShowDialog();
                this.Close();
            }

        }

        private void grpAlunos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
