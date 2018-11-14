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

        public class AlunosMatriculados
        {
            public string Nome { get; set; }
            public string CPF { get; set; }
            public string TipoPlano { get; set; }
            public double ValorMensal { get; set; }
            public int QtdeAulas { get; set; }
            public bool SituacaoMatricula { get; set; }
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
                var anamnese = bd.Anamnese.FirstOrDefault(a => a.idMatricula == matricula);
                var pagamentos = bd.Boleto.FirstOrDefault(b => b.idMatricula == matricula);
                if (anamnese != null && pagamentos != null)
                {
                    return "Esse aluno tem anamneses e pagamentos cadastrados em seu nome e não pode ser excluído.";
                }
                if (anamnese != null)
                {
                    return "Esse aluno tem anamneses cadastradas em seu nome e não pode ser excluído.";
                }
                if (pagamentos != null)
                {
                    return "Esse aluno tem pagamentos cadastrados em seu nome e não pode ser excluído.";
                }
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

        public IEnumerable<AlunosMatriculados> ProcurarAlunosMatriculados(string nome)
        {
            return bd.Matricula
                .Join(bd.Aluno, m => m.CPF, a => a.CPF, (m, a) => new { m, a })
                .Where(ma => ma.a.Nome.Contains(nome))
                .Select( ma => new AlunosMatriculados
                {
                    Nome = ma.a.Nome,
                    CPF = ma.a.CPF,
                    TipoPlano = ma.m.TipoPlano,
                    ValorMensal = ma.m.ValorMensal,
                    QtdeAulas = ma.m.QtdeAulas,
                    SituacaoMatricula = ma.m.SituacaoMatricula,
                }).ToList();
        }

        public IEnumerable<AlunosMatriculados> LerAlunosMatriculados()
        {
            return bd.Matricula
                .Join(bd.Aluno, m => m.CPF, a => a.CPF, (m, a) => new AlunosMatriculados
                {
                    Nome = a.Nome,
                    CPF = a.CPF,
                    TipoPlano = m.TipoPlano,
                    ValorMensal = m.ValorMensal,
                    QtdeAulas = m.QtdeAulas,
                    SituacaoMatricula = m.SituacaoMatricula,
                }).ToList();
        }

        #endregion
    }
}
