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
            public string EstCivil { get; set; }
            public int NumFilhos { get; set; }
            public string Sexo { get; set; }
            public double Altura { get; set; }
            public string Email { get; set; }
        }
        #endregion


        //comunicação com o BD
        public FittDataBaseEntities bd = new FittDataBaseEntities();

        public IEnumerable<DadosAlunos> LerAlunos()
        {
            var lista = bd.Aluno.Select(a => new DadosAlunos
            {
                CPF = a.CPF,
                Nome = a.Nome,
                Endereco = a.Endereco,
                Telefone = a.Telefone,
                DataNasc = a.DataNasc,
                EstCivil = a.EstCivil,
                NumFilhos = a.NumFilhos,
                Sexo = a.Sexo,
                Altura = a.Altura,
                Email = a.Email,
            }).ToList();

            return lista;
        }


        public IEnumerable<DadosAlunos> LerAlunosPorNome(string nome = null)
        {
            var lista = bd.Aluno.Where(a => a.Nome.StartsWith(nome)).
            Select(a => new DadosAlunos
            {
                CPF = a.CPF,
                Nome = a.Nome,
                Endereco = a.Endereco,
                Telefone = a.Telefone,
                DataNasc = a.DataNasc,
                EstCivil = a.EstCivil,
                NumFilhos = a.NumFilhos,
                Sexo = a.Sexo,
                Altura = a.Altura,
                Email = a.Email,
            }).ToList();

            return lista;
        }

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
                var a = bd.Professor.First(al => al.CPF == aluno.CPF);
                if (a == null) return null;
                bd.Professor.Remove(a);
                bd.SaveChanges();
                return "Aluno Deletado com Sucesso";
            }
            catch (Exception error)
            {
                return error.Message;
            }
        }
    }
}
