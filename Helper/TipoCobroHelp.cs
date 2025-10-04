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
    public class TipoCobroHelp:Help<TipoCobro>
    {
        public override IQueryable<TipoCobro> TEntity => context.TipoCobros.AsQueryable();

        protected override HtmlToPdf HtmlToPdf => throw new NotImplementedException();

        public TipoCobroHelp(PrestamoDbContext dbContext )
        {
            context = dbContext ;
        }
        public override void Eliminar(int id)
        {
            throw new NotImplementedException();
        }
        public override void Guardar(TipoCobro Entity)
        {
            throw new NotImplementedException();
        }
        public override void Actualizar(int id, TipoCobro Entity)
        {
            throw new NotImplementedException();
        }

        public override byte[] ExportarPdf(Controller controller, string viewName, object model, PdfPageSize pageSize, PdfPageOrientation pdfOrientation, int webPageWidth)
        {
            throw new NotImplementedException();
        }
    }
}
