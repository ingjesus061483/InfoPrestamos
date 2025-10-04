using Datos;
using Factory;
using SelectPdf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Helper
{
    public class TipoTelefonoHelp : Help<TipoTelefono>
    {
        public  TipoTelefonoHelp(PrestamoDbContext _context)
        {
            context = _context;
        }
        public override IQueryable<TipoTelefono> TEntity =>  context.TipoTelefonos.AsQueryable();

        protected override HtmlToPdf HtmlToPdf => throw new NotImplementedException();

        public override void Actualizar(int id, TipoTelefono Entity)
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

        public override void Guardar(TipoTelefono Entity)
        {
            throw new NotImplementedException();
        }
    }
}
