using Datos;
using Factory;
using DTO;
using SelectPdf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Helper
{
    public class PagoHelp : Help<PagoDTO>
    {  
        public PagoHelp(PrestamoDbContext dbContext)
        {
            context = dbContext;
        }

        public override IQueryable<PagoDTO> TEntity =>context.Pagos.
            Include("cuotas").
            Include("FormaPagos").
            Include("TipoPagos").
            Include("Empleados").
            Include("usuarios").
            Include("areas").   
            Select(x=>new PagoDTO 
            {
                Id=x.Id,
                AmortizacionId=x.AmortizacionId,
                Fecha=x.Fecha,
                FormaPagoId=x.FormaPagoId,
                TipoPagoId=x.TipoPagoId,
                ValorPagar=x.ValorPagar,
                Referencia=x.Referencia,
                Observaciones=x.Observaciones,
                AmortizacionDTO=new AmortizacionDTO 
                {
                    Id=x.Amortizacion.Id,
                    Periodo=x.Amortizacion.Periodo,
                    Referencia=x.Amortizacion.Referencia,
                    Fecha=x.Amortizacion.Fecha,
                    Valor=x.Amortizacion.Valor,                    
                    PagoCompleto=x.Amortizacion.PagoCompleto,
                    PrestamoId=x.Amortizacion.PrestamoId,                   
                },
                FormaPago=x.FormaPago,
                TipoPago=x.TipoPago,
                EmpleadoId=x.EmpleadoId,
                Empleado= new EmpleadoDTO 
                {
                    Id=x.Empleado.Id,
                    Nombre=x.Empleado.Nombre,
                    Apellido=x.Empleado.Apellido,
                    Identificacion=x.Empleado.Identificacion,
                    Telefono=x.Empleado.Telefono,
                    Direccion=x.Empleado.Direccion,
                    Email=x.Empleado.Email,
                    AreaId=x.Empleado.AreaId,
                    Area=x.Empleado.Area,
                    TipoIdentificacionId=x.Empleado.TipoIdentificacionId,
                    Usuario=new UsuarioDTO
                    {
                        Id = x.Empleado.Usuario.Id,
                        Nombre = x.Empleado.Usuario.Nombre,
                        Password = x.Empleado.Usuario.Password,
                        Role = x.Empleado.Usuario.Role,
                        RoleId = x.Empleado.Usuario.RoleId,
                        Sesion = x.Empleado.Usuario.Sesion
                    },
                    UsuarioId =x.Empleado.UsuarioId,               
                },
            });

        protected override HtmlToPdf HtmlToPdf => throw new NotImplementedException();

        public override void Actualizar(int id, PagoDTO Entity)
        {
            throw new NotImplementedException();
        }

        public override void Eliminar(int id)
        {
            throw new NotImplementedException();
        }

        public override byte[] ExportarPdf(Controller controller, string viewName, object model, PdfPageSize pageSize, PdfPageOrientation pdfOrientation, int webPageWidth)
        {
            throw new NotImplementedException();
        }

        public override void Guardar(PagoDTO Entity)
        {
            Pago pago =new Pago { 
                AmortizacionId=Entity.AmortizacionId,
                Fecha=Entity.Fecha,
                FormaPagoId=Entity.FormaPagoId,
                TipoPagoId=Entity.TipoPagoId,
                ValorPagar=Entity.ValorPagar,
                Referencia=Entity.Referencia,
                Observaciones=Entity.Observaciones,
                EmpleadoId=Entity.EmpleadoId,
            }  ;
            context.Pagos.Add(pago);
            context.SaveChanges();
        }
    }
}
