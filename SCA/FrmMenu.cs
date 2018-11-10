using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FittSistema.View
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login telaLogin = new Login();
            telaLogin.ShowDialog();

            this.Close();
        }

        private void btnAlunosMatriculados_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmAlunos alunosM = new FrmAlunos();
            alunosM.ShowDialog();
            this.Close();

        }

        private void btnAnamneses_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmAnamneses anam = new FrmAnamneses();
            anam.ShowDialog();
            this.Close();
        }

        private void btnMatricula_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmAdministrador adm = new FrmAdministrador();
            adm.ShowDialog();
            this.Close();
        }

        private void btnTurma_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmTurma turma = new FrmTurma();
            turma.ShowDialog();
            this.Close();
        }

        private void btnProfessor_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmProfessor professor = new FrmProfessor();
            professor.ShowDialog();
            this.Close();
        }

        private void btnPagamento_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmPagamentos pag = new FrmPagamentos();
            pag.ShowDialog();
            this.Close();
        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {

        }

        private void btnAnamnese_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmAnamneses anamnese = new FrmAnamneses();
            anamnese.ShowDialog();
            this.Close();
        }
    }
}
