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
        public FrmMatricula()
        {
            InitializeComponent();
        }

        TurmaBLL turmaBLL = new TurmaBLL();
        AlunoBLL alunoBLL = new AlunoBLL();
        MatriculaBLL matriculaBLL = new MatriculaBLL();

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

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private bool ValidarCampos()
        {
            return true;
        }

        private void cmbSemana1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbTurma1.SelectedIndex = -1;
            cmbTurma1.DataSource = turmaBLL.LerTurma(cmbSemana1.SelectedItem.ToString());
            cmbTurma1.ValueMember = "idTurma";
            cmbTurma1.SelectedValue = "idTurma";
            cmbTurma1.DisplayMember = "Horario";
        }

        private void cmbSemana2_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbTurma2.SelectedIndex = -1;
            cmbTurma2.DataSource = turmaBLL.LerTurma(cmbSemana2.SelectedItem.ToString());
            cmbTurma2.ValueMember = "idTurma";
            cmbTurma2.SelectedValue = "idTurma";
            cmbTurma2.DisplayMember = "Horario";
        }

        private void cmbSemana3_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbTurma3.SelectedIndex = -1;
            cmbTurma3.DataSource = turmaBLL.LerTurma(cmbSemana3.SelectedItem.ToString());
            cmbTurma3.ValueMember = "idTurma";
            cmbTurma3.SelectedValue = "idTurma";
            cmbTurma3.DisplayMember = "Horario";
        }

        private void btnCadastrarProfessor_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos())
            {
                return;
            }

            var aluno = new Aluno
            {
                CPF = maskCPF.Text,
                Nome = txtNome.Text,
                Endereco = txtEndereco.Text,
                Telefone = maskCel.Text,
                DataNasc = DateTime.ParseExact(maskDataNasc.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture),
                Sexo = cmbSexo.SelectedItem.ToString(),
                Email = txtEmail.Text
            };
            MessageBox.Show(aluno.CPF.ToString());
            MessageBox.Show(aluno.Telefone.ToString());
            MessageBox.Show(alunoBLL.AdicionarAluno(aluno));
        }
    }
}
