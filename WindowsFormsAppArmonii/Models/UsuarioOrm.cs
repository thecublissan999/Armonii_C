using System;
using System.Collections.Generic;
using System.Data.Entity;
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
            public string apellido { get; set; }
            public string genero { get; set; }
            public string generoMusical { get; set; }
            public string apodo { get; set; }
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
        }
        public class UsuarioLocal
        {
            public int id { get; set; }
            public string nombre { get; set; }
            public string direccion { get; set; }
            public string correo { get; set; }
            public string contrasenya { get; set; }
            public string telefono { get; set; }
            public string descripcion { get; set; }
            public TimeSpan? horarioApertura { get; set; }
            public TimeSpan? horarioCierre { get; set; }
            public float? longitud { get; set; }
            public float? latitud { get; set; }
            public DateTime fechaRegistro { get; set; }
            public bool? estado { get; set; }
            public double? valoracion { get; set; }
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
                                    join m in Orm.bd.Musico on u.id equals m.idUsuario  // Asegúrate de que el nombre de la FK en Musico sea "idUsuario"
                                    where u.tipo == "Musico"  // Solo seleccionar los usuarios cuyo tipo sea "Musico"
                                    select new UsuarioMusico
                                    {
                                        id = u.id,
                                        nombre = u.nombre,
                                        correo = u.correo,
                                        contrasenya = u.contrasenya,
                                        telefono = u.telefono,
                                        edad = m.edad,
                                        apodo = m.apodo,
                                        biografia = m.biografia,
                                        longitud = (float?)u.longitud,
                                        latitud = (float?)u.latitud,
                                        fechaRegistro = (DateTime)u.fechaRegistro,
                                        estado = u.estado,
                                        valoracion = (double)u.valoracion,
                                        genero = m.genero,
                                        generoMusical = m.generoMusical,
                                        apellido = m.apellido
                                    }).ToList();

            return eventosConMusico;
        }

        public static List<UsuarioLocal> ObtenerUsuarioLocal()
        {
            var eventosConLocal = (from u in Orm.bd.Usuario
                                   join l in Orm.bd.Local on u.id equals l.idUsuario
                                   where u.tipo == "Local" // Solo seleccionar los usuarios cuyo tipo sea "Local"
                                   orderby u.id
                                   select new UsuarioLocal
                                   {
                                       id = u.id,
                                       nombre = u.nombre,
                                       direccion = l.direccion,
                                       correo = u.correo,
                                       contrasenya = u.contrasenya,
                                       telefono = u.telefono,
                                       descripcion = l.descripcion,
                                       horarioApertura = (TimeSpan)l.horarioApertura,
                                       horarioCierre = (TimeSpan)l.horarioCierre,
                                       longitud = (float?)u.longitud,
                                       latitud = (float?)u.latitud,
                                       fechaRegistro = (DateTime)u.fechaRegistro,
                                       estado = u.estado,
                                       valoracion = (double)u.valoracion,
                                       tipo_local = l.tipo_local
                                   }).ToList();

            return eventosConLocal;
        }


        public static void CrearUsuarioYLocal(UsuarioLocal usuarioLocalSeleccionado)
        {
            using (var context = Orm.bd)
            {
                // Comienza una transacción para asegurar que ambas operaciones sean atómicas
                using (var transaction = context.Database.BeginTransaction())
                {
                    try
                    {
                        // 1. Crear el Usuario
                        var usuario = new Usuario
                        {
                            nombre = usuarioLocalSeleccionado.nombre,
                            correo = usuarioLocalSeleccionado.correo,
                            contrasenya = usuarioLocalSeleccionado.contrasenya,
                            telefono = usuarioLocalSeleccionado.telefono,
                            fechaRegistro = DateTime.Today,
                            valoracion = null,
                            tipo = "Local", // O "Musico", dependiendo de tu lógica
                            longitud = null,
                            latitud = null
                        };

                        // Añadir el Usuario a la base de datos
                        context.Usuario.Add(usuario);
                        context.SaveChanges(); // Guardar el usuario y obtener el ID generado

                        // 2. Crear el Local relacionado con el Usuario
                        var local = new Local
                        {
                            direccion = usuarioLocalSeleccionado.direccion,
                            descripcion = usuarioLocalSeleccionado.descripcion,
                            horarioApertura = null, // Ajusta esto según tus necesidades
                            horarioCierre = null,   // Ajusta también
                            tipo_local = usuarioLocalSeleccionado.tipo_local,
                            idUsuario = usuario.id // Relacionar el local con el usuario mediante la clave foránea
                                                   // No se asigna el valor de 'id' manualmente
                        };

                        // Guardar el Local sin asignar un valor manual a 'id' (SQL Server lo gestionará automáticamente)
                        context.Local.Add(local);
                        context.SaveChanges(); // Guardar el local en la base de datos

                        // Si todo ha ido bien, confirmar la transacción
                        transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        // Si ocurre un error, revertir la transacción
                        transaction.Rollback();
                        Console.WriteLine("Error al guardar el local: " + ex.Message);
                        if (ex.InnerException != null)
                        {
                            Console.WriteLine("Error interno: " + ex.InnerException.Message);
                        }
                        throw new Exception("Hubo un error al guardar el local: " + ex.Message, ex);
                    }
                }
            }
        }




        public static int ObtenerId(string correo)
        {
            var usuario = Orm.bd.Usuario.FirstOrDefault(u => u.correo == correo);
            if (usuario == null)
            {
                throw new Exception("No se encontró un usuario con el correo proporcionado.");
            }

            return usuario.id;
        }


        public static void ModificarUsuarioYLocal(UsuarioLocal usuarioLocalSeleccionado)
        {
            int Id = usuarioLocalSeleccionado.id;

            // Crear una nueva instancia del contexto en cada uso
            using (var transaction = Orm.bd.Database.BeginTransaction())
            {
                try
                {
                    // Buscar el Usuario por ID
                    var usuario = Orm.bd.Usuario.FirstOrDefault(u => u.id == Id);
                    if (usuario == null)
                    {
                        throw new Exception("El usuario con el ID proporcionado no existe.");
                    }

                    // Actualizar el Usuario
                    usuario.nombre = usuarioLocalSeleccionado.nombre;
                    usuario.correo = usuarioLocalSeleccionado.correo;
                    usuario.contrasenya = usuarioLocalSeleccionado.contrasenya;
                    usuario.telefono = usuarioLocalSeleccionado.telefono;

                    // Buscar el Local relacionado con el Usuario
                    var local = Orm.bd.Local.FirstOrDefault(l => l.idUsuario == usuario.id);
                    if (local == null)
                    {
                        throw new Exception("El local relacionado con el usuario no existe.");
                    }

                    // Actualizar el Local
                    local.direccion = usuarioLocalSeleccionado.direccion;
                    local.descripcion = usuarioLocalSeleccionado.descripcion;
                    local.tipo_local = usuarioLocalSeleccionado.tipo_local;

                    // Guardamos los cambios del Usuario y Local en la misma transacción
                    Orm.bd.SaveChanges();
                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    throw new Exception("Hubo un error al modificar los datos: " + ex.Message);
                }
            }
        }

        public static void EliminarUsuario(int usuarioId)
        {
            // Aquí deberías realizar la lógica para eliminar el usuario de la base de datos
            // Ejemplo usando Entity Framework
            using (var context = Orm.bd)
            {
                var usuario = context.Usuario.Find(usuarioId);
                if (usuario != null)
                {
                    context.Usuario.Remove(usuario);
                    context.SaveChanges();
                }
            }
        }
    }
}
