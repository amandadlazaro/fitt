using DAL;
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
        AnamneseBLL anamneseBLL = new AnamneseBLL();

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
            btnCadastrarAnamnese.Hide();
            btnEditarAnamnese.Show();
            btnExcluirAnamnese.Show();
        }

        private void btnCadastrarAnamnese_Click(object sender, EventArgs e)
        {
            if (grpAlunos.Visible == true)
            {
                grpAlunos.Hide();
                btnVoltar.Show();
                limpaCampos();
            }
            else
            {
                var anamnese = new Anamnese
                {
                    QP = txtQP.Text,
                    HM = txtHM.Text,
                    Esporte =txtEsporte.Text,
                    PosicaoQueDorme = txtPosicao.Text,
                    Humor = txtHumor.Text,
                    Dor = txtDor.Text,
                    DescricaoDor = txtDescricao.Text,
                    DiagnosticoMedico = txtDiagnostico.Text,
                    Medicacao = txtMedicacao.Text,
                    Patologias = txtPatologias.Text
                };
                MessageBox.Show(anamneseBLL.AdicionarAnamnese(anamnese));
                listarAlunos();
                btnVoltar.Hide();
                grpAlunos.Show();
            }
        }

        private void btnEditarAnamnese_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Alterar esses dados?", "Alterar Anamnese", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                var anamnese = new Anamnese
                {
                    QP = txtQP.Text,
                    HM = txtHM.Text,
                    Esporte = txtEsporte.Text,
                    PosicaoQueDorme = txtPosicao.Text,
                    Humor = txtHumor.Text,
                    Dor = txtDor.Text,
                    DescricaoDor = txtDescricao.Text,
                    DiagnosticoMedico = txtDiagnostico.Text,
                    Medicacao = txtMedicacao.Text,
                    Patologias = txtPatologias.Text
                };
                MessageBox.Show(anamneseBLL.AlterarAnamnese(anamnese));
                listarAlunos();
                grpAlunos.Show();
                btnCadastrarAnamnese.Show();
                btnEditarAnamnese.Hide();
                btnExcluirAnamnese.Hide();
                btnVoltar.Hide();
            }
        }

        private void btnExcluirAnamese_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Deletar esses dados?", "Deletar Anamnese", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                //MessageBox.Show(anamneseBLL.DeletarAnamnese(prof));
                listarAlunos();
                grpAlunos.Show();
                btnCadastrarAnamnese.Show();
                btnEditarAnamnese.Hide();
                btnExcluirAnamnese.Hide();
                btnVoltar.Hide();
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            grpAlunos.Show();
            btnCadastrarAnamnese.Show();
            btnEditarAnamnese.Hide();
            btnExcluirAnamnese.Hide();
            btnVoltar.Hide();
        }
        
        private void listarAlunos()
        {
            var aluno = alunoBLL.LerAlunos();
            grpAlunos.DataSource = aluno.ToList();
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
    }
}

