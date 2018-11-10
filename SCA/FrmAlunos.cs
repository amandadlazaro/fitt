using DAL;
using SCA_BLL;
using System;
using System.ComponentModel;
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
        MatriculaBLL matriculaBLL = new MatriculaBLL();
        TurmaBLL turmaBLL = new TurmaBLL();

        #region Functions

        private void listarAlunos()
        {
            grpAlunos.DataSource = matriculaBLL.LerAlunosMatriculados();
        }

        #endregion

        #region Form

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
            btnVoltar.Hide();
            btnCadastrar.Hide();
            btnBuscar.Show();
            txtBusca.Show();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmMatricula frmMatricula = new FrmMatricula();
            frmMatricula.ShowDialog();
            this.Close();
        }


        private void btnBuscar_Click(object sender, EventArgs e)
        {
            var alunos = alunoBLL.LerAlunosPorNome(txtBusca.Text);
            if (!alunos.Any()) MessageBox.Show("Nenhum aluno encontrado");
            else grpAlunos.DataSource = alunos.ToList();
        }

        private void FrmAlunos_Load(object sender, EventArgs e)
        {
            listarAlunos();
        }

        private void grpAlunos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (grpAlunos.Rows.Count <= 0)
            {
                return;
            }

            string cpf = grpAlunos.CurrentRow.Cells["CPF"].Value.ToString();
            string nome = grpAlunos.CurrentRow.Cells["Nome"].Value.ToString();

            DialogResult Confirmacao = MessageBox.Show("Voce quer mesmo editar " + nome, "Confirmar Escolha", MessageBoxButtons.YesNo);
            if (Confirmacao == DialogResult.No)
            {
                return;
            }

            try
            {
                grpAlunos.DataSource = alunoBLL.ProcurarAluno(cpf);
                AlunosMatriculadosBLL.CPF = grpAlunos.CurrentRow.Cells["CPF"].Value.ToString();
                AlunosMatriculadosBLL.Nome = grpAlunos.CurrentRow.Cells["Nome"].Value.ToString();
                AlunosMatriculadosBLL.Endereco = grpAlunos.CurrentRow.Cells["Endereco"].Value.ToString();
                AlunosMatriculadosBLL.Telefone = grpAlunos.CurrentRow.Cells["Telefone"].Value.ToString();
                AlunosMatriculadosBLL.DataNasc = grpAlunos.CurrentRow.Cells["DataNasc"].Value.ToString();
                AlunosMatriculadosBLL.Sexo = grpAlunos.CurrentRow.Cells["Sexo"].Value.ToString();
                AlunosMatriculadosBLL.Email = grpAlunos.CurrentRow.Cells["Email"].Value.ToString();

                grpAlunos.DataSource = matriculaBLL.ProcurarMatricula(cpf);
                AlunosMatriculadosBLL.idMatricula = Int32.Parse(grpAlunos.CurrentRow.Cells["idMatricula"].Value.ToString());
                AlunosMatriculadosBLL.idTurma = Int32.Parse(grpAlunos.CurrentRow.Cells["idTurma"].Value.ToString());
                AlunosMatriculadosBLL.TipoPlano = grpAlunos.CurrentRow.Cells["TipoPlano"].Value.ToString();
                AlunosMatriculadosBLL.ValorMensal = grpAlunos.CurrentRow.Cells["ValorMensal"].Value.ToString();
                AlunosMatriculadosBLL.DataInicio = grpAlunos.CurrentRow.Cells["DataInicio"].Value.ToString();
                AlunosMatriculadosBLL.DataFim = grpAlunos.CurrentRow.Cells["DataFim"].Value.ToString();
                AlunosMatriculadosBLL.SituacaoMatricula = bool.Parse(grpAlunos.CurrentRow.Cells["SituacaoMatricula"].Value.ToString());
                AlunosMatriculadosBLL.QtdeAulas = grpAlunos.CurrentRow.Cells["QtdeAulas"].Value.ToString();

                switch (AlunosMatriculadosBLL.QtdeAulas)
                {
                    case ("1"):
                        grpAlunos.DataSource = turmaBLL.ProcurarTurma(AlunosMatriculadosBLL.idTurma);
                        AlunosMatriculadosBLL.diaSemana1 = grpAlunos.CurrentRow.Cells["DiaSemana"].Value.ToString();
                        AlunosMatriculadosBLL.horario1 = grpAlunos.CurrentRow.Cells["Horario"].Value.ToString();
                        break;
                    case ("2"):
                        AlunosMatriculadosBLL.idTurma2 = Int32.Parse(grpAlunos.CurrentRow.Cells["idTurma2"].Value.ToString());
                        grpAlunos.DataSource = turmaBLL.ProcurarTurma(AlunosMatriculadosBLL.idTurma);
                        AlunosMatriculadosBLL.diaSemana1 = grpAlunos.CurrentRow.Cells["DiaSemana"].Value.ToString();
                        AlunosMatriculadosBLL.horario1 = grpAlunos.CurrentRow.Cells["Horario"].Value.ToString();
                        grpAlunos.DataSource = turmaBLL.ProcurarTurma(AlunosMatriculadosBLL.idTurma2);
                        AlunosMatriculadosBLL.diaSemana2 = grpAlunos.CurrentRow.Cells["DiaSemana"].Value.ToString();
                        AlunosMatriculadosBLL.horario2 = grpAlunos.CurrentRow.Cells["Horario"].Value.ToString();
                        break;
                    case ("3"):
                        AlunosMatriculadosBLL.idTurma2 = Int32.Parse(grpAlunos.CurrentRow.Cells["idTurma2"].Value.ToString());
                        AlunosMatriculadosBLL.idTurma3 = Int32.Parse(grpAlunos.CurrentRow.Cells["idTurma3"].Value.ToString());
                        grpAlunos.DataSource = turmaBLL.ProcurarTurma(AlunosMatriculadosBLL.idTurma);
                        AlunosMatriculadosBLL.diaSemana1 = grpAlunos.CurrentRow.Cells["DiaSemana"].Value.ToString();
                        AlunosMatriculadosBLL.horario1 = grpAlunos.CurrentRow.Cells["Horario"].Value.ToString();
                        grpAlunos.DataSource = turmaBLL.ProcurarTurma(AlunosMatriculadosBLL.idTurma2);
                        AlunosMatriculadosBLL.diaSemana2 = grpAlunos.CurrentRow.Cells["DiaSemana"].Value.ToString();
                        AlunosMatriculadosBLL.horario2 = grpAlunos.CurrentRow.Cells["Horario"].Value.ToString();
                        grpAlunos.DataSource = turmaBLL.ProcurarTurma(AlunosMatriculadosBLL.idTurma3);
                        AlunosMatriculadosBLL.diaSemana3 = grpAlunos.CurrentRow.Cells["DiaSemana"].Value.ToString();
                        AlunosMatriculadosBLL.horario3 = grpAlunos.CurrentRow.Cells["Horario"].Value.ToString();
                        break;
                    default:
                        return;
                }
            }
            catch
            {
                listarAlunos();
                MessageBox.Show("Ocorreu um erro no formato do registro do aluno");
                return;
            }

            this.Hide();
            FrmMatricula frmMatricula = new FrmMatricula(true);
            frmMatricula.ShowDialog();
            this.Close();
        }

        #endregion
    }
}
