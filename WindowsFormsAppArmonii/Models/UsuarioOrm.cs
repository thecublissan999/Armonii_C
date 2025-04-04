using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static WindowsFormsAppArmonii.Models.AdminOrm;

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
            public double? valoracion { get; set; }
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
                                    select new
                                    {
                                        Usuario = u,
                                        Musico = m
                                    }).ToList()
                                    .Select(x => new UsuarioMusico
                                    {
                                        id = x.Usuario.id,
                                        nombre = x.Usuario.nombre,
                                        correo = x.Usuario.correo,
                                        contrasenya = x.Usuario.contrasenya,
                                        telefono = x.Usuario.telefono,
                                        edad = x.Musico.edad,
                                        apodo = x.Musico.apodo ?? " ",
                                        biografia = x.Musico.biografia,
                                        longitud = (float?)x.Usuario.longitud,
                                        latitud = (float?)x.Usuario.latitud,
                                        fechaRegistro = (DateTime)x.Usuario.fechaRegistro,
                                        estado = x.Usuario.estado,
                                        valoracion = (double?)x.Usuario.valoracion,
                                        genero = x.Musico.genero,
                                        apellido = x.Musico.apellido,

                                        // Obtener los géneros musicales asociados al musico
                                        generoMusical = string.Join(", ",
                                            (from gm in Orm.bd.GenerosMusicos
                                             join g in Orm.bd.Generos on gm.idGenero equals g.id
                                             where gm.idMusico == x.Musico.id
                                             select g.genero).ToList())
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
                // Comienza una transacción para asegurar que ambas operaciones sean atómicas
                using (var transaction = Orm.bd.Database.BeginTransaction())
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
                            latitud = null,
                            estado = true
                        };

                    // Añadir el Usuario a la base de datos
                    Orm.bd.Usuario.Add(usuario);
                    Orm.bd.SaveChanges(); // Guardar el usuario y obtener el ID generado

                        CrearLocal(usuarioLocalSeleccionado, usuario.id);

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
        public static void CrearAdmin(UsuarioAdmin admin)
        {
            using (var transaction = Orm.bd.Database.BeginTransaction())
            {
                try
                {
                    var administrador = new UsuarioAdmin
                    {
                        nombre = admin.nombre,
                        correo = admin.correo,
                        contrasenya = admin.contrasenya,
                        telefono = admin.telefono,
                        permiso = admin.permiso
                    };
                    Orm.bd.UsuarioAdmin.Add(administrador);
                    Orm.bd.SaveChanges();
                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    Console.WriteLine("Error al guardar el admin: " + ex.Message);
                    if (ex.InnerException != null)
                    {
                        Console.WriteLine("Error interno: " + ex.InnerException.Message);
                    }
                    throw new Exception("Hubo un error al guardar el admin: " + ex.Message, ex);
                }
            }
        }

        public static void ModificarAdmin(UsuarioAdminDTO adminSeleccionado)
        {
            using (var transaction = Orm.bd.Database.BeginTransaction()) // Iniciar transacción
            {
                try
                {
                    // Buscar el Usuario por ID
                    var admin = Orm.bd.UsuarioAdmin.FirstOrDefault(u => u.id == adminSeleccionado.id);
                    if (admin == null)
                    {
                        throw new Exception("El usuario con el ID proporcionado no existe.");
                    }

                    int idPermiso = PermisosOrm.ObtenerIdPermiso(adminSeleccionado.permiso);

                    // Actualizar el Usuario
                    admin.nombre = adminSeleccionado.nombre;
                    admin.correo = adminSeleccionado.correo;
                    admin.contrasenya = adminSeleccionado.contrasenya;
                    admin.telefono = adminSeleccionado.telefono;
                    admin.permiso = idPermiso;

                    // Guardar cambios en la base de datos
                    Orm.bd.SaveChanges();
                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show("Error al modificar los datos: " + ex.Message);
                }
            }
        }
        public static void EliminarAdmin(Int32 usuarioId)
        {
            // Empezamos una transacción para asegurar que ambas operaciones ocurren juntas
            using (var transaction = Orm.bd.Database.BeginTransaction())
            {
                try
                {
                    // Buscar el usuario por ID
                    var admin = Orm.bd.UsuarioAdmin.FirstOrDefault(u => u.id == usuarioId);
                    if (admin == null)
                    {
                        throw new Exception("El usuario no existe.");
                    }

                    // Eliminar el usuario
                    Orm.bd.UsuarioAdmin.Remove(admin);

                    // Guardar cambios en la base de datos
                    Orm.bd.SaveChanges();

                    // Confirmar la transacción
                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    // Si ocurre un error, deshacer la transacción
                    transaction.Rollback();
                    throw new Exception("Error al eliminar el usuario: " + ex.Message);
                }
            }
        }

        public static void CrearUsuarioYMusico(UsuarioMusico usuarioMusicoSeleccionado)
        {
            // Comienza una transacción para asegurar que ambas operaciones sean atómicas
            using (var transaction = Orm.bd.Database.BeginTransaction())
            {
                try
                {
                    // 1. Crear el Usuario
                    var usuario = new Usuario
                    {
                        nombre = usuarioMusicoSeleccionado.nombre,
                        correo = usuarioMusicoSeleccionado.correo,
                        contrasenya = usuarioMusicoSeleccionado.contrasenya,
                        telefono = usuarioMusicoSeleccionado.telefono,
                        fechaRegistro = DateTime.Today,
                        valoracion = null,
                        tipo = "Musico", // O "Musico", dependiendo de tu lógica
                        longitud = null,
                        latitud = null,
                        estado = true
                        
                    };

                    // Añadir el Usuario a la base de datos
                    Orm.bd.Usuario.Add(usuario);
                    Orm.bd.SaveChanges(); // Guardar el usuario y obtener el ID generado

                    int musicoId = CrearMusico(usuarioMusicoSeleccionado, usuario.id);
                    var generosSeleccionados = usuarioMusicoSeleccionado.generoMusical.Split(',')
                                                     .Select(g => g.Trim()) // Eliminar espacios alrededor de los géneros
                                                     .ToList();

                    AgregarGenerosMusicales(musicoId, generosSeleccionados); // Agregar los géneros musicales seleccionados


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

        public static void CrearLocal(UsuarioLocal usuarioLocalSeleccionado, int idUsuario)
        {
            // 2. Crear el Local relacionado con el Usuario
            var local = new Local
            {
                direccion = usuarioLocalSeleccionado.direccion,
                descripcion = usuarioLocalSeleccionado.descripcion,
                horarioApertura = null, // Ajusta esto según tus necesidades
                horarioCierre = null,   // Ajusta también
                tipo_local = usuarioLocalSeleccionado.tipo_local,
                idUsuario = idUsuario // Relacionar el local con el usuario mediante la clave foránea
                                      // No se asigna el valor de 'id' manualmente
            };

            // Guardar el Local sin asignar un valor manual a 'id' (SQL Server lo gestionará automáticamente)
            Orm.bd.Local.Add(local);
            Orm.bd.SaveChanges(); // Guardar el local en la base de dato
        }

        public static int CrearMusico(UsuarioMusico usuarioMusicoSeleccionado, int idUsuario)
        {
            // 2. Crear el Local relacionado con el Usuario
            var musico = new Musico
            {
                apodo = usuarioMusicoSeleccionado.apodo,
                apellido = usuarioMusicoSeleccionado.apellido,
                edad = usuarioMusicoSeleccionado.edad,
                genero = usuarioMusicoSeleccionado.genero,
                biografia = usuarioMusicoSeleccionado.biografia,
                idUsuario = idUsuario // Relacionar el local con el usuario mediante la clave foránea
                                      // No se asigna el valor de 'id' manualmente
            };

            // Guardar el Local sin asignar un valor manual a 'id' (SQL Server lo gestionará automáticamente)
            Orm.bd.Musico.Add(musico);
            Orm.bd.SaveChanges(); // Guardar el local en la base de dato
            return musico.id;
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
            using (var transaction = Orm.bd.Database.BeginTransaction()) // Iniciar transacción
            {
                try
                {
                    // Buscar el Usuario por ID
                    var usuario = Orm.bd.Usuario.FirstOrDefault(u => u.id == usuarioLocalSeleccionado.id);
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

                // Guardar cambios en la base de datos
                    Orm.bd.SaveChanges();
                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show("Error al modificar los datos: " + ex.Message);
                }
            }
        }

        public static void EliminarLocal(Int32 usuarioId)
        {
            // Empezamos una transacción para asegurar que ambas operaciones ocurren juntas
            using (var transaction = Orm.bd.Database.BeginTransaction())
            {
                try
                {
                    // Buscar el usuario por ID
                    var usuario = Orm.bd.Usuario.FirstOrDefault(u => u.id == usuarioId);
                    if (usuario == null)
                    {
                        throw new Exception("El usuario no existe.");
                    }

                    // Eliminar los locales relacionados con el usuario
                    var locales = Orm.bd.Local.Where(l => l.idUsuario == usuarioId).ToList();
                    Orm.bd.Local.RemoveRange(locales); // Eliminar los locales relacionados

                    // Eliminar el usuario
                    Orm.bd.Usuario.Remove(usuario);

                    // Guardar cambios en la base de datos
                    Orm.bd.SaveChanges();

                    // Confirmar la transacción
                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    // Si ocurre un error, deshacer la transacción
                    transaction.Rollback();
                    throw new Exception("Error al eliminar el usuario: " + ex.Message);
                }
            }
        }

        public static void ModificarUsuarioYMusico(UsuarioMusico usuarioMusicoSeleccionado)
        {
            using (var transaction = Orm.bd.Database.BeginTransaction()) // Iniciar transacción
            {
                try
                {
                    // Buscar el Usuario por ID
                    var usuario = Orm.bd.Usuario.FirstOrDefault(u => u.id == usuarioMusicoSeleccionado.id);
                    if (usuario == null)
                    {
                        throw new Exception("El usuario con el ID proporcionado no existe.");
                    }

                    // Actualizar el Usuario
                    usuario.nombre = usuarioMusicoSeleccionado.nombre;
                    usuario.correo = usuarioMusicoSeleccionado.correo;
                    usuario.contrasenya = usuarioMusicoSeleccionado.contrasenya;
                    usuario.telefono = usuarioMusicoSeleccionado.telefono;

                    // Buscar el Músico relacionado con el Usuario
                    var musico = Orm.bd.Musico.FirstOrDefault(m => m.idUsuario == usuario.id);
                    if (musico == null)
                    {
                        throw new Exception("El músico relacionado con el usuario no existe.");
                    }

                    // Actualizar el Músico
                    musico.apellido = usuarioMusicoSeleccionado.apellido;
                    musico.biografia = usuarioMusicoSeleccionado.biografia;
                    musico.edad = usuarioMusicoSeleccionado.edad;
                    musico.genero = usuarioMusicoSeleccionado.genero;

                    // **Obtener y actualizar los géneros musicales**:
                    // Obtener los géneros musicales seleccionados desde el string
                    var generosSeleccionados = usuarioMusicoSeleccionado.generoMusical.Split(',')
                                                     .Select(g => g.Trim()) // Eliminar espacios alrededor de los géneros
                                                     .ToList();

                    // Eliminar las relaciones anteriores de géneros
                    EliminarGenerosAntiguos(usuario.id);

                    // Agregar las nuevas relaciones de géneros
                    AgregarGenerosMusicales(usuario.id, generosSeleccionados);

                    // Guardar cambios en la base de datos
                    Orm.bd.SaveChanges();
                    transaction.Commit();

                    // Cerrar el formulario o realizar otras acciones
                    // this.Close();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show("Error al modificar los datos del músico: " + ex.Message);
                }
            }
        }

        public static void EliminarGenerosAntiguos(int usuarioId)
        {
            try
            {
                // Eliminar las relaciones anteriores en la tabla GenerosMusicos
                var generosAntiguos = Orm.bd.GenerosMusicos.Where(gm => gm.idMusico == usuarioId).ToList();
                foreach (var genero in generosAntiguos)
                {
                    Orm.bd.GenerosMusicos.Remove(genero);
                }

                Orm.bd.SaveChanges(); // Guardar los cambios
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar los géneros musicales antiguos: " + ex.Message);
            }
        }

        public static void AgregarGenerosMusicales(int usuarioId, List<string> generosSeleccionados)
        {
            try
            {
                foreach (var generoNombre in generosSeleccionados)
                {
                    // Buscar el género musical por nombre
                    var genero = Orm.bd.Generos.FirstOrDefault(g => g.genero.Equals(generoNombre, StringComparison.OrdinalIgnoreCase));

                    if (genero != null)
                    {
                        // Agregar la relación en la tabla GenerosMusicos
                        var nuevoGeneroMusical = new GenerosMusicos
                        {
                            idMusico = usuarioId, // Relacionamos el género con el usuario
                            idGenero = genero.id   // Aquí genero.id es el ID del género musical
                        };
                        Orm.bd.GenerosMusicos.Add(nuevoGeneroMusical);
                    }
                    else
                    {
                        // Si el género no existe en la base de datos, podrías manejarlo aquí (opcional)
                        MessageBox.Show($"El género '{generoNombre}' no existe en la base de datos.");
                    }
                }

                Orm.bd.SaveChanges(); // Guardar los cambios
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar los géneros musicales: " + ex.Message);
            }
        }

        public static void EliminarMusico(Int32 usuarioId)
        {
            // Empezamos una transacción para asegurar que ambas operaciones ocurren juntas
            using (var transaction = Orm.bd.Database.BeginTransaction())
            {
                try
                {
                    // Buscar el usuario por ID
                    var usuario = Orm.bd.Usuario.FirstOrDefault(u => u.id == usuarioId);
                    if (usuario == null)
                    {
                        throw new Exception("El usuario no existe.");
                    }

                    // Eliminar el músico relacionado con el usuario
                    var musico = Orm.bd.Musico.FirstOrDefault(m => m.idUsuario == usuarioId);
                    if (musico != null)
                    {
                        Orm.bd.Musico.Remove(musico); // Eliminar el músico si existe
                    }

                    // Eliminar el usuario
                    Orm.bd.Usuario.Remove(usuario);

                    EliminarGenerosAntiguos(usuario.id);

                    // Guardar cambios en la base de datos
                    Orm.bd.SaveChanges();

                    // Confirmar la transacción
                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    // Si ocurre un error, deshacer la transacción
                    transaction.Rollback();
                    throw new Exception("Error al eliminar el músico: " + ex.Message);
                }
            }
        }

    }
}
