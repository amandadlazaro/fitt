﻿using DAL;
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

        #region Functions

        private void listarAlunos()
        {
            var alunos = alunoBLL.LerAlunosMini();
            grpAlunos.DataSource = alunos.ToList();
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
            string cpf = grpAlunos.CurrentRow.Cells["CPF"].Value.ToString();
            string nome = grpAlunos.CurrentRow.Cells["Nome"].Value.ToString();

            grpAlunos.DataSource = alunoBLL.ProcurarAluno(cpf);
            AlunosMatriculadosBLL.CPF = grpAlunos.CurrentRow.Cells["CPF"].Value.ToString();
            AlunosMatriculadosBLL.Nome = grpAlunos.CurrentRow.Cells["Nome"].Value.ToString();
            grpAlunos.DataSource = matriculaBLL.ProcurarMatricula(cpf);

            DialogResult Confirmacao = MessageBox.Show("Voce quer mesmo editar " + nome, "Confirmar Escolha", MessageBoxButtons.YesNo);
            if (Confirmacao == DialogResult.No)
            {
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
