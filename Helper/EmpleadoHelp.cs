using Datos;
using DTO;
using Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Helper
{
    public class EmpleadoHelp:Help
    {
        public EmpleadoHelp(PrestamoDbContext dbContext)
        {
            context = dbContext ;
        }
        public IQueryable <EmpleadoDTO> Empleados
        {
            get
            {
                return context.Empleados.Include("Usuarios").Include("Roles"). Include("TipoIdentificacions").Select(x => new EmpleadoDTO
                {
                    Id = x.Id,
                    Identificacion = x.Identificacion,
                    Nombre = x.Nombre,
                    Apellido = x.Apellido,
                    Direccion = x.Direccion,
                    FechaNacimiento = x.FechaNacimiento,
                    Email = x.Email,
                    Telefono = x.Telefono,
                    TipoIdentificacion = x.TipoIdentificacion,
                    TipoIdentificacionId = x.TipoIdentificacionId,
                    UsuarioId = x.UsuarioId,
                    Usuario = x.Usuario,
                    Role =context .Roles .Where(z=>z.Id == x.Usuario .RoleId ).FirstOrDefault().Nombre
                });
            }
        }
        public override void Actualizar(int id, Dictionary<string, object> collection)
        {
            var cliente = context.Empleados .Find(id);
            cliente.Identificacion = collection["Identificacion"].ToString();
            cliente.Nombre = collection["Nombre"].ToString();
            cliente.Apellido = collection["Apellido"].ToString();
            cliente.Direccion = collection["Direccion"].ToString();
            cliente.Telefono = collection["Telefono"].ToString();
            cliente.Email = collection["Email"].ToString();
            cliente.FechaNacimiento = (DateTime)collection["FechaNacimiento"];
            cliente.TipoIdentificacionId = int.Parse(collection["TipoIdentificacionId"].ToString());
            context.SaveChanges();
        }

        public override void Actualizar(int id, FormCollection collection)
        {
            throw new NotImplementedException();
        }

        public override void Eliminar(int id)
        {
            var empleado = context.Empleados.Find(id);
            context .Empleados .Remove(empleado );
            context.SaveChanges();
        }
        public override void Guardar(Dictionary<string, object> collection)
        {
            Empleado cliente = new Empleado
            {
                Identificacion = collection["Identificacion"].ToString(),
                Nombre = collection["Nombre"].ToString(),
                Apellido = collection["Apellido"].ToString(),
                Direccion = collection["Direccion"].ToString(),
                Telefono = collection["Telefono"].ToString(),
                Email = collection["Email"].ToString(),
                FechaNacimiento = (DateTime)collection["FechaNacimiento"],
                TipoIdentificacionId = int.Parse(collection["TipoIdentificacionId"].ToString()),
                UsuarioId = int.Parse( collection["usuario"].ToString()),
            };
            context.Empleados.Add(cliente);
            context.SaveChanges();
        }

        public override void Guardar(FormCollection collection)
        {
            throw new NotImplementedException();
        }
    }
}
