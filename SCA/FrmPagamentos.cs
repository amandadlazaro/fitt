using System;
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

namespace FittSistema.View
{
    public partial class FrmPagamentos : Form
    {
        public FrmPagamentos()
        {
            InitializeComponent();
        }

        PagamentoBLL pagamentoBLL = new PagamentoBLL();
        MatriculaBLL matriculaBLL = new MatriculaBLL();
        AlunoBLL alunoBLL = new AlunoBLL();

        string modo = "boletos";

        #region Functions

        private void listarBoletos()
        {
            dgvPagamento.DataSource = pagamentoBLL.LerPagamentoAluno();
            modo = "boletos";
        }

        private void listarAlunos()
        {
            dgvPagamento.DataSource = matriculaBLL.LerAlunosMatriculados();
            modo = "alunos";
        }

        private void CadastrarPagamento()
        {
            string cpf = dgvPagamento.CurrentRow.Cells["CPF"].Value.ToString();
            string nome = dgvPagamento.CurrentRow.Cells["Nome"].Value.ToString();

            DialogResult Confirmacao = MessageBox.Show("Voce quer mesmo cadastrar um pagamento para " + nome, "Confirmar Escolha", MessageBoxButtons.YesNo);
            if (Confirmacao == DialogResult.No)
            {
                return;
            }

            try
            {
                dgvPagamento.DataSource = matriculaBLL.ProcurarMatricula(cpf);
                GerarPagamentoBLL.idMatricula = Int32.Parse(dgvPagamento.CurrentRow.Cells["idMatricula"].Value.ToString());

                dgvPagamento.DataSource = alunoBLL.ProcurarAluno(cpf);
                GerarPagamentoBLL.Nome = dgvPagamento.CurrentRow.Cells["Nome"].Value.ToString();
            }
            catch(Exception error)
            {
                listarAlunos();
                MessageBox.Show(error.ToString());
                return;
            }

            this.Hide();
            FrmGerarPagamento frmGerarPagamento = new FrmGerarPagamento();
            frmGerarPagamento.ShowDialog();
            this.Close();
        }

        private void EditarPagamento()
        {
            if (dgvPagamento.Rows.Count <= 0)
            {
                return;
            }

            string cpf = dgvPagamento.CurrentRow.Cells["CPF"].Value.ToString();
            string nome = dgvPagamento.CurrentRow.Cells["Nome"].Value.ToString();
            string idBoleto = dgvPagamento.CurrentRow.Cells["idBoleto"].Value.ToString();

            DialogResult Confirmacao = MessageBox.Show("Voce quer mesmo editar o pagamento de " + nome, "Confirmar Escolha", MessageBoxButtons.YesNo);
            if (Confirmacao == DialogResult.No)
            {
                return;
            }

            try
            {
                GerarPagamentoBLL.Nome = nome;
                GerarPagamentoBLL.CPF = cpf;
                GerarPagamentoBLL.idBoleto = Int32.Parse(idBoleto);

                dgvPagamento.DataSource = matriculaBLL.ProcurarMatricula(cpf);
                GerarPagamentoBLL.idMatricula = Int32.Parse(dgvPagamento.CurrentRow.Cells["idMatricula"].Value.ToString());
            }
            catch (Exception error)
            {
                listarAlunos();
                MessageBox.Show(error.ToString());
                return;
            }

            this.Hide();
            FrmGerarPagamento frmGerarPagamento = new FrmGerarPagamento();
            frmGerarPagamento.ShowDialog();
            this.Close();
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

        private void FrmPagamentos_Load(object sender, EventArgs e)
        {
            listarBoletos();
        }

        private void btnCadastrarProfessor_Click(object sender, EventArgs e)
        {
            listarAlunos();
        }

        private void dgvPagamento_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            switch (modo)
            {
                case("boletos"):
                    EditarPagamento();
                    break;
                case ("alunos"):
                    CadastrarPagamento();
                    break;
                default:
                    break;
            }
        }

        #endregion
    }
}
