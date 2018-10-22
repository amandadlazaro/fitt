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
    public partial class FrmTurma : Form
    {
        public FrmTurma()
        {
            InitializeComponent();
        }

        ProfessorBLL professorBLL = new ProfessorBLL();
        TurmaBLL turmaBLL = new TurmaBLL();
        private void btnFecharTela_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmMenu menu = new FrmMenu();
            menu.ShowDialog();
            this.Close();
        }


        private void btnCadastrarProfessor_Click(object sender, EventArgs e)
        {
            if (tabSemanas.Visible == true)
            {
                tabSemanas.Hide();
                btnCadastrar.Show();
            }
            else if (ValidaCampos() != "")
            {
                MessageBox.Show(ValidaCampos(), "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var cpf = "";
                var turma = new Turma
                {
                    CPF = cpf,
                    DiaSemana = cmbDiaSemana.SelectedItem.ToString(),
                    Horario = cmbHorario.SelectedItem.ToString()
                };
                MessageBox.Show(turmaBLL.Adicionar(turma));
                tabSemanas.Show();
                ListaTurmas();

            }
        }

        private void ListaTurmas()
        {
            var turmaSegunda = turmaBLL.LerTurma("Segunda");
            grpTurmaSeg.DataSource = turmaSegunda.ToList();
        }

        private string ValidaCampos()
        {
            string erro = "";
            if (cmbProfessor.SelectedIndex == -1)
            {
                erro = "Selecione um Professor";
            }
            else if (cmbDiaSemana.SelectedIndex == -1)
            {
                erro = "Selecione um dia da semana";
            }
            else if (cmbHorario.SelectedIndex == -1)
            {
                erro = "Selciona um Horário";
            }
            return erro;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Alterar esses dados?", "Alterar Turma", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (ValidaCampos() != "")
                {
                    MessageBox.Show(ValidaCampos(), "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    var cpf = "";
                    var turma = new Turma
                    {
                        CPF = cpf,
                        DiaSemana = cmbDiaSemana.SelectedItem.ToString(),
                        Horario = cmbHorario.SelectedItem.ToString()
                    };
                    MessageBox.Show(turmaBLL.Alterar(turma));
                    ListaTurmas();
                    tabSemanas.Show();
                    btnCadastrar.Show();
                    btnEditar.Hide();
                    btnExcluir.Hide();
                }
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Deletar esses dados?", "Deletar Turma", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                var turma = new Turma
                {
                    idTurma = Convert.ToInt32(lblID.Text)
                };
                MessageBox.Show(turmaBLL.Deletar(turma));
                ListaTurmas();
                tabSemanas.Show();
                btnCadastrar.Show();
                btnEditar.Hide();
                btnExcluir.Hide();
            }
        }

        private void FrmTurma_Load_1(object sender, EventArgs e)
        {
            cmbProfessor.DataSource = professorBLL.ListarProfessores();

            cmbDiaSemana.Items.Add("Segunda");
            cmbDiaSemana.Items.Add("Terça");
            cmbDiaSemana.Items.Add("Quarta");
            cmbDiaSemana.Items.Add("Quinta");
            cmbDiaSemana.Items.Add("Sexta");

            cmbHorario.Items.Add("08h-10h");
            cmbHorario.Items.Add("10h-12h");
            cmbHorario.Items.Add("14h-15h");
            cmbHorario.Items.Add("15h-16h");
            cmbHorario.Items.Add("16h-18h");

            ListaTurmas();
        }
    }
}
