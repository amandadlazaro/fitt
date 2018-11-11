﻿using System;
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
    public partial class FrmGerarPagamento : Form
    {
        public FrmGerarPagamento(bool editar = false)
        {
            InitializeComponent();

            if (editar) ModoEditar();
            else ModoCadastrar();
        }

        Boleto boleto = new Boleto();
        PagamentoBLL pagamentoBLL = new PagamentoBLL();

        #region Functions

        private void ModoCadastrar()
        {
            txtNome.Text = GerarPagamentoBLL.Nome;
            txtValorInicial.Text = GerarPagamentoBLL.ValorMensal.ToString();
        }

        private void ModoEditar()
        {
            btnRegistrar.Visible = false;
            btnExcluir.Visible = true;
            btnSalvar.Visible = true;
            txtNome.Text = GerarPagamentoBLL.Nome;
            txtValorInicial.Text = GerarPagamentoBLL.ValorMensal.ToString();
            dtpDtPag.Value = GerarPagamentoBLL.DtPagamento;
            cmbForma.Text = GerarPagamentoBLL.FormaDePagamento;
            txtDesconto.Text = GerarPagamentoBLL.Desconto.ToString();
            txtValorTotal.Text = GerarPagamentoBLL.ValorTotal.ToString();
        }

        private double CalcularTotal(double desconto, double inicial)
        {
            return inicial - (inicial * (desconto / 100));
        }

        private bool ValidarCampos()
        {
            return true;
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

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos())
            {
                return;
            }

            try
            {
                boleto = new Boleto
                {
                    idMatricula = GerarPagamentoBLL.idMatricula,
                    Desconto = double.Parse(txtDesconto.Text),
                    DtPagamento = dtpDtPag.Value,
                    ValorTotal = double.Parse(txtValorTotal.Text),
                    FormaDePagamento = cmbForma.Text,
                };
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
                return;
            }

            var mensagem = pagamentoBLL.Adicionar(boleto);
            if (mensagem != "Pagamento Cadastrado com Sucesso")
            {
                MessageBox.Show(mensagem);
                pagamentoBLL = new PagamentoBLL();
                return;
            }

            MessageBox.Show(mensagem);
            btnFecharTela.PerformClick();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos())
            {
                return;
            }

            DialogResult Confirmacao = MessageBox.Show("Voce quer mesmo salvar essas alterações ?", "Alterar Matricula", MessageBoxButtons.YesNo);
            if (Confirmacao == DialogResult.No)
            {
                return;
            }

            try
            {
                boleto = new Boleto
                {
                    idBoleto = GerarPagamentoBLL.idBoleto,
                    idMatricula = GerarPagamentoBLL.idMatricula,
                    Desconto = double.Parse(txtDesconto.Text),
                    DtPagamento = dtpDtPag.Value,
                    ValorTotal = double.Parse(txtValorTotal.Text),
                    FormaDePagamento = cmbForma.Text,
                };
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
                return;
            }

            string mensagem = pagamentoBLL.Alterar(boleto);
            if (mensagem != "Pagamento Alterado com Sucesso")
            {
                MessageBox.Show(mensagem);
                return;
            }
            
            MessageBox.Show(mensagem);
            btnFecharTela.PerformClick();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            DialogResult Confirmacao = MessageBox.Show("Voce quer mesmo excluir essa Pagamento ?", "Excluir Pagamento", MessageBoxButtons.YesNo);
            if (Confirmacao == DialogResult.No)
            {
                return;
            }

            string mensagem = pagamentoBLL.Deletar(AlunosMatriculadosBLL.idMatricula);
            if (mensagem != "Pagamento Deletado com Sucesso")
            {
                MessageBox.Show(mensagem);
                return;
            }

            MessageBox.Show(mensagem);
            btnFecharTela.PerformClick();
        }

        private void txtDesconto_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double desconto = double.Parse(txtDesconto.Text);
                if (desconto > 100)
                {
                    txtDesconto.Text = "0";
                    MessageBox.Show("Desconto não pode ser maior que 100%");
                    return;
                }
                double inicial = double.Parse(txtValorInicial.Text);
                txtValorTotal.Text = CalcularTotal(desconto, inicial).ToString();
            }
            catch
            {
            }
        }

        private void FrmGerarPagamento_Load(object sender, EventArgs e)
        {
            txtDesconto_TextChanged(sender, e);
        }

        #endregion

        #region Filtrar Teclas

        private void txtNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Util.FiltrarTeclas.letraMaiuscula(e.KeyChar);
        }

        private void txtDesconto_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Util.FiltrarTeclas.numero(e.KeyChar, txtDesconto.Text);
        }

        #endregion
    }
}
