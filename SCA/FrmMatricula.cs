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
        public FrmMatricula(string cpf = "")
        {
            InitializeComponent();
            if(cpf != "")
            {
                ModoEditar(cpf);
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
        }

        private void rbAula2_CheckedChanged(object sender, EventArgs e)
        {
            cmbSemana2.Enabled = true;
            cmbTurma2.Enabled = true;
            cmbSemana3.Enabled = false;
            cmbTurma3.Enabled = false;
            cmbSemana3.SelectedIndex = -1;
            cmbTurma3.SelectedIndex = -1;
        }

        private void rbAula3_CheckedChanged(object sender, EventArgs e)
        {
            cmbSemana2.Enabled = true;
            cmbTurma2.Enabled = true;
            cmbSemana3.Enabled = true;
            cmbTurma3.Enabled = true;
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

            }
        }

        private string DevolveAula()
        {
            if (rbAula1.Checked)
            {
                return "1";
            }
            if (rbAula2.Checked)
            {
                return "2";
            }
            if (rbAula3.Checked)
            {
                return "3";
            }
            return "erro";
        }

        private string DevolveTipo()
        {
            if (rbMensal.Checked)
            {
                return "m";
            }
            if (rbTrimestral.Checked)
            {
                return "t";
            }
            if (rbSemestral.Checked)
            {
                return "s";
            }
            if (rbAnual.Checked)
            {
                return "a";
            }
            return "erro";
        }

        private void ModoEditar(string cpf)
        {
            btnCadastrar.Visible = false;
            btnSalvar.Visible = true;
            btnExcluir.Visible = true;
            maskCPF.Text = cpf;
            maskCPF.Enabled = false;
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

        }

        private void btnCadastrarProfessor_Click(object sender, EventArgs e) 
        {
            if (!ValidarCampos())
            {
                return;
            }

            aluno = new Aluno
            {
                CPF = maskCPF.Text,
                Nome = txtNome.Text,
                Endereco = txtEndereco.Text,
                Telefone = maskCel.Text,
                DataNasc = DateTime.ParseExact(maskDataNasc.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture),
                Sexo = cmbSexo.SelectedItem.ToString(),
                Email = txtEmail.Text
            }; 

            var mensagemAluno = alunoBLL.AdicionarAluno(aluno);
            if (mensagemAluno != "Aluno Cadastrado com Sucesso")
            {
                // MessageBox.Show(mensagemAluno);
                MessageBox.Show("Já existe um aluno com esse CPF");
                alunoBLL = new AlunoBLL();
                return;
            }

            matricula = new Matricula
            {
                CPF = maskCPF.Text,
                idTurma = Int32.Parse(cmbTurma1.SelectedValue.ToString()),
                TipoPlano = "Mensal",
                ValorMensal = 10.10,
                DataInicio = DateTime.ParseExact(maskDataInicial.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture),
                DataFim = DateTime.ParseExact(maskDataFinal.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture),
                SituacaoMatricula = true,
                QtdeAulas = 1
            };

            var mensagemMatricula = matriculaBLL.Adicionar(matricula);
            if (mensagemMatricula != "Matricula Cadastrada com Sucesso")
            {
                alunoBLL.DeletarAluno(aluno);
                alunoBLL = new AlunoBLL();
                matriculaBLL = new MatriculaBLL();
            }

            MessageBox.Show(mensagemMatricula);
        }

        #endregion
    }
}
