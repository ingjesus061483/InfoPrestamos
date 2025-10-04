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
    public class TipoRegimenHelp : Help<TipoRegimen>
    {
        public override IQueryable<TipoRegimen> TEntity =>context.TipoRegimens.AsQueryable();

        protected override HtmlToPdf HtmlToPdf => throw new NotImplementedException();

        public TipoRegimenHelp(PrestamoDbContext dbContext) 
        {
             context = dbContext;
        }


        public override void Actualizar(int id, TipoRegimen Entity)
        {
            throw new NotImplementedException();
        }

        public override void Eliminar(int id)
        {
            throw new NotImplementedException();
        }

        public override void Guardar(TipoRegimen Entity)
        {
            throw new NotImplementedException();
        }

        public override byte[] ExportarPdf(Controller controller, string viewName, object model, PdfPageSize pageSize, PdfPageOrientation pdfOrientation, int webPageWidth)
        {
            throw new NotImplementedException();
        }
    }
}
