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
    public class PrestamoHelp : Help<PrestamoDTO>
    {
        public PrestamoHelp(PrestamoDbContext dbContext  )
        {
            context = dbContext;
        }
        public override IQueryable<PrestamoDTO> TEntity => context.Prestamos.
            Include("Clientes").
            Include("Telefonos").
            Include("Areas").
            Include("TipoTelefonos").
            Include("Fiadores").    
            Include("Empleados").
            Include("TipoCobros").
            Include("Cuotas").
            Include ("Pagos")
            .Select(x => new PrestamoDTO
            {
                Id = x.Id,
                Referencia = x.Referencia,
                Fecha = x.Fecha,
                Monto = x.Monto,
                TipoCobro = x.TipoCobro,
                TipoCobroId = x.TipoCobroId,
                Tiempo = x.Tiempo,
                Interes = x.Interes,
                Cliente =new ClienteDTO
                { 
                    Id = x.Cliente.Id,
                    Nombre = x.Cliente.Nombre,
                    Apellido =x.Cliente.Apellido,
                    Codigo = x.Cliente.Codigo,
                    Direccion = x.Cliente.Direccion,
                    Email = x.Cliente.Email,
                    EmperesaDondeLabora = x.Cliente.EmperesaDondeLabora,
                    FechaExpedicion = x.Cliente.FechaExpedicion,
                    FechaNacimiento = x.Cliente.FechaNacimiento,
                    Identificacion = x.Cliente.Identificacion,
                    TipoIdentificacionId = x.Cliente.TipoIdentificacionId,                    
                    AreaId = x.Cliente.AreaId,
                    Area=x.Cliente.Area,
                    Telefonos=x.Cliente.Telefonos.Select(y=>new TelefonoDTO 
                    {
                        Id=y.Id,
                        ClienteId=y.ClienteId,
                        NumeroTelefonico=y.NumeroTelefonico,
                        TipoTelefonoId=y.TipoTelefonoId,
                        TipoTelefono=y.TipoTelefono,
                    }).ToList(),
                },
                ClienteId = x.ClienteId,
                Empleado = context.Empleados.Where(z=>z.Id == x.EmpleadoId).Select (y=>new EmpleadoDTO 
                {
                    Id = y.Id,
                    Nombre = y.Nombre,
                    Apellido = y.Apellido,
                    AreaId = y.AreaId,
                    Direccion = y.Direccion,
                    Email   = y.Email,
                    Identificacion = y.Identificacion,
                    TipoIdentificacionId = y.TipoIdentificacionId,
                    UsuarioId = y.UsuarioId,
                }).FirstOrDefault (),
                EmpleadoId = x.EmpleadoId,
                Fiador = context .Fiadors.Where(z=>z.Id== x.FiadorId).Select(y=> new FiadorDTO
                {
                    Id = y.Id,
                    Nombre = y.Nombre,
                    Apellido = y.Apellido,
                    Identificacion = y.Identificacion,
                    Direccion = y.Direccion,
                    Telefono = y.Telefono,
                    Email = y.Email,
                    EmperesaDondeLabora = y.EmperesaDondeLabora,
                    FechaNacimiento = y.FechaNacimiento,
                    TipoIdentificacionId = y.TipoIdentificacionId,
                }).FirstOrDefault(),
                FiadorId = x.FiadorId,
                EstadoId=x.EstadoId,
                Estado = x.Estado,
                Observacion = x.Observacion,
                Amortizacions = x.Amortizacions.Select(y => new AmortizacionDTO
                {
                    Id = y.Id,
                Periodo = y.Periodo,
                Referencia=y.Referencia,
                    Fecha = y.Fecha,
                    Valor = y.Valor,
                    PrestamoId = y.PrestamoId,
                    PagoCompleto = y.PagoCompleto,
                    Pagos = y.Pagos.Select(z => new PagoDTO
                    {
                        Id = z.Id,
                        AmortizacionId = z.AmortizacionId,
                        Fecha = z.Fecha,
                        FormaPagoId = z.FormaPagoId,
                        TipoPagoId = z.TipoPagoId,
                        ValorPagar = z.ValorPagar,
                        Referencia = z.Referencia,
                        Observaciones = z.Observaciones,
                        EmpleadoId = z.EmpleadoId,
                    }).ToList()
                }).ToList(),
            });

        protected override HtmlToPdf HtmlToPdf => new HtmlToPdf ();

        public override void Actualizar(int id, PrestamoDTO Entity)
        {
            throw new NotImplementedException();
        }

        public override void Eliminar(int id)
        {
            Prestamo prestamo = context.Prestamos.Find(id);
            context.Prestamos.Remove(prestamo);
            context.SaveChanges();
        }

        public override byte[] ExportarPdf(Controller controller, string viewName, object model, PdfPageSize pageSize, PdfPageOrientation pdfOrientation, int webPageWidth)
        {
            HtmlToPdf.Options.PdfPageSize = pageSize;
            HtmlToPdf.Options.PdfPageOrientation = pdfOrientation;
            HtmlToPdf.Options.WebPageWidth = webPageWidth;
            var html=RenderRazorViewToString(controller, viewName, model);
            PdfDocument pdfDocument = HtmlToPdf.ConvertHtmlString(html);
            byte[] bytes = pdfDocument.Save();
            pdfDocument.Close();
            return bytes;
        }

        public override void Guardar(PrestamoDTO Entity)
        {            
            Prestamo prestamo = new Prestamo
            {
                Referencia = Entity.Referencia,
                Monto = Entity.Monto,
                Tiempo =Entity. Tiempo,
                Interes =Entity.Interes,
                Fecha = Entity.Fecha,
                Observacion = Entity.Observacion,
                EstadoId =Entity.EstadoId,
                ClienteId =Entity.ClienteId,
                TipoCobroId = Entity.TipoCobroId,
                FiadorId = Entity.FiadorId ==0 ? null : Entity.FiadorId,
                EmpleadoId =Entity .EmpleadoId ,
                Amortizacions = Entity.Amortizacions.Select(x=>new Amortizacion
                {
                    Referencia = x.Referencia,
                    Periodo = x.Periodo,
                    Fecha = x.Fecha,
                   Valor= x.Valor,
                }).ToList()

            };
            context.Prestamos.Add(prestamo);
            context.SaveChanges();              
        }
    }
}
