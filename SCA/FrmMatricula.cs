using System;
using System.Globalization;
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
using System.Diagnostics;

namespace FittSistema.View
{
    public partial class FrmMatricula : Form
    {
        public FrmMatricula(bool editar = false)
        {
            InitializeComponent();

            AtualizarValorMensal();
            if(editar)
            {
                ModoEditar();
            }
        }

        #region BLLs

        TurmaBLL turmaBLL = new TurmaBLL();
        AlunoBLL alunoBLL = new AlunoBLL();
        MatriculaBLL matriculaBLL = new MatriculaBLL();

        #endregion

        #region DALs

        Aluno aluno;
        Matricula matricula;

        #endregion

        #region CheckBoxes

        private void rbAula1_CheckedChanged(object sender, EventArgs e)
        {
            cmbSemana2.Enabled = false;
            cmbTurma2.Enabled = false;
            cmbSemana3.Enabled = false;
            cmbTurma3.Enabled = false;
            cmbSemana2.SelectedIndex = -1;
            cmbTurma2.SelectedIndex = -1;
            cmbSemana3.SelectedIndex = -1;
            cmbTurma3.SelectedIndex = -1;
            AtualizarValorMensal();
        }

        private void rbAula2_CheckedChanged(object sender, EventArgs e)
        {
            cmbSemana2.Enabled = true;
            cmbTurma2.Enabled = true;
            cmbSemana3.Enabled = false;
            cmbTurma3.Enabled = false;
            cmbSemana3.SelectedIndex = -1;
            cmbTurma3.SelectedIndex = -1;
            AtualizarValorMensal();
        }

        private void rbAula3_CheckedChanged(object sender, EventArgs e)
        {
            cmbSemana2.Enabled = true;
            cmbTurma2.Enabled = true;
            cmbSemana3.Enabled = true;
            cmbTurma3.Enabled = true;
            AtualizarValorMensal();
        }

        private void Tipos_CheckedChanged(object sender, EventArgs e)
        {
            AtualizarValorMensal();
        }

        #endregion

        #region ComboBoxes

        private void cmbSemana1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbTurma1.SelectedIndex = -1;
            try
            {
                cmbTurma1.DataSource = turmaBLL.LerTurma(cmbSemana1.SelectedItem.ToString());
                cmbTurma1.ValueMember = "idTurma";
                cmbTurma1.SelectedValue = "idTurma";
                cmbTurma1.DisplayMember = "Horario";
            }
            catch
            {
                cmbTurma1.DataSource = null;
            }
        }

