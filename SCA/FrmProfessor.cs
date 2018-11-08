﻿using DAL;
using SCA_BLL;
using System;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace FittSistema.View
{
    public partial class FrmProfessor : Form
    {
        public FrmProfessor()
        {
            InitializeComponent();
        }

        ProfessorBLL professorBLL = new ProfessorBLL();

        private void btnFecharTela_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmMenu menu = new FrmMenu();
            menu.ShowDialog();
            this.Close();
        }

        private void btnCadastrarProfessor_Click(object sender, EventArgs e)
        {
            if (grpProfessores.Visible == true)
            {
                grpProfessores.Hide();
                txtBusca.Hide();
                btnBuscar.Hide();
                btnVoltar.Show();
                limpaCampos();
            }
            else if (ValidaCampos() != "")
            {
                MessageBox.Show(ValidaCampos(), "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var prof = new Professor
                {
                    CPF = txtCPF.Text,
                    Nome = txtNome.Text,
                    Telefone = txtTel.Text,
                    Endereco = txtEnd.Text,
                    Sexo = cmbSexo.SelectedItem.ToString(),
                    DataNasc = DateTime.ParseExact(txtDtNasc.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Email = txtEmail.Text,
                    Senha = Util.Util.criptografarSenha(txtSenha.Text)
                };
                var msg = professorBLL.AdicionarProfessor(prof);
                MessageBox.Show(msg);
                if (msg == "Professor Cadastrado com Sucesso")
                {
                    listarProfessores();
                    btnVoltar.Hide();
                    grpProfessores.Show();
                    txtBusca.Show();
                    btnBuscar.Show();
                }

            }
        }

        private void btnEditarProfessor_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Alterar esses dados?", "Alterar Professor", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (ValidaCampos() != "")
                {
                    MessageBox.Show(ValidaCampos(), "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    var prof = new Professor
                    {
                        CPF = txtCPF.Text,
                        Nome = txtNome.Text,
                        Telefone = txtTel.Text,
                        Endereco = txtEnd.Text,
                        Sexo = cmbSexo.SelectedItem.ToString(),
                        DataNasc = DateTime.ParseExact(txtDtNasc.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture),
                        Email = txtEmail.Text,
                        Senha = Util.Util.criptografarSenha(txtSenha.Text)
                    };
                    MessageBox.Show(professorBLL.AlterarProfessor(prof));
                    listarProfessores();
                    grpProfessores.Show();
                    txtBusca.Show();
                    btnBuscar.Show();
                    btnCadastrarProfessor.Show();
                    btnEditarProfessor.Hide();
                    btnExcluirProfessor.Hide();
                    btnVoltar.Hide();
                }
            }
        }

        private void btnExcluirProfessor_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Deletar esses dados?", "Deletar Professor", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (string.IsNullOrEmpty(txtCPF.Text))
                {
                    MessageBox.Show("Preencha o campo CPF", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    var prof = new Professor
                    {
                        CPF = txtCPF.Text
                    };
                    var msg = professorBLL.DeletarProfessor(prof);
                    MessageBox.Show(msg);
                    if (msg == "Professor Deletado com Sucesso")
                    {
                        listarProfessores();
                        grpProfessores.Show();
                        txtBusca.Show();
                        btnBuscar.Show();
                        btnCadastrarProfessor.Show();
                        btnEditarProfessor.Hide();
                        btnExcluirProfessor.Hide();
                        btnVoltar.Hide();
                    }
                }
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            grpProfessores.Show();
            txtBusca.Show();
            btnBuscar.Show();
            btnCadastrarProfessor.Show();
            btnEditarProfessor.Hide();
            btnExcluirProfessor.Hide();
            btnVoltar.Hide();
        }

        private void FrmProfessor_Load(object sender, EventArgs e)
        {
            cmbSexo.Items.Add("Feminino");
            cmbSexo.Items.Add("Masculino");
            listarProfessores();
        }

        private void listarProfessores()
        {
            var professores = professorBLL.LerProfessor();
            grpProfessores.DataSource = professores.ToList();
        }

        private string ValidaCampos()
        {
            string erro = "";
            if (string.IsNullOrEmpty(txtCPF.Text))
            {
                erro = "Preencha o campo CPF";
            }
            else if (!Util.Util.validarCPF(txtCPF.Text))
            {
                erro = "CPF inválido";
            }
            else if (string.IsNullOrEmpty(txtNome.Text))
            {
                erro = "Preencha o campo Nome";
            }
            else if (string.IsNullOrEmpty(txtTel.Text))
            {
                erro = "Preencha o campo Telefone";
            }
            else if (!Util.Util.validarTelefone(txtTel.Text))
            {
                erro = "Telefone inválido";
            }
            else if (string.IsNullOrEmpty(txtEnd.Text))
            {
                erro = "Preencha o campo Endereço";
            }
            else if (cmbSexo.SelectedIndex == -1)
            {
                erro = "Selecione um Sexo";
            }
            else if (string.IsNullOrEmpty(txtDtNasc.Text))
            {
                erro = "Preencha o campo Data de Nascimento";
            }
            else if (txtDtNasc.Text.Length != 10)
            {
                erro = "Data inválida";
            }
            else if (string.IsNullOrEmpty(txtEmail.Text))
            {
                erro = "Preencha o campo E-mail";
            }
            else if (!Util.Util.validarEmail(txtEmail.Text))
            {
                erro = "E-mail inválido";
            }
            else if (string.IsNullOrEmpty(txtSenha.Text))
            {
                erro = "Preencha o campo Senha";
            }
            else if (txtSenha.Text.Length < 8)
            {
                erro = "Senha inválida";
            }
            return erro;
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

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            var professor = professorBLL.LerProfPorNome(txtBusca.Text);
            if (!professor.Any()) MessageBox.Show("Nenhum aluno encontrado");
            else grpProfessores.DataSource = professor.ToList();
        }
        
        private void grpProfessores_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCPF.Text = grpProfessores.CurrentRow.Cells[0].Value.ToString();
            txtNome.Text = grpProfessores.CurrentRow.Cells[1].Value.ToString();
            txtTel.Text = grpProfessores.CurrentRow.Cells[2].Value.ToString();
            txtEnd.Text = grpProfessores.CurrentRow.Cells[3].Value.ToString();
            cmbSexo.SelectedItem = grpProfessores.CurrentRow.Cells[4].Value.ToString();
            txtDtNasc.Text = grpProfessores.CurrentRow.Cells[5].Value.ToString();
            txtEmail.Text = grpProfessores.CurrentRow.Cells[6].Value.ToString();
            txtSenha.Text = grpProfessores.CurrentRow.Cells[7].Value.ToString();

            grpProfessores.Hide();
            txtBusca.Hide();
            btnBuscar.Hide();
            btnCadastrarProfessor.Hide();
            btnEditarProfessor.Show();
            btnExcluirProfessor.Show();
            btnVoltar.Show();
        }
    }
}

