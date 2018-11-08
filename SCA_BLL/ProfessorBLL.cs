﻿using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCA_BLL
{
    public class ProfessorBLL
    {

        #region Propriedades
        public class DadosProfessores
        {
            public string CPF { get; set; }
            public string Nome { get; set; }
            public string Telefone { get; set; }
            public string Endereco { get; set; }
            public string Sexo { get; set; }
            public System.DateTime DataNasc { get; set; }
            public string Email { get; set; }
            public string senha { get; set; }
        }

        public class NomeProf
        {
            public string CPF { get; set; }
            public string Nome { get; set; }
        }
        #endregion
        //comunicação com o BD
        public FittDataBaseEntities bd = new FittDataBaseEntities();

        public IEnumerable<DadosProfessores> LerProfessor()
        {
            var lista = bd.Professor.Select(p => new DadosProfessores
            {
                CPF = p.CPF,
                Nome = p.Nome,
                Telefone = p.Telefone,
                Endereco = p.Endereco,
                Sexo = p.Sexo,
                DataNasc = p.DataNasc,
                Email = p.Email,
                senha = p.Senha
            }).ToList();

            return lista;
        }

        public List<DadosProfessores> ListarProfessores()
        {
            var lista = bd.Professor.Select(p => new DadosProfessores
            {
                CPF = p.CPF,
                Nome = p.Nome
            }).ToList();

            return lista;
        }

        public string AdicionarProfessor(Professor prof)
        {
            try
            {
                var existeCPF = bd.Professor.FirstOrDefault(p => p.CPF == prof.CPF);
                var existeEmail = bd.Professor.FirstOrDefault(p => p.Email == prof.Email);
                if (existeCPF != null)
                {
                    return "CPF já cadastrado";
                }
                if (existeEmail != null)
                {
                    return "Email já cadastrado";
                }
                bd.Professor.Add(prof);
                bd.SaveChanges();
                return "Professor Cadastrado com Sucesso";
            }
            catch (Exception error)
            {
                return error.Message;
            }
        }

        public string AlterarProfessor(Professor prof)
        {
            try
            {
                var professor = bd.Professor.FirstOrDefault(p => p.CPF == prof.CPF);
                if (professor == null) return null;
                bd.Entry(professor).CurrentValues.SetValues(prof);
                bd.SaveChanges();
                return "Professor Alterado com Sucesso";
            }
            catch (Exception error)
            {
                return error.Message;
            }

        }

        public string DeletarProfessor(Professor prof)
        {
            try
            {
                var turmaProf = bd.Turma.FirstOrDefault(t => t.CPF == prof.CPF);
                if (turmaProf != null)
                {
                    return "Professor vinculado à uma Turma"; 
                }
                var professor = bd.Professor.First(p => p.CPF == prof.CPF);
                if (professor == null) return null;
                bd.Professor.Remove(professor);
                bd.SaveChanges();
                return "Professor Deletado com Sucesso";
            }
            catch (Exception error)
            {
                return error.Message;
            }
        }

        public IEnumerable<DadosProfessores> LerProfPorNome(string nome)
        {
            var lista = bd.Professor
                .Where(a => a.Nome.Contains(nome))
                .Select(p => new DadosProfessores
                {
                    CPF = p.CPF,
                    Nome = p.Nome,
                    Telefone = p.Telefone,
                    Endereco = p.Endereco,
                    Sexo = p.Sexo,
                    DataNasc = p.DataNasc,
                    Email = p.Email,
                    senha = p.Senha
                }).ToList();

            return lista;
        }
    }
}
