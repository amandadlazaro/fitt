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

        #region Globais

        AlunoBLL alunoBLL = new AlunoBLL();
        AnamneseBLL anamneseBLL = new AnamneseBLL();
        Anamnese anamnese = new Anamnese();
        MatriculaBLL matriculaBLL = new MatriculaBLL();
        MatriculaBLL.DadosMatricula matricula = new MatriculaBLL.DadosMatricula();
        String IDs;

        #endregion

        private void btnFecharForm_Click(object sender, EventArgs e)
        {
            if (LoginBLL.sessao == 1)
            {
                this.Hide();
                FrmMenu menu = new FrmMenu();
                menu.ShowDialog();
                this.Close();
            }
            else
            {
                this.Hide();
                FrmMenu2 menu = new FrmMenu2();
                menu.ShowDialog();
                this.Close();
            }
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
            IDs = grpAlunos.CurrentRow.Cells["CPF"].Value.ToString();

            grpAlunos.Hide();
            btnSalvar.Show();
            btnExcluirAnamnese.Show();
            btnVoltar.Show();
            limpaCampos();
            
            grpAlunos.DataSource = matriculaBLL.ProcurarMatricula(IDs);
            AlunosMatriculadosBLL.idMatricula = Int32.Parse(grpAlunos.CurrentRow.Cells["idMatricula"].Value.ToString());
            txtMatricula.Text = AlunosMatriculadosBLL.idMatricula.ToString();
                
            IDs = txtMatricula.Text;

            Procurar:
            grpAlunos.DataSource = anamneseBLL.ProcurarAnamnese(int.Parse(IDs));
            if (grpAlunos.Rows.Count > 0)
            {
                txtAnamnese.Text        =   grpAlunos.CurrentRow.Cells["idAnamnese"].Value.ToString();
                dtpDataAnamnese.Text    =   grpAlunos.CurrentRow.Cells["DtAnamnese"].Value.ToString();
                txtMatricula.Text       =   grpAlunos.CurrentRow.Cells["idMatricula"].Value.ToString();
                txtQP.Text              =   grpAlunos.CurrentRow.Cells["QP"].Value.ToString();
                txtHM.Text              =   grpAlunos.CurrentRow.Cells["HM"].Value.ToString();
                txtEsporte.Text         =   grpAlunos.CurrentRow.Cells["Esporte"].Value.ToString();
                txtPosicao.Text         =   grpAlunos.CurrentRow.Cells["PosicaoQueDorme"].Value.ToString();
                txtHumor.Text           =   grpAlunos.CurrentRow.Cells["Humor"].Value.ToString();
                txtDor.Text             =   grpAlunos.CurrentRow.Cells["Dor"].Value.ToString();
                txtDescricao.Text       =   grpAlunos.CurrentRow.Cells["DescricaoDor"].Value.ToString();
                txtDiagnostico.Text     =   grpAlunos.CurrentRow.Cells["DiagnosticoMedico"].Value.ToString();
                txtMedicacao.Text       =   grpAlunos.CurrentRow.Cells["Medicacao"].Value.ToString();
                txtPatologias.Text      =   grpAlunos.CurrentRow.Cells["Patologias"].Value.ToString();
            }
            else
            {
                anamnese = new Anamnese
                {
                    idMatricula         =   int.Parse(txtMatricula.Text),
                    DtAnamnese          =   DateTime.Parse(dtpDataAnamnese.Text),
                    QP                  =   txtQP.Text,
                    HM                  =   txtHM.Text,
                    Esporte             =   txtEsporte.Text,
                    PosicaoQueDorme     =   txtPosicao.Text,
                    Humor               =   txtHumor.Text,
                    Dor                 =   txtDor.Text,
                    DescricaoDor        =   txtDescricao.Text,
                    DiagnosticoMedico   =   txtDiagnostico.Text,
                    Medicacao           =   txtMedicacao.Text,
                    Patologias          =   txtPatologias.Text
                };

                anamneseBLL.AdicionarAnamnese(anamnese);

                goto Procurar;
            }

            
        }

        private void btnExcluirAnamese_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Deletar esses dados?", "Deletar Anamnese", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                anamnese = new Anamnese
                {
                    idAnamnese          =   int.Parse(txtAnamnese.Text),
                    idMatricula         =   int.Parse(txtMatricula.Text),
                    DtAnamnese          =   DateTime.Parse(dtpDataAnamnese.Text),
                    QP                  =   txtQP.Text,
                    HM                  =   txtHM.Text,
                    Esporte             =   txtEsporte.Text,
                    PosicaoQueDorme     =   txtPosicao.Text,
                    Humor               =   txtHumor.Text,
                    Dor                 =   txtDor.Text,
                    DescricaoDor        =   txtDescricao.Text,
                    DiagnosticoMedico   =   txtDiagnostico.Text,
                    Medicacao           =   txtMedicacao.Text,
                    Patologias          =   txtPatologias.Text
                };

                MessageBox.Show(anamneseBLL.DeletarAnamnese(anamnese));
                listarAlunos();
                btnVoltar.Hide();
                grpAlunos.Show();
                btnSalvar.Hide();
                btnExcluirAnamnese.Hide();
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            grpAlunos.Show();
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

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Salvar esses dados?", "Salvar Anamnese", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                anamnese = new Anamnese
                {
                    idAnamnese          =   int.Parse(txtAnamnese.Text),
                    idMatricula         =   int.Parse(txtMatricula.Text),
                    DtAnamnese          =   DateTime.Parse(dtpDataAnamnese.Text),
                    QP                  =   txtQP.Text,
                    HM                  =   txtHM.Text,
                    Esporte             =   txtEsporte.Text,
                    PosicaoQueDorme     =   txtPosicao.Text,
                    Humor               =   txtHumor.Text,
                    Dor                 =   txtDor.Text,
                    DescricaoDor        =   txtDescricao.Text,
                    DiagnosticoMedico   =   txtDiagnostico.Text,
                    Medicacao           =   txtMedicacao.Text,
                    Patologias          =   txtPatologias.Text
                };

                MessageBox.Show(anamneseBLL.AlterarAnamnese(anamnese));
                listarAlunos();
                btnVoltar.Hide();
                grpAlunos.Show();
                btnSalvar.Hide();
                btnExcluirAnamnese.Hide();
            }
        }
    }
}

