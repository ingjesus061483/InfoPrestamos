using Datos;
using Factory;
using SelectPdf;
using System;
using System.Linq;
using System.Web.Mvc;

namespace Helper
{
    public  class RoleHelp : Help<Role>
    {
        public RoleHelp(PrestamoDbContext dbContext)
        {
            context = dbContext;
        }
        public override IQueryable<Role> TEntity => context.Roles.AsQueryable();

        protected override HtmlToPdf HtmlToPdf => throw new NotImplementedException();

        public override void Actualizar(int id, Role Entity)
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

        public override void Guardar(Role Entity)
        {
            throw new NotImplementedException();
        }
    }
}
