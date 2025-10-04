using Datos;
using Factory;
using DTO;
using SelectPdf;
using System.Linq;
using System.Web.Mvc;
namespace Helper
{
    public class TelefonoHelp : Help<TelefonoDTO>
    {
        public override IQueryable<TelefonoDTO> TEntity => context.Telefonos            
            .Include("TipoTelefonos")
            .Include("clientes").Select(x => new TelefonoDTO
        {
            Id = x.Id,
            NumeroTelefonico = x.NumeroTelefonico,
            ClienteId = x.ClienteId,
            Cliente =context.Clientes.Where(z=>z.Id== x.Cliente.Id).Select(y=>new ClienteDTO
            {
                Id=y.Id,
                Apellido=y.Apellido,
                Nombre=y.Nombre,
                AreaId=y.AreaId,
                Codigo=y.Codigo,
                Direccion=y.Direccion,
                Email=y.Email,
                EmperesaDondeLabora=y.Email,
                FechaExpedicion=y.FechaExpedicion,
                FechaNacimiento=y.FechaNacimiento,
                Identificacion=y.Identificacion,
                TipoIdentificacionId=y.TipoIdentificacionId,
            }).FirstOrDefault(),
            TipoTelefono = x.TipoTelefono,
            TipoTelefonoId = x.TipoTelefonoId

        });

        protected override HtmlToPdf HtmlToPdf => throw new System.NotImplementedException();

        public TelefonoHelp(PrestamoDbContext _context )
        {
            context = _context;
        }
        public override void Eliminar(int id)
        {
            var telefono = context.Telefonos.Find(id);
            context.Telefonos.Remove(telefono);
            context.SaveChanges();
        }        
        public override void Guardar(TelefonoDTO Entity)
        {
            Telefono telefono = new Telefono
            {                    
                NumeroTelefonico = Entity.NumeroTelefonico,
                ClienteId = Entity.ClienteId,
                TipoTelefonoId =Entity.TipoTelefonoId 
            };
            context.Telefonos.Add(telefono);
            context.SaveChanges();
        }
        public override void Actualizar(int id, TelefonoDTO Entity)
        {
            var telefono = context.Telefonos.Find(id);
            telefono.ClienteId = Entity.ClienteId;
            telefono.NumeroTelefonico =Entity.NumeroTelefonico;
            telefono.TipoTelefonoId =Entity .TipoTelefonoId ;
            context.SaveChanges();
        }

        public override byte[] ExportarPdf(Controller controller, string viewName, object model, PdfPageSize pageSize, PdfPageOrientation pdfOrientation, int webPageWidth)
        {
            throw new System.NotImplementedException();
        }
    }
}
