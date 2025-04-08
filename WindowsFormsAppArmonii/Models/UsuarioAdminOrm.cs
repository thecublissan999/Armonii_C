using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static WindowsFormsAppArmonii.Models.AdminOrm;
using System.Windows.Forms;

namespace WindowsFormsAppArmonii.Models
{
    public static class UsuarioAdminOrm
    {
        public static UsuarioAdmin SelectLogin(string correo)
        {            
                return Orm.bd.UsuarioAdmin.FirstOrDefault(c => c.correo == correo);
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

        public static bool ComprobarCorreo(string correo)
        {
            // Verifica si el correo ya existe en la base de datos
            return Orm.bd.UsuarioAdmin.Any(u => u.correo == correo);
        }

    }
}
