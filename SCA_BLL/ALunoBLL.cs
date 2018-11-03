using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCA_BLL
{
    public class AlunoBLL
    {
        #region Propriedades

        public class DadosAlunos
        {
            public string CPF { get; set; }
            public string Nome { get; set; }
            public string Endereco { get; set; }
            public string Telefone { get; set; }
            public System.DateTime DataNasc { get; set; }
            public string Sexo { get; set; }
            public string Email { get; set; }
        }

        public class DadosAlunosMini
        {
            public string CPF { get; set; }
            public string Nome { get; set; }
        }

        #endregion

        public FittDataBaseEntities bd = new FittDataBaseEntities();

        #region Manter

        public string AdicionarAluno(Aluno aluno)
        {
            try
            {
                bd.Aluno.Add(aluno);
                bd.SaveChanges();
                return "Aluno Cadastrado com Sucesso";
            }
            catch (Exception error)
            {
                return error.Message;
            }
        }

        public string AlterarAluno(Aluno aluno)
        {
            try
            {
                var a = bd.Aluno.First(al => al.CPF == aluno.CPF);
                if (a == null) return null;
                bd.Entry(a).CurrentValues.SetValues(aluno);
                bd.SaveChanges();
                return "Aluno Alterado com Sucesso";
            }
            catch (Exception error)
            {
                return error.Message;
            }

        }

        public string DeletarAluno(Aluno aluno)
        {
            try
            {
                var a = bd.Aluno.First(al => al.CPF == aluno.CPF);
                if (a == null) return null;
                bd.Aluno.Remove(a);
                bd.SaveChanges();
                return "Aluno Deletado com Sucesso";
            }
            catch (Exception error)
            {
                return error.Message;
            }
        }

        #endregion

        #region Consultar

        public IEnumerable<DadosAlunos> LerAlunos()
        {
            var lista = bd.Aluno.Select(a => new DadosAlunos
            {
                CPF = a.CPF,
                Nome = a.Nome,
                Endereco = a.Endereco,
                Telefone = a.Telefone,
                Sexo = a.Sexo,
                Email = a.Email,
                DataNasc = a.DataNasc
            }).ToList();

            return lista;
        }
        
        public IEnumerable<DadosAlunos> ProcurarAluno(string cpf)
        {
            var data = bd.Aluno.Where(a => a.CPF.Equals(cpf))
                .Select(a => new DadosAlunos
            {
                CPF = a.CPF,
                Nome = a.Nome,
                Endereco = a.Endereco,
                Telefone = a.Telefone,
                Sexo = a.Sexo,
                Email = a.Email,
                DataNasc = a.DataNasc
            }).ToList();

            return data;
        }

        public IEnumerable<DadosAlunos> LerAlunosPorNome(string nome = null)
        {
            var lista = bd.Aluno.Where(a => a.Nome.StartsWith(nome))
                .Select(a => new DadosAlunos
            {
                CPF = a.CPF,
                Nome = a.Nome,
                Endereco = a.Endereco,
                Telefone = a.Telefone,
                DataNasc = a.DataNasc,
                Sexo = a.Sexo,
                Email = a.Email,
            }).ToList();

            return lista;
        }

        public IEnumerable<DadosAlunosMini> LerAlunosMini()
        {
            var lista = bd.Aluno.Select(a => new DadosAlunosMini
            {
                CPF = a.CPF,
                Nome = a.Nome
            }).ToList();

            return lista;
        }

        #endregion
    }
}
