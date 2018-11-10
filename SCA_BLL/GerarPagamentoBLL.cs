using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCA_BLL
{
    public class GerarPagamentoBLL
    {
        public static string CPF { get; set; }
        public static string Nome { get; set; }
        public static int idBoleto { get; set; }
        public static int idMatricula { get; set; }
        public static System.DateTime DtVencimento { get; set; }
        public static Nullable<double> Desconto { get; set; }
        public static double ValorTotal { get; set; }
        public static System.DateTime DtPagamento { get; set; }
        public static string FormaDePagamento { get; set; }
    }
}