        private void cmbSemana2_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbTurma2.SelectedIndex = -1;
            try
            {
                cmbTurma2.DataSource = turmaBLL.LerTurma(cmbSemana2.SelectedItem.ToString());
                cmbTurma2.ValueMember = "idTurma";
                cmbTurma2.SelectedValue = "idTurma";
                cmbTurma2.DisplayMember = "Horario";
            }
            catch
            {
                cmbTurma2.DataSource = null;
            }
        }

        private void cmbSemana3_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbTurma3.SelectedIndex = -1;
            try
            {
                cmbTurma3.DataSource = turmaBLL.LerTurma(cmbSemana3.SelectedItem.ToString());
                cmbTurma3.ValueMember = "idTurma";
                cmbTurma3.SelectedValue = "idTurma";
                cmbTurma3.DisplayMember = "Horario";
            }
            catch
            {
                cmbTurma3.DataSource = null;
            }
        }

        #endregion

        #region Functions

        private bool ValidarCampos()
        {
            if (string.IsNullOrEmpty(txtNome.Text) || string.IsNullOrEmpty(maskDataNasc.Text) || string.IsNullOrEmpty(maskCel.Text) ||
                string.IsNullOrEmpty(txtEmail.Text) || string.IsNullOrEmpty(maskCPF.Text) || string.IsNullOrEmpty(maskDataInicial.Text) ||
                string.IsNullOrEmpty(maskDataFinal.Text) || string.IsNullOrEmpty(txtEndereco.Text))
            {
                MessageBox.Show("Preencha todos os campos!");
                return false;
            }

            if (cmbSexo.SelectedIndex.Equals(-1))
            {
                MessageBox.Show("Preencha todos os campos!");
                return false;
            }

            if (!Util.Util.validarEmail(txtEmail.Text))
            {
                MessageBox.Show("Email Inválido");
                return false;
            }

            if (rbAula1.Checked)
            {
                if (cmbSemana1.SelectedIndex.Equals(-1) || cmbTurma1.SelectedIndex.Equals(-1))
                {
                    MessageBox.Show("Preencha todos os campos!");
                    return false;
                }
            }

            if (rbAula2.Checked)
            {
                if (cmbSemana1.SelectedIndex.Equals(-1) || cmbTurma1.SelectedIndex.Equals(-1) ||
                    cmbSemana2.SelectedIndex.Equals(-1) || cmbTurma2.SelectedIndex.Equals(-1))
                {
                    MessageBox.Show("Preencha todos os campos!");
                    return false;
                }
            }

            if (rbAula3.Checked)
            {
                if (cmbSemana1.SelectedIndex.Equals(-1) || cmbTurma1.SelectedIndex.Equals(-1) ||
                    cmbSemana2.SelectedIndex.Equals(-1) || cmbTurma2.SelectedIndex.Equals(-1) ||
                    cmbSemana3.SelectedIndex.Equals(-1) || cmbTurma3.SelectedIndex.Equals(-1))
                {
                    MessageBox.Show("Preencha todos os campos!");
                    return false;
                }
            }
            return true;
        }

        private void AtualizarValorMensal()
        {
            if (rbAula1.Checked)
            {
                switch (DevolveTipo())
                {
                    case ("Mensal"):
                        txtValorMensal.Text = "200,00";
                        break;

                    case ("Trimestral"):
                        txtValorMensal.Text = "180,00";
                        break;

                    case ("Semestral"):
                        txtValorMensal.Text = "160,00";
                        break;

                    case ("Anual"):
                        txtValorMensal.Text = "140,00";
                        break;

                    default:
                        break;
                }
            }

            if (rbAula2.Checked)
            {
                switch (DevolveTipo())
                {
                    case ("Mensal"):
                        txtValorMensal.Text = "360,00";
                        break;

                    case ("Trimestral"):
                        txtValorMensal.Text = "320,00";
                        break;

                    case ("Semestral"):
                        txtValorMensal.Text = "280,00";
                        break;

                    case ("Anual"):
                        txtValorMensal.Text = "240,00";
                        break;

                    default:
                        break;
                }
            }

            if (rbAula3.Checked)
            {
                switch (DevolveTipo())
                {
                    case ("Mensal"):
                        txtValorMensal.Text = "480,00";
                        break;

                    case ("Trimestral"):
                        txtValorMensal.Text = "420,00";
                        break;

                    case ("Semestral"):
                        txtValorMensal.Text = "360,00";
                        break;

                    case ("Anual"):
                        txtValorMensal.Text = "300,00";
                        break;

                    default:
                        break;
                }
            }
        }

        private int DevolveAula()
        {
            if (rbAula1.Checked)
            {
                return 1;
            }
            if (rbAula2.Checked)
            {
                return 2;
            }
            if (rbAula3.Checked)
            {
                return 3;
            }
            return -1;
        }

        private string DevolveTipo()
        {
            if (rbMensal.Checked)
            {
                return "Mensal";
            }
            if (rbTrimestral.Checked)
            {
                return "Trimestral";
            }
            if (rbSemestral.Checked)
            {
                return "Semestral";
            }
            if (rbAnual.Checked)
            {
                return "Anual";
            }
            return "erro";
        }

        private void ModoEditar()
        {
            btnCadastrar.Visible = false;
            btnSalvar.Visible = true;
            btnExcluir.Visible = true;
            maskCPF.Enabled = false;

            maskCPF.Text = AlunosMatriculadosBLL.CPF;
            txtNome.Text = AlunosMatriculadosBLL.Nome;
            txtEndereco.Text = AlunosMatriculadosBLL.Endereco;
            maskCel.Text = AlunosMatriculadosBLL.Telefone;
            maskDataNasc.Text = AlunosMatriculadosBLL.DataNasc;
            cmbSexo.Text = AlunosMatriculadosBLL.Sexo;
            txtEmail.Text = AlunosMatriculadosBLL.Email;
            cbStatus.Checked = AlunosMatriculadosBLL.SituacaoMatricula;

            maskDataInicial.Text = AlunosMatriculadosBLL.DataInicio;
            maskDataFinal.Text = AlunosMatriculadosBLL.DataFim;
            switch (AlunosMatriculadosBLL.TipoPlano)
            {
                case ("Mensal"):
                    rbMensal.Checked = true;
                    break;
                case ("Semestral"):
                    rbSemestral.Checked = true;
                    break;
                case ("Trimestral"):
                    rbTrimestral.Checked = true;
                    break;
                case ("Anual"):
                    rbAnual.Checked = true;
                    break;
                default:
                    MessageBox.Show("Erro no Tipo de plano");
                    break;
            }
            switch (AlunosMatriculadosBLL.QtdeAulas)
            {
                case ("1"):
                    rbAula1.Checked = true;
                    cmbSemana1.Text = AlunosMatriculadosBLL.diaSemana1;
                    cmbTurma1.Text = AlunosMatriculadosBLL.horario1;
                    break;
                case ("2"):
                    rbAula2.Checked = true;
                    cmbSemana1.Text = AlunosMatriculadosBLL.diaSemana1;
                    cmbTurma1.Text = AlunosMatriculadosBLL.horario1;
                    cmbSemana2.Text = AlunosMatriculadosBLL.diaSemana2;
                    cmbTurma2.Text = AlunosMatriculadosBLL.horario2;
                    break;
                case ("3"):
                    rbAula3.Checked = true;
                    cmbSemana1.Text = AlunosMatriculadosBLL.diaSemana1;
                    cmbTurma1.Text = AlunosMatriculadosBLL.horario1;
                    cmbSemana2.Text = AlunosMatriculadosBLL.diaSemana2;
                    cmbTurma2.Text = AlunosMatriculadosBLL.horario2;
                    cmbSemana3.Text = AlunosMatriculadosBLL.diaSemana3;
                    cmbTurma3.Text = AlunosMatriculadosBLL.horario3;
                    break;
                default:
                    MessageBox.Show("Erro na Quantidade de Aulas");
                    break;
            }
        }

        #endregion

        #region FiltrarTeclas

        private void FiltrarLetraMaiuscula(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Util.FiltrarTeclas.letraMaiuscula(e.KeyChar);
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

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos())
            {
                return;
            }

            DialogResult Confirmacao = MessageBox.Show("Você quer mesmo salvar essas alterações ?", "Alterar Matricula", MessageBoxButtons.YesNo);
            if (Confirmacao == DialogResult.No)
            {
                return;
            }

            try
            {
                int? turmaDois = null;
                if (DevolveAula() >= 2)
                {
                    turmaDois = Int32.Parse(cmbTurma2.SelectedValue.ToString());
                }
                int? turmaTres = null;
                if (DevolveAula() == 3)
                {
                    turmaTres = Int32.Parse(cmbTurma3.SelectedValue.ToString());
                }
                matricula = new Matricula
                {
                    idMatricula = AlunosMatriculadosBLL.idMatricula,
                    CPF = maskCPF.Text,
                    idTurma = Int32.Parse(cmbTurma1.SelectedValue.ToString()),
                    TipoPlano = DevolveTipo(),
                    ValorMensal = double.Parse(txtValorMensal.Text),
                    DataInicio = maskDataInicial.Value,
                    DataFim = maskDataFinal.Value,
                    SituacaoMatricula = cbStatus.Checked,
                    QtdeAulas = DevolveAula(),
                    idTurma2 = turmaDois,
                    idTurma3 = turmaTres,
                };
                aluno = new Aluno
                {
                    CPF = maskCPF.Text,
                    Nome = txtNome.Text,
                    Endereco = txtEndereco.Text,
                    Telefone = maskCel.Text,
                    DataNasc = maskDataNasc.Value,
                    Sexo = cmbSexo.SelectedItem.ToString(),
                    Email = txtEmail.Text
                };
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
                return;
            }

            string mensagemAlterarMatricula = matriculaBLL.Alterar(matricula);
            if (mensagemAlterarMatricula != "Matricula Alterada com Sucesso")
            {
                MessageBox.Show(mensagemAlterarMatricula);
                return;
            }

            string mensagemAlterarAluno = alunoBLL.AlterarAluno(aluno);
            if (mensagemAlterarAluno != "Aluno Alterado com Sucesso")
            {
                MessageBox.Show(mensagemAlterarAluno);
                return;
            }

            MessageBox.Show(mensagemAlterarAluno);
            btnFecharTela.PerformClick();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos())
            {
                return;
            }
            
            try
            {
                int? turmaDois = null;
                if (DevolveAula() >= 2)
                {
                    turmaDois = Int32.Parse(cmbTurma2.SelectedValue.ToString());
                }
                int? turmaTres = null;
                if (DevolveAula() == 3)
                {
                    turmaTres = Int32.Parse(cmbTurma3.SelectedValue.ToString());
                }

                aluno = new Aluno
                {
                    CPF = maskCPF.Text,
                    Nome = txtNome.Text,
                    Endereco = txtEndereco.Text,
                    Telefone = maskCel.Text,
                    DataNasc = maskDataNasc.Value,
                    Sexo = cmbSexo.SelectedItem.ToString(),
                    Email = txtEmail.Text
                };
                matricula = new Matricula
                {
                    CPF = maskCPF.Text,
                    idTurma = Int32.Parse(cmbTurma1.SelectedValue.ToString()),
                    idTurma2 = turmaDois,
                    idTurma3 = turmaTres,
                    TipoPlano = DevolveTipo(),
                    ValorMensal = double.Parse(txtValorMensal.Text),
                    DataInicio = maskDataInicial.Value,
                    DataFim = maskDataFinal.Value,
                    SituacaoMatricula = cbStatus.Checked,
                    QtdeAulas = DevolveAula()
                };
            }
            catch(Exception err)
            {
                MessageBox.Show(err.ToString());
                return;
            }

            var mensagemAluno = alunoBLL.AdicionarAluno(aluno);
            if (mensagemAluno != "Aluno Cadastrado com Sucesso")
            {
                // MessageBox.Show(mensagemAluno);
                MessageBox.Show("Já existe um aluno com esse CPF");
                alunoBLL = new AlunoBLL();
                return;
            }

            var mensagemMatricula = matriculaBLL.Adicionar(matricula);
            if (mensagemMatricula != "Matricula Cadastrada com Sucesso")
            {
                alunoBLL.DeletarAluno(aluno);
                alunoBLL = new AlunoBLL();
                matriculaBLL = new MatriculaBLL();
                MessageBox.Show(mensagemMatricula);
                return;
            }

            MessageBox.Show(mensagemMatricula);
            btnFecharTela.PerformClick();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            DialogResult Confirmacao = MessageBox.Show("Voce quer mesmo excluir essa Matricula ?", "Excluir Matricula", MessageBoxButtons.YesNo);
            if (Confirmacao == DialogResult.No)
            {
                return;
            }

            string mensagemDeletarMatricula = matriculaBLL.Deletar(AlunosMatriculadosBLL.idMatricula);
            if (mensagemDeletarMatricula != "Matricula Deletada com Sucesso")
            {
                MessageBox.Show(mensagemDeletarMatricula);
                return;
            }

            string mensagemDeletarAluno = alunoBLL.DeletarAlunoCPF(AlunosMatriculadosBLL.CPF);
            if (mensagemDeletarAluno != "Aluno Deletado com Sucesso")
            {
                // Isso nao deve acontecer
                MessageBox.Show(mensagemDeletarAluno);
                return;
            }

            MessageBox.Show(mensagemDeletarAluno);
            btnFecharTela.PerformClick();
        }

        #endregion

    }
}
