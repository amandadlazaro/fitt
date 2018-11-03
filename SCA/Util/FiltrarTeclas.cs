using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FittSistema.Util
{
    public class FiltrarTeclas
    {
        public static char numero(char c, string texto)
        {
            if (c == ',')
            {
                int i;
                i = texto.IndexOf(',');
                if (i >= 0) return ((char)0);
                else return (',');
            }
            if (((c < '0') || (c > '9')) && c != ',' && c != (char)8) c = (char)0;
            return (c);
        }
        public static char numeroInteiro(char c)
        {
            if (((c < '0') || (c > '9')) && c != (char)8) c = (char)0;
            return (c);
        }
        public static char letra(char c)
        {
            if (!(Char.IsLetter(c)) && c != (char)8 && c != (char)32) c = (char)0;
            return c;
        }
        public static char letraMaiuscula(char c)
        {
            if (!(Char.IsLetter(c)) && c != (char)8 && c != (char)32) c = (char)0;
            if ((int)c >= 97 && (int)c <= 122) c = (char)((int)c - 32);
            return c;
        }
    }
}
