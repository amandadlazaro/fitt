﻿using DAL;
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
        public class DadosTurmasSemana
        {
            public int idTurma { get; set; }
            public string Nome { get; set; }
            public string DiaSemana { get; set; }
            public string Horario { get; set; }
        }
        public class DadosDiaHorario
        {
            public string DiaSemana { get; set; }
            public string Horario { get; set; }
        }
        #endregion

        //comunicação com o BD
        public FittDataBaseEntities bd = new FittDataBaseEntities();

        #region Consultar

        public IEnumerable<DadosTurmasSemana> LerTurma(string diaSemana)
        {
            var lista = bd.Turma
                .Where(t=> t.DiaSemana == diaSemana)
                .Join(bd.Professor, t => t.CPF, prof => prof.CPF, (t, prof) => new DadosTurmasSemana
                { 
                    idTurma = t.idTurma,
                    Nome = prof.Nome,
                    DiaSemana = t.DiaSemana,
                    Horario = t.Horario
                })
                .OrderBy(t=> t.Horario)
                .ToList();

            return lista;
        }

        public IEnumerable<DadosDiaHorario> ProcurarTurma(int idTurma)
        {
            var lista = bd.Turma
                .Where(t => t.idTurma == idTurma)
                .Select(t => new DadosDiaHorario
                {
                    DiaSemana = t.DiaSemana,
                    Horario = t.Horario
                }).ToList();

            return lista;
        }

        #endregion

        #region Manter

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

        #endregion
    }
}
