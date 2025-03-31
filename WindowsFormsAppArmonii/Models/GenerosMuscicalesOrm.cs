using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppArmonii.Models
{
    public static class GenerosMuscicalesOrm
    {

        public static List<string> ObtenerGeneros()
        {
            List<string> generos = (from g in Orm.bd.Generos
                                    select g.genero).ToList();  // Obtener todos los géneros musicales como una lista de cadenas

            return generos;
        }

    }
}
