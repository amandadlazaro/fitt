using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCA_BLL
{
    public class MatriculaBLL
    {
        #region Propriedades
        public class DadosMatricula
        {
            public int idMatricula { get; set; }
            public string CPF { get; set; }
            public int idTurma { get; set; }
            public string TipoPlano { get; set; }
            public double ValorMensal { get; set; }
            public System.DateTime DataInicio { get; set; }
            public System.DateTime DataFim { get; set; }
            public bool SituacaoMatricula { get; set; }
            public int QtdeAulas { get; set; }
            public Nullable<int> idTurma2 { get; set; }
            public Nullable<int> idTurma3 { get; set; }
        }
        #endregion

        public FittDataBaseEntities bd = new FittDataBaseEntities();

        #region Manter

        public string Adicionar(Matricula matricula)
        {
            try
            {
                bd.Matricula.Add(matricula);
                bd.SaveChanges();
                return "Matricula Cadastrada com Sucesso";
            }
            catch (Exception error)
            {
                return error.Message;
            }
        }

        public string Alterar(Matricula matricula)
        {
            try
            {
                var t = bd.Matricula.First(tm => tm.idMatricula == matricula.idMatricula);
                if (t == null) return null;
                bd.Entry(t).CurrentValues.SetValues(matricula);
                bd.SaveChanges();
                return "Matricula Alterada com Sucesso";
            }
            catch (Exception error)
            {
                return error.Message;
            }

        }

        public string Deletar(int matricula)
        {
            try
            {
                var t = bd.Matricula.First(tm => tm.idMatricula == matricula);
                if (t == null) return null;
                bd.Matricula.Remove(t);
                bd.SaveChanges();
                return "Matricula Deletada com Sucesso";
            }
            catch (Exception error)
            {
                return error.Message;
            }
        }

        #endregion

        #region Consultar

        public IEnumerable<DadosMatricula> LerMatricula()
        {
            var lista = bd.Matricula.Select(p => new DadosMatricula
            {
                idMatricula = p.idMatricula,
                CPF = p.CPF,
                idTurma = p.idTurma,
                TipoPlano = p.TipoPlano,
                ValorMensal = p.ValorMensal,
                DataInicio = p.DataInicio,
                DataFim = p.DataFim,
                SituacaoMatricula = p.SituacaoMatricula,
                QtdeAulas = p.QtdeAulas,
                idTurma2 = p.idTurma2,
                idTurma3 = p.idTurma3
            }).ToList();

            return lista;
        }
        
        public IEnumerable<DadosMatricula> ProcurarMatricula(string cpf)
        {
            var data = bd.Matricula.Where(a => a.CPF.Equals(cpf))
                .Select(p => new DadosMatricula
            {
                idMatricula = p.idMatricula,
                CPF = p.CPF,
                idTurma = p.idTurma,
                TipoPlano = p.TipoPlano,
                ValorMensal = p.ValorMensal,
                DataInicio = p.DataInicio,
                DataFim = p.DataFim,
                SituacaoMatricula = p.SituacaoMatricula,
                QtdeAulas = p.QtdeAulas,
                idTurma2 = p.idTurma2,
                idTurma3 = p.idTurma3
                }).ToList();

            return data;
        }

        #endregion
    }
}
