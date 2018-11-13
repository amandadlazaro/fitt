using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCA_BLL
{
    public class PagamentoBLL
    {
        #region Propriedades
        public class DadosBoleto
        {
            public int idBoleto { get; set; }
            public int idMatricula { get; set; }
            public string FormaDePagamento { get; set; }
            public Nullable<double> Desconto { get; set; }
            public double ValorTotal { get; set; }
            public DateTime DtPagamento { get; set; }
            public bool status { get; set; }
        }
        public class PagamentoAluno
        {
            public int idBoleto { get; set; }
            public string Nome { get; set; }
            public string CPF { get; set; }
            public DateTime DtPagamento { get; set; }
            public string FormaDePagamento { get; set; }
            public double ValorMensal { get; set; }
            public Nullable<double> Desconto { get; set; }
            public double ValorTotal { get; set; }
            public bool Pago { get; set; }
        }
        #endregion

        public FittDataBaseEntities bd = new FittDataBaseEntities();


        public IEnumerable<DadosBoleto> LerBoleto()
        {
            return bd.Boleto.Select(p => new DadosBoleto
            {
                idBoleto = p.idBoleto,
                idMatricula = p.idMatricula,
                FormaDePagamento = p.FormaDePagamento,
                Desconto = p.Desconto,
                ValorTotal = p.ValorTotal,
                DtPagamento = p.DtPagamento,
                status = p.status
            }).ToList();
        }

        public IEnumerable<DadosBoleto> ProcurarBoleto(int boleto)
        {
            return bd.Boleto.Where(b => b.idBoleto.Equals(boleto))
                .Select(p => new DadosBoleto
                {
                    idBoleto = p.idBoleto,
                    idMatricula = p.idMatricula,
                    FormaDePagamento = p.FormaDePagamento,
                    Desconto = p.Desconto,
                    ValorTotal = p.ValorTotal,
                    DtPagamento = p.DtPagamento,
                    status = p.status
                }).ToList();
        }

        public IEnumerable<PagamentoAluno> LerPagamentoAluno()
        {
            return bd.Boleto
                .Join(bd.Matricula, b => b.idMatricula, m => m.idMatricula, (b, m) => new { b, m })
                .Join(bd.Aluno, bm => bm.m.CPF, a => a.CPF, (bm, a) => new PagamentoAluno
                {
                    idBoleto = bm.b.idBoleto,
                    Nome = a.Nome,
                    CPF = a.CPF,
                    DtPagamento = bm.b.DtPagamento,
                    FormaDePagamento = bm.b.FormaDePagamento,
                    ValorMensal = bm.m.ValorMensal,
                    Desconto = bm.b.Desconto,
                    ValorTotal = bm.b.ValorTotal,
                    Pago = bm.b.status
                }).ToList();
        }

        public IEnumerable<PagamentoAluno> ProcurarPagamentoAluno(string nomeAluno)
        {
            return bd.Boleto
                .Join(bd.Matricula, b => b.idMatricula, m => m.idMatricula, (b, m) => new { b, m })
                .Join(bd.Aluno, bm => bm.m.CPF, a => a.CPF, (bm, a) => new {bm, a})
                .Where(bma => bma.a.Nome.Contains(nomeAluno))
                .Select(bma => new PagamentoAluno
                {
                    idBoleto = bma.bm.b.idBoleto,
                    Nome = bma.a.Nome,
                    CPF = bma.a.CPF,
                    DtPagamento = bma.bm.b.DtPagamento,
                    FormaDePagamento = bma.bm.b.FormaDePagamento,
                    ValorMensal = bma.bm.m.ValorMensal,
                    Desconto = bma.bm.b.Desconto,
                    ValorTotal = bma.bm.b.ValorTotal,
                    Pago = bma.bm.b.status 
                }).ToList();
        }

        public string Adicionar(Boleto boleto)
        {
            try
            {
                bd.Boleto.Add(boleto);
                bd.SaveChanges();
                return "Pagamento Cadastrado com Sucesso";
            }
            catch (Exception error)
            {
                return error.Message;
            }
        }

        public string Alterar(Boleto boleto)
        {
            try
            {
                var t = bd.Boleto.First(tm => tm.idBoleto == boleto.idBoleto);
                if (t == null) return null;
                bd.Entry(t).CurrentValues.SetValues(boleto);
                bd.SaveChanges();
                return "Pagamento Alterado com Sucesso";
            }
            catch (Exception error)
            {
                return error.Message;
            }

        }

        public string Deletar(int boleto)
        {
            try
            {
                var t = bd.Boleto.First(tm => tm.idBoleto == boleto);
                if (t == null) return null;
                bd.Boleto.Remove(t);
                bd.SaveChanges();
                return "Pagamento Deletado com Sucesso";
            }
            catch (Exception error)
            {
                return error.Message;
            }
        }
    }
}
