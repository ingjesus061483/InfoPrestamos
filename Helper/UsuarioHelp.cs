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
    public class UsuarioHelp : Help
    {
        
        public UsuarioHelp(PrestamoDbContext dbContext)
        {
            context = dbContext;
        }
        public  IQueryable <UsuarioDTO> Usuarios
        {
            get
            {
                return context.Usuarios.Include("Empleadoes").Include("Roles").Select(x => new UsuarioDTO
                {
                    Id = x.Id,
                    Nombre = x.Nombre,
                    Password = x.Password,
                    RoleId = x.RoleId,
                    Role = x.Role,
                    Sesion=x.Sesion ,
                    Empleados = x.Empleados
                });
            }
        }

        public override void Actualizar(int id, Dictionary<string, object> collection)
        {
            Usuario Usuario = context.Usuarios.Find(id);
            Usuario.Password = Usuario.Encriptar(collection["password"].ToString());
            Usuario.RoleId = int.Parse(collection["Role"].ToString());           
            context.SaveChanges();
        }
        public override void Eliminar(int id)
        {
            Usuario Usuario = context.Usuarios.Find(id);
            context.Usuarios.Remove(Usuario);
            context.SaveChanges();

        }
        public override void Guardar(Dictionary<string, object> collection)
        {
            Usuario Usuario = new Usuario(collection["Nombre"].ToString(), collection["password"].ToString(),int.Parse (collection["Role"].ToString()));
            context.Usuarios.Add(Usuario);
            context.SaveChanges();
        }
        public void ActivarSesion(int id,bool sesion)
        {
            Usuario Usuario = context.Usuarios.Find(id);
            Usuario.Sesion = sesion;
            context.SaveChanges();
        }

        public override void Guardar(FormCollection collection)
        {
            throw new NotImplementedException();
        }

        public override void Actualizar(int id, FormCollection collection)
        {
            throw new NotImplementedException();
        }
    }
}
