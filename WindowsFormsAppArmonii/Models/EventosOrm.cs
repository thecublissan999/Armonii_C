using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Metadata.Edm;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppArmonii.Models
{
    public static class EventosOrm
    {
        public class EventoConMusico
        {
            public int id { get; set; }
            public string nombre { get; set; }
            public DateTime fecha { get; set; }
            public string descripcion { get; set; }
            public string nombreArtistico { get; set; }
            public string nombreLocal { get; set; }
        }
        public static List<Evento> SelectContra(DateTime data)
        {
            List<Evento> _evento = (
                    from c in Orm.bd.Evento
                    where c.fecha == data
                    select c
                ).ToList();

            return _evento;
        }

        public static List<EventoConMusico> ObtenerEventosConMusico(DateTime fecha)
        { 

         var eventosConMusico = (from e in Orm.bd.Evento
                                 join m in Orm.bd.Musico on e.idMusico equals m.id
                                 join u in Orm.bd.Usuario on e.idLocal equals u.id
                                 where e.fecha == fecha
                                 select new EventoConMusico
                                 {
                                     id = e.id,
                                     nombre = e.nombre,
                                     fecha = e.fecha,
                                     descripcion = e.descripcion,
                                     nombreArtistico = m.nombreArtistico,
                                     nombreLocal = u.nombre
                                 }).ToList();

            return eventosConMusico;
        }
    }
}