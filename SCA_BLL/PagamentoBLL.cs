﻿using DAL;
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
        }
        public class PagamentoAluno
        {
            public int idBoleto { get; set; }
            public string Nome { get; set; }
            public string CPF { get; set; }
            public string FormaDePagamento { get; set; }
            public string TipoPlano { get; set; }
            public double ValorMensal { get; set; }
            public Nullable<double> Desconto { get; set; }
            public double ValorTotal { get; set; }
            public int QtdeAulas { get; set; }
            public bool SituacaoMatricula { get; set; }
        }
        #endregion

        public FittDataBaseEntities bd = new FittDataBaseEntities();


        public IEnumerable<DadosBoleto> LerBoleto()
        {
            var lista = bd.Boleto.Select(p => new DadosBoleto
            {
                idBoleto = p.idBoleto,
                idMatricula = p.idMatricula,
                FormaDePagamento = p.FormaDePagamento,
                Desconto = p.Desconto,
                ValorTotal = p.ValorTotal,
                DtPagamento = p.DtPagamento
            }).ToList();

            return lista;
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
                    FormaDePagamento = bm.b.FormaDePagamento,
                    TipoPlano = bm.m.TipoPlano,
                    ValorMensal = bm.m.ValorMensal,
                    Desconto = bm.b.Desconto,
                    ValorTotal = bm.b.ValorTotal,
                    QtdeAulas = bm.m.QtdeAulas,
                    SituacaoMatricula = bm.m.SituacaoMatricula,
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
