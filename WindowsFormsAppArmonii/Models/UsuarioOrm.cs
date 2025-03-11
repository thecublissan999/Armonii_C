using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppArmonii.Models
{
    public static class UsuarioOrm
    {
        public class UsuarioMusico
        {
            public int id { get; set; }
            public string nombre { get; set; }
            public string nombreArtistico { get; set; }
            public string correo { get; set; }
            public string contrasenya { get; set; }
            public string telefono { get; set; }
            public int? edad { get; set; }
            public string biografia { get; set; }
            public float? longitud { get; set; }
            public float? latitud { get; set; }
            public DateTime fechaRegistro { get; set; }
            public bool? estado { get; set; }
            public double valoracion { get; set; }
            public string genero { get; set; }
        }
        public class UsuarioLocal
        {
            public int id { get; set; }
            public string nombre { get; set; }
            public string direccion { get; set; }
            public string correo { get; set; }
            public string contrasenya { get; set; }
            public string telefono { get; set; }
            public TimeSpan horarioApertura { get; set; }
            public TimeSpan horarioCierre { get; set; }
            public float? longitud { get; set; }
            public float? latitud { get; set; }
            public DateTime fechaRegistro { get; set; }
            public bool? estado { get; set; }
            public double valoracion { get; set; }
            public string tipo_local { get; set; }
        }
        public static Usuario SelectLogin(string correo)
        {
            return Orm.bd.Usuario.FirstOrDefault(c => c.correo == correo);
        }
        public static List<Usuario> SelectContra(string contra)
        {
            List<Usuario> _usuario = (
                    from c in Orm.bd.Usuario
                    where c.contrasenya == contra
                    select c
                ).ToList();

            return _usuario;
        }

        public static List<UsuarioMusico> ObtenerUsuarioMusico()
        {

            var eventosConMusico = (from u in Orm.bd.Usuario
                                    join m in Orm.bd.Musico on u.id equals m.id
                                    select new UsuarioMusico
                                    {
                                        id = u.id,
                                        nombre = u.nombre,
                                        nombreArtistico = m.nombreArtistico,
                                        correo = u.correo,
                                        contrasenya = u.contrasenya,
                                        telefono = u.telefono,
                                        edad = m.edad,
                                        biografia = m.biografia,
                                        longitud = (float?)u.longitud,
                                        latitud = (float?)u.latitud,
                                        fechaRegistro = (DateTime)u.fechaRegistro,
                                        estado = u.estado,
                                        valoracion = (double)u.valoracion,
                                        genero = m.genero
                                    }).ToList();

            return eventosConMusico;
        }
        public static List<UsuarioLocal> ObtenerUsuarioLocal()
        {

            var eventosConMusico = (from u in Orm.bd.Usuario
                                    join l in Orm.bd.Local on u.id equals l.id
                                    select new UsuarioLocal
                                    {
                                        id = u.id,
                                        nombre = u.nombre,
                                        direccion = l.direccion,
                                        correo = u.correo,
                                        contrasenya = u.contrasenya,
                                        telefono = u.telefono,
                                        horarioApertura = (TimeSpan)l.horarioApertura,
                                        horarioCierre = (TimeSpan)l.horarioCierre,
                                        longitud = (float?)u.longitud,
                                        latitud = (float?)u.latitud,
                                        fechaRegistro = (DateTime)u.fechaRegistro,
                                        estado = u.estado,
                                        valoracion = (double)u.valoracion,
                                        tipo_local = l.tipo_local
                                    }).ToList();

            return eventosConMusico;
        }

        public static List<dynamic> SelectTipo(string tipo)
        {
            if (tipo == "Musico")
            {
                return (from u in Orm.bd.Usuario
                        join m in Orm.bd.Musico on u.id equals m.id
                        select new
                        {
                            u.id,
                            u.nombre,
                            m.nombreArtistico,
                            u.correo,
                            u.contrasenya,
                            u.telefono, 
                            u.fechaRegistro,
                            u.estado,
                            //m.edad,
                            u.valoracion,
                            m.biografia,
                            m.genero, 
                            u.tipo
                        }).ToList<dynamic>();
            }
            else if (tipo == "Local")
            {
                return (from u in Orm.bd.Usuario
                        join l in Orm.bd.Local on u.id equals l.id
                        select new
                        {
                            u.id,
                            u.nombre,
                            u.correo,
                            u.contrasenya,
                            u.telefono,
                            u.fechaRegistro,
                            u.estado,
                            u.tipo,
                            l.direccion,
                            l.tipo_local,
                            l.horarioApertura,
                            l.horarioCierre
                        }).ToList<dynamic>();
            }
            else
            {
                return Orm.bd.Usuario.ToList<dynamic>();
            }
        }
    }
}
