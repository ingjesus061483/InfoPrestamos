using Datos;
using DTO;
using Factory;
using System.Linq;
namespace Helper
{
    public class FiadorHelp:Help<FiadorDTO>
    {
        public FiadorHelp (PrestamoDbContext dbContext)
        {
            context = dbContext;
        }
        public override IQueryable<FiadorDTO> TEntity => context.Fiadors.Include("TipoIdentificaciones").Select(x => new FiadorDTO
        {
            Id = x.Id,
            Identificacion = x.Identificacion,
            Nombre = x.Nombre,
            Apellido = x.Apellido,
            Direccion = x.Direccion,
            EmperesaDondeLabora = x.EmperesaDondeLabora,
            FechaNacimiento = x.FechaNacimiento,
            Email = x.Email,
            Telefono = x.Telefono,
            TipoIdentificacion = x.TipoIdentificacion,
            TipoIdentificacionId = x.TipoIdentificacionId
        });


        public override void Actualizar(int id, FiadorDTO Entity)
        {
            var Fiador = context.Fiadors.Find(id);
            Fiador.Identificacion = Entity.Identificacion;
            Fiador.Nombre = Entity.Nombre;
            Fiador.Apellido =Entity.Apellido;
            Fiador.Direccion =Entity .Direccion;
            Fiador.Telefono =Entity.Telefono;
            Fiador.Email =Entity. Email;
            Fiador.EmperesaDondeLabora =Entity .EmperesaDondeLabora;
            Fiador.FechaNacimiento =Entity.FechaNacimiento;
            Fiador.TipoIdentificacionId = Entity .TipoIdentificacionId;
            context.SaveChanges();
        }

        public override void Eliminar(int id)
        {
            var Fiador = context.Fiadors.Find(id);
            context.Fiadors.Remove(Fiador);
            context.SaveChanges();
        }
        
        public override void Guardar(FiadorDTO Entity)
        {

            Fiador Fiador = new Fiador
            {
                Identificacion = Entity.Identificacion,
                Nombre = Entity .Nombre,
                Apellido =Entity .Apellido,
                Direccion =Entity .Direccion,
                Telefono =Entity .Telefono,
                Email = Entity .Email,
                EmperesaDondeLabora =Entity .EmperesaDondeLabora,
                FechaNacimiento =Entity .FechaNacimiento,
                TipoIdentificacionId =Entity.TipoIdentificacionId,
            };
            context.Fiadors.Add(Fiador);
            context.SaveChanges();
        }
    }
}
