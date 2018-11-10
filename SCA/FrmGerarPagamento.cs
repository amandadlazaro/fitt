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

        #region functions

        private void ModoCadastrar()
        {
            txtNome.Text = GerarPagamentoBLL.Nome;
        }

        private void ModoEditar()
        {

        }

        private bool ValidarCampos()
        {
            return true;
        }

        #endregion

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
    }
}
