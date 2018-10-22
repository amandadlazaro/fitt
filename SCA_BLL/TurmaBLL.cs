using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCA_BLL
{
    public class TurmaBLL
    {
        #region Propriedades
        public class DadosTurmas
        {
            public int idTurma { get; set; }
            public string CPF { get; set; }
            public string DiaSemana { get; set; }
            public string Horario { get; set; }
        }
        #endregion

        //comunicação com o BD
        public FittSistemaEntities bd = new FittSistemaEntities();

        public IEnumerable<DadosTurmas> LerTurma(string diasemana)
        {
            var lista = bd.Turma.Where(t => t.DiaSemana == diasemana)
                .Select(t => new DadosTurmas
                {
                    idTurma = t.idTurma,
                    CPF = t.CPF,
                    DiaSemana = t.DiaSemana,
                    Horario = t.Horario
                }).ToList();

            return lista;
        }

     
        public string Adicionar(Turma turma)
        {
            try
            {
                bd.Turma.Add(turma);
                bd.SaveChanges();
                return "Turma Cadastrada com Sucesso";
            }
            catch (Exception error)
            {
                return error.Message;
            }
        }

        public string Alterar(Turma turma)
        {
            try
            {
                var t = bd.Turma.First(tm => tm.idTurma == turma.idTurma);
                if (t == null) return null;
                bd.Entry(t).CurrentValues.SetValues(turma);
                bd.SaveChanges();
                return "Turma Alterada com Sucesso";
            }
            catch (Exception error)
            {
                return error.Message;
            }

        }

        public string Deletar(Turma turma)
        {
            try
            {
                var t = bd.Turma.First(tm => tm.idTurma == turma.idTurma);
                if (t == null) return null;
                bd.Turma.Remove(t);
                bd.SaveChanges();
                return "Turma Deletadcom Sucesso";
            }
            catch (Exception error)
            {
                return error.Message;
            }
        }
    }
}
