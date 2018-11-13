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

        public class AnamneseComAlunos
        {
            public string Nome { get; set; }
            public string CPF { get; set; }
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

        public IEnumerable<DadosAnamnese> LerAnamnese()
        {
            var lista = bd.Anamnese.Select(p => new DadosAnamnese
            {
                idAnamnese = p.idAnamnese,
                idMatricula = p.idMatricula,
                DtAnamnese = p.DtAnamnese,
                QP = p.QP,
                HM = p.HM,
                Esporte = p.Esporte,
                PosicaoQueDorme = p.PosicaoQueDorme,
                Humor = p.Humor,
                Dor = p.Dor,
                DescricaoDor = p.DescricaoDor,
                DiagnosticoMedico = p.DiagnosticoMedico,
                Medicacao = p.Medicacao,
                Patologias = p.Patologias
            }).ToList();

            return lista;
        }

        public IEnumerable<AnamneseComAlunos> LerAnamneseComNome()
        {
            var lista = bd.Anamnese
                .Join(bd.Matricula, b => b.idMatricula, m => m.idMatricula, (b, m) => new { b, m })
                .Join(bd.Aluno, bm => bm.m.CPF, a => a.CPF, (bm, a) => new AnamneseComAlunos
            {
                idAnamnese = bm.b.idAnamnese,
                idMatricula = bm.b.idMatricula,
                Nome = a.Nome,
                CPF = a.CPF,
                DtAnamnese = bm.b.DtAnamnese,
                QP = bm.b.QP,
                HM = bm.b.HM,
                Esporte = bm.b.Esporte,
                PosicaoQueDorme = bm.b.PosicaoQueDorme,
                Humor = bm.b.Humor,
                Dor = bm.b.Dor,
                DescricaoDor = bm.b.DescricaoDor,
                DiagnosticoMedico = bm.b.DiagnosticoMedico,
                Medicacao = bm.b.Medicacao,
                Patologias = bm.b.Patologias
            }).ToList();

            return lista;
        }

        public List<DadosAnamnese> ListarAnamnese()
        {
            var lista = bd.Anamnese.Select(p => new DadosAnamnese
            {
                idAnamnese = p.idAnamnese,
                QP = p.QP
            }).ToList();

            return lista;
        }

        public string AdicionarAnamnese(Anamnese anam)
        {
            try
            {
                bd.Anamnese.Add(anam);
                bd.SaveChanges();
                return "Anamnese Cadastrada com Sucesso";
            }
            catch (Exception error)
            {
                return error.Message;
            }
        }

        public string AlterarAnamnese(Anamnese anam)
        {
            try
            {
                var anamnese = bd.Anamnese.First(p => p.idAnamnese == anam.idAnamnese);
                if (anamnese == null) return null;
                bd.Entry(anamnese).CurrentValues.SetValues(anam);
                bd.SaveChanges();
                return "Anamnese Salva com Sucesso";
            }
            catch (Exception error)
            {
                return error.Message;
            }

        }

        public string DeletarAnamnese(Anamnese anam)
        {
            try
            {
                var anamnese = bd.Anamnese.First(p => p.idAnamnese == anam.idAnamnese);
                if (anamnese == null) return null;
                bd.Anamnese.Remove(anamnese);
                bd.SaveChanges();
                return "Anamnese Deletada com Sucesso";
            }
            catch (Exception error)
            {
                return error.Message;
            }
        }

        public IEnumerable<DadosAnamnese> LerAnamPorQueixa(string nome)
        {
            var lista = bd.Anamnese
                .Where(a => a.QP.StartsWith(nome))
                .Select(p => new DadosAnamnese
                {
                    idAnamnese = p.idAnamnese,
                    idMatricula = p.idMatricula,
                    DtAnamnese = p.DtAnamnese,
                    QP = p.QP,
                    HM = p.HM,
                    Esporte = p.Esporte,
                    PosicaoQueDorme = p.PosicaoQueDorme,
                    Humor = p.Humor,
                    Dor = p.Dor,
                    DescricaoDor = p.DescricaoDor,
                    DiagnosticoMedico = p.DiagnosticoMedico,
                    Medicacao = p.Medicacao,
                    Patologias = p.Patologias
                }).ToList();

            return lista;
        }

        public IEnumerable<DadosAnamnese> ProcurarAnamnese(int idMat)
        {
            var data = bd.Anamnese.Where(a => a.idMatricula.Equals(idMat))
                .Select(p => new DadosAnamnese
                {
                    idAnamnese = p.idAnamnese,
                    idMatricula = p.idMatricula,
                    DtAnamnese = p.DtAnamnese,
                    QP = p.QP,
                    HM = p.HM,
                    Esporte = p.Esporte,
                    PosicaoQueDorme = p.PosicaoQueDorme,
                    Humor = p.Humor,
                    Dor = p.Dor,
                    DescricaoDor = p.DescricaoDor,
                    DiagnosticoMedico = p.DiagnosticoMedico,
                    Medicacao = p.Medicacao,
                    Patologias = p.Patologias
                }).ToList();

            return data;
        }
    }
}
