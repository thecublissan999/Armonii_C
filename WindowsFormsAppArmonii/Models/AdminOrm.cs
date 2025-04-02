using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppArmonii.Models
{
    public static class AdminOrm
    {
        public class UsuarioAdminDTO
        {
            public int id { get; set; }
            public string nombre { get; set; }
            public string correo { get; set; }
            public string contrasenya { get; set; }
            public string telefono { get; set; }
            public string permiso { get; set; }
        }

        public static List<UsuarioAdminDTO> ObtenerAdmins()
        {
            if (Orm.bd == null)
            {
                throw new InvalidOperationException("El contexto DbContext no está inicializado.");
            }

            var query = (from u in Orm.bd.UsuarioAdmin
                         join p in Orm.bd.Permisos on u.permiso equals p.id
                         select new UsuarioAdminDTO
                         {
                    id = u.id,
                    nombre = u.nombre,
                    correo = u.correo,
                    contrasenya = u.contrasenya,
                    telefono = u.telefono,
                    permiso = p.nombre
                })
                .ToList();

            return query;
        }

    }
}
