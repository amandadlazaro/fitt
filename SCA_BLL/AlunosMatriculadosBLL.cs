using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCA_BLL
{
    public class AlunosMatriculadosBLL
    {
        public static string CPF { get; set; }
        public static string Nome { get; set; }
        public static string Endereco { get; set; }
        public static string Telefone { get; set; }
        public static System.DateTime DataNasc { get; set; }
        public static string Sexo { get; set; }
        public static string Email { get; set; }
        public static int idMatricula { get; set; }
        public static int idTurma { get; set; }
        public static string TipoPlano { get; set; }
        public static double ValorMensal { get; set; }
        public static System.DateTime DataInicio { get; set; }
        public static System.DateTime DataFim { get; set; }
        public static bool SituacaoMatricula { get; set; }
        public static int QtdeAulas { get; set; }
    }
}
