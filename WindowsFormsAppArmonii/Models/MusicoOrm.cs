using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppArmonii.Models
{
    public static class MusicoOrm
    {
        public static List<Musico> Select()
        {
            List<Musico> _musico = (
                    from c in Orm.bd.Musico
                    select c
                ).ToList();

               return _musico;
        }
    }
}
