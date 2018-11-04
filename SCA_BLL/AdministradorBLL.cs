using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCA_BLL
{
    public class AdministradorBLL
    {
        #region Propriedades
        public class DadosAdministrador
        {

            public string Email { get; set; }
            public string Senha { get; set; }
        }

        public class NomeAdm
        {
            public string Email { get; set; }
        }
        #endregion
        //comunicação com o BD
        //public FittSistemaEntities bd = new FittSistemaEntities();
        public FittDataBaseEntities bd = new FittDataBaseEntities();

        public IEnumerable<DadosAdministrador> LerAdministrador()
        {
            var lista = bd.Administrador.Select(a => new DadosAdministrador
            {
                Email = a.email,
                Senha = a.senha
            }).ToList();

            return lista;
        }

        public List<DadosAdministrador> ListarAdministrador()
        {
            var lista = bd.Administrador.Select(a => new DadosAdministrador
            {
                Email = a.email,
            }).ToList();

            return lista;
        }

        public string AdicionarAdministrador(Administrador adm)
        {
            try
            {
                bd.Administrador.Add(adm);
                bd.SaveChanges();
                return "Administrador Cadastrado com Sucesso";
            }
            catch (Exception error)
            {
                return error.Message;
            }
        }

        public string AlterarAdministrador(Administrador adm)
        {
            try
            {
                var Administrador = bd.Administrador.First(a => a.email == adm.email);
                if (Administrador == null) return null;
                bd.Entry(Administrador).CurrentValues.SetValues(adm);
                bd.SaveChanges();
                return "Administrador Alterado com Sucesso";
            }
            catch (Exception error)
            {
                return error.Message;
            }

        }


    }
}
