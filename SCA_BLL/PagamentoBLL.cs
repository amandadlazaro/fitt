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
