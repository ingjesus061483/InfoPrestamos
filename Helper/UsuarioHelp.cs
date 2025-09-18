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
    public class UsuarioHelp : Help<UsuarioDTO>
    {
        
        public UsuarioHelp(PrestamoDbContext dbContext)
        {
            context = dbContext;
        }
  
        public override IQueryable<UsuarioDTO> TEntity => context.Usuarios.
            Include("Empleados")
            .Include("Roles").
            Select(x => new UsuarioDTO
            {
                Id = x.Id,
                Nombre = x.Nombre,
                Password = x.Password,
                RoleId = x.RoleId,
                Role = x.Role,
                Sesion = x.Sesion,
                Empleados = x.Empleados
            });

        public override void Eliminar(int id)
        {
            Usuario Usuario = context.Usuarios.Find(id);
            context.Usuarios.Remove(Usuario);
            context.SaveChanges();

        }
        public void ActivarSesion(int id,bool sesion)
        {
            Usuario Usuario = context.Usuarios.Find(id);
            Usuario.Sesion = sesion;
            context.SaveChanges();
        }

        public override void Guardar(UsuarioDTO Entity)
        {
            Usuario Usuario = new Usuario(Entity.Nombre,Entity .Password , Entity.RoleId );
            context.Usuarios.Add(Usuario);
            context.SaveChanges();
        }

        public override void Actualizar(int id, UsuarioDTO Entity)
        {
            Usuario Usuario = context.Usuarios.Find(id);
            Usuario.Password = Usuario.Encriptar(Entity.Password);
            Usuario.RoleId =Entity.RoleId ;
            context.SaveChanges();
        }
    }
}
