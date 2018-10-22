using SCA_BLL;
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
    public partial class FrmAnamneses : Form
    {
        public FrmAnamneses()
        {
            InitializeComponent();
        }
        AlunoBLL alunoBLL = new AlunoBLL();

        private void btnFecharForm_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmMenu menu = new FrmMenu();
            menu.ShowDialog();
            this.Close();
        }

        private void btnBuscarAnamnese_Click(object sender, EventArgs e)
        {
            var alunos = alunoBLL.LerAlunosPorNome(txtBusca.Text);
            if (!alunos.Any()) MessageBox.Show("Nenhum aluno encontrado");
            grpAlunos.DataSource = alunos.ToList();

        }

        private void FrmAnamneses_Load(object sender, EventArgs e)
        {
            var alunos = alunoBLL.LerAlunos();
            grpAlunos.DataSource = alunos.ToList();
        }

        private void grpAlunos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string cpf;
            foreach (DataGridViewRow row in grpAlunos.SelectedRows)
            {
                cpf = row.Cells[0].Value.ToString();
            }


            grpAlunos.Hide();
            btnCadastrarProfessor.Hide();
            btnEditarProfessor.Show();
            btnExcluirProfessor.Show();
        }
    }
}

