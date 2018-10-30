using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCA_BLL
{
    public class AnamneseBLL
    {
        #region Propriedades
        public class DadosAnamnese
        {
            public int idAnamnese { get; set; }
            public int idMatricula { get; set; }
            public DateTime DtAnamnese { get; set; }
            public string QP { get; set; }
            public string HM { get; set; }
            public string Esporte { get; set; }
            public string PosicaoQueDorme { get; set; }
            public string Humor { get; set; }
            public string Dor { get; set; }
            public string DescricaoDor { get; set; }
            public string DiagnosticoMedico { get; set; }
            public string Medicacao { get; set; }
            public string Patologias { get; set; }
        }
        #endregion

        public FittDataBaseEntities bd = new FittDataBaseEntities();

    }
}
