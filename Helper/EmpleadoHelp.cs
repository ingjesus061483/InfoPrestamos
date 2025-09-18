using Datos;
using DTO;
using Factory;
using System.Linq;
namespace Helper
{
    public class EmpleadoHelp:Help<EmpleadoDTO>
    {
        public EmpleadoHelp(PrestamoDbContext dbContext)
        {
            context = dbContext ;
        }
        public override  IQueryable <EmpleadoDTO> TEntity=>context.Empleados.
                    Include("Areas"). 
                    Include("Usuarios").
                    Include("Roles"). 
                    Include("TipoIdentificaciones").Select(x => new EmpleadoDTO
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
                        Role =context .Roles .Where(z=>z.Id == x.Usuario .RoleId ).FirstOrDefault().Nombre,
                        Area = x.Area,
                        AreaId = x.AreaId                   
                    });     
        public override void Actualizar(int id, EmpleadoDTO Entity)
        {
            var cliente = context.Empleados.Find(id);
            cliente.Identificacion = Entity.Identificacion;
            cliente.Nombre =Entity.Nombre;
            cliente.Apellido = Entity.Apellido;
            cliente.Direccion = Entity.Direccion;
            cliente.Telefono = Entity.Telefono;
            cliente.Email =Entity.Email;
            cliente.FechaNacimiento = Entity.FechaNacimiento;
            cliente.TipoIdentificacionId = Entity.TipoIdentificacionId;
            cliente.AreaId = Entity.AreaId;
            context.SaveChanges();            
        }

        public override void Eliminar(int id)
        {
            var empleado = context.Empleados.Find(id);
            context .Empleados .Remove(empleado );
            context.SaveChanges();
        }
        public override void Guardar(EmpleadoDTO Entity)
        {
            Empleado cliente = new Empleado
            {
                Identificacion = Entity.Identificacion ,
                Nombre = Entity.Nombre,
                Apellido =Entity .Apellido,
                Direccion = Entity.Direccion,
                Telefono = Entity.Telefono,
                Email = Entity.Email,
                FechaNacimiento =Entity.FechaNacimiento,
                TipoIdentificacionId =Entity.TipoIdentificacionId,
                UsuarioId =Entity.UsuarioId,
                AreaId = Entity.AreaId,            
            };
            context.Empleados.Add(cliente);
            context.SaveChanges();
        }    
    }
}
