using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppArmonii.Models
{
    public static class PermisosOrm
    {
        public class PermisoDTO
        {
            public int id { get; set; }
            public string nombre { get; set; }
        }
        public static List<PermisoDTO> ObtenerPermisos()
        {
            if (Orm.bd == null)
            {
                throw new InvalidOperationException("El contexto DbContext no está inicializado.");
            }

            var permisos = Orm.bd.Permisos
                            .Select(p => new PermisoDTO
                            {
                                id = p.id,
                                nombre = p.nombre
                            })
                            .ToList();

            return permisos;
        }

        public static int ObtenerIdPermiso(string nombrePermiso)
        {
            if (Orm.bd == null)
            {
                throw new InvalidOperationException("El contexto DbContext no está inicializado.");
            }
            var permiso = Orm.bd.Permisos
                            .Where(p => p.nombre == nombrePermiso)
                            .Select(p => p.id)
                            .FirstOrDefault();
            return permiso;
        }
    }
}
