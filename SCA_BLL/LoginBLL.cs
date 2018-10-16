using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCA_BLL
{
    public class LoginBLL
    {
        public FittSistemaEntities bd = new FittSistemaEntities();

        public bool checar(String login, String senha)
        {
            var user = bd.Administrador.FirstOrDefault(adm => adm.email == login && adm.senha == senha);
            if (user == null) return false;
            else return true;
        }
    }
}
