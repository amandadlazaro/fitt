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
        Boolean entrou = false;

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
            if (grpAluno.Visible == false)
            {
                var alunos = alunoBLL.LerAlunosPorNome(txtBusca.Text);
                if (!alunos.Any()) MessageBox.Show("Nenhum aluno encontrado");
                grpAnamnese.DataSource = alunos.ToList();
            }
            else
            {
                var alunos = alunoBLL.LerAlunosPorNome(txtBusca.Text);
                if (!alunos.Any()) MessageBox.Show("Nenhum aluno encontrado");
                grpAluno.DataSource = alunos.ToList();
            }
        }

        private void FrmAnamneses_Load(object sender, EventArgs e)
        {
            listarAlunos();
            dtpDataAnamnese.Value = System.DateTime.Now;
        }

        private void grpAnamnese_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (grpAnamnese.Rows.Count <= 0)
                return;

            if (MessageBox.Show("Deseja Alterar esses dados?", "Alterar Anamnese", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                return;
            }

            grpAnamnese.Hide();
            btnSalvar.Show();
            btnExcluirAnamnese.Show();
            btnVoltar.Show();
            limpaCampos();
            btnCadastrar.Hide();

            #region Propriedades GRID
            var mat = grpAnamnese.CurrentRow.Cells["idMatricula"].Value.ToString();
            var qp = grpAnamnese.CurrentRow.Cells["QP"].Value;
            var hm = grpAnamnese.CurrentRow.Cells["HM"].Value;
            var esp = grpAnamnese.CurrentRow.Cells["Esporte"].Value;
            var pos = grpAnamnese.CurrentRow.Cells["PosicaoQueDorme"].Value;
            var humor = grpAnamnese.CurrentRow.Cells["Humor"].Value;
            var dor = grpAnamnese.CurrentRow.Cells["Dor"].Value;
            var desc = grpAnamnese.CurrentRow.Cells["DescricaoDor"].Value;
            var diag = grpAnamnese.CurrentRow.Cells["DiagnosticoMedico"].Value;
            var med = grpAnamnese.CurrentRow.Cells["Medicacao"].Value;
            var pat = grpAnamnese.CurrentRow.Cells["Patologias"].Value;
            #endregion

            txtMatricula.Text = mat == null ? "" : mat.ToString();
            
            IDs = txtMatricula.Text;

            grpAnamnese.DataSource = anamneseBLL.ProcurarAnamnese(int.Parse(IDs));
            if (grpAnamnese.Rows.Count > 0)
            {
                txtAnamnese.Text = grpAnamnese.CurrentRow.Cells["idAnamnese"].Value.ToString();
                dtpDataAnamnese.Text = grpAnamnese.CurrentRow.Cells["DtAnamnese"].Value.ToString();
                txtMatricula.Text = grpAnamnese.CurrentRow.Cells["idMatricula"].Value.ToString();
                txtQP.Text = qp == null ? "" : qp.ToString();
                txtHM.Text = hm == null ? "" : hm.ToString();
                txtEsporte.Text = esp == null ? "" : esp.ToString();
                txtPosicao.Text = pos == null ? "" :  pos.ToString();
                txtHumor.Text = humor == null ? "" : humor.ToString();
                txtDor.Text = dor == null ? "" : dor.ToString();
                txtDescricao.Text = desc == null ?  "" : desc.ToString();
                txtDiagnostico.Text = diag == null ? "" : diag.ToString();
                txtMedicacao.Text = med == null ? "" : med.ToString();
                txtPatologias.Text = pat == null ? "" : pat.ToString();
            }
            else
            {
                if (MessageBox.Show("Aluno não tem Anamnese Cadastrada. Deseja Cadastrar Nova Anamnese?", "Sem Cadastro de Anamnese", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    btnCadastrar.PerformClick();
                }
                else
                {
                    return;
                }

            }

        }
        
        private void btnExcluirAnamese_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Deletar esses dados?", "Deletar Anamnese", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                anamnese = new Anamnese
                {
                    idAnamnese = int.Parse(txtAnamnese.Text),
                    idMatricula = int.Parse(txtMatricula.Text),
                    DtAnamnese = DateTime.Parse(dtpDataAnamnese.Text),
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

                MessageBox.Show(anamneseBLL.DeletarAnamnese(anamnese));
                listarAlunos();
                btnVoltar.Hide();
                grpAnamnese.Show();
                btnSalvar.Hide();
                btnExcluirAnamnese.Hide();
                btnCadastrar.Show();
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            if (grpAluno.Visible == true)
            {
                listarAlunos();
                grpAluno.Hide();
                btnCadastrar.Show();
                label1.Text = "Anamneses";
                btnVoltar.Hide();
            }
            else if (btnSalvar.Visible == true)
            {
                btnSalvar.Hide();
                btnExcluirAnamnese.Hide();
                grpAnamnese.Show();
                btnCadastrar.Show();
                btnVoltar.Hide();
            }
            else if (btnCadastrar.Visible == true && grpAluno.Visible == false && grpAnamnese.Visible == false)
            {
                btnCadastrar.Hide();
                grpAluno.DataSource = alunoBLL.LerAlunos();
                grpAluno.Show();
            }


        }

        private void listarAlunos()
        {
            var aluno = anamneseBLL.LerAnamneseComNome();
            grpAnamnese.DataSource = aluno.ToList();
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
                try
                {
                    anamnese = new Anamnese
                    {
                        idAnamnese = int.Parse(txtAnamnese.Text),
                        idMatricula = int.Parse(txtMatricula.Text),
                        DtAnamnese = DateTime.Parse(dtpDataAnamnese.Text),
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
                    btnVoltar.Hide();
                    grpAnamnese.Show();
                    btnSalvar.Hide();
                    btnExcluirAnamnese.Hide();
                    btnCadastrar.Show();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void txtBusca_Enter(object sender, EventArgs e)
        {
            if (txtBusca.Text == "Buscar por Aluno")
            {
                txtBusca.Text = "";
                txtBusca.ForeColor = Color.Black;
            }
        }

        private void txtBusca_Leave(object sender, EventArgs e)
        {
            if (txtBusca.Text == "")
            {
                txtBusca.Text = "Buscar por Aluno";
                txtBusca.ForeColor = Color.Silver;
            }
        }

        private void txtBusca_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Util.FiltrarTeclas.letraMaiuscula(e.KeyChar);
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (grpAluno.Visible == false && entrou == false)
            {
                if (MessageBox.Show("Deseja Cadastrar uma Nova Anamnese?", "Cadastrar Anamnese", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    return;
                }

                grpAluno.Show();
                var aluno = alunoBLL.LerAlunos();
                grpAluno.DataSource = aluno.ToList();
                btnVoltar.Show();
                btnCadastrar.Hide();
                label1.Text = "Alunos";
                MessageBox.Show("Selecione o Aluno em que deseja criar a Anamnese");
            }
            else
            {
                if (MessageBox.Show("Deseja Cadastrar essa Nova Anamnese?", "Cadastrar Anamnese", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    return;
                }

                try
                {
                    anamnese = new Anamnese
                    {
                        idMatricula = int.Parse(txtMatricula.Text),
                        DtAnamnese = DateTime.Parse(dtpDataAnamnese.Text),
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

                    MessageBox.Show(anamneseBLL.AdicionarAnamnese(anamnese));
                    listarAlunos();
                    grpAnamnese.Show();
                    entrou = false;
                    label1.Text = "Anamneses";
                    btnVoltar.Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }

        }

        private void grpAluno_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            limpaCampos();

            IDs = grpAluno.CurrentRow.Cells["CPF"].Value.ToString();

            grpAluno.DataSource = matriculaBLL.ProcurarMatricula(IDs);
            AlunosMatriculadosBLL.idMatricula = Int32.Parse(grpAluno.CurrentRow.Cells["idMatricula"].Value.ToString());
            txtMatricula.Text = AlunosMatriculadosBLL.idMatricula.ToString();

            IDs = txtMatricula.Text;

            grpAnamnese.DataSource = anamneseBLL.ProcurarAnamnese(int.Parse(IDs));
            if (grpAnamnese.Rows.Count > 0)
            {
                MessageBox.Show("Anamnese de Aluno já Cadastrada");
                grpAnamnese.Show();
                grpAluno.Hide();
                btnVoltar.Hide();
                btnCadastrar.Show();
                return;
            }

            grpAnamnese.Hide();
            grpAluno.Hide();
            btnVoltar.Show();
            btnCadastrar.Show();
            entrou = true;
            txtBusca.Hide();
            btnBuscarAnamnese.Hide();
            label1.Text = "Dados da Anamnese";
        }
    }
}

