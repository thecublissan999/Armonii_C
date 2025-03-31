using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppArmonii.Models
{
    public static class UsuarioAdminOrm
    {
        public static UsuarioAdmin SelectLogin(string correo)
        {            
                return Orm.bd.UsuarioAdmin.FirstOrDefault(c => c.correo == correo);
        }
    }
}
