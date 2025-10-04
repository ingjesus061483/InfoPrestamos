using Datos;
using SelectPdf;
using System.IO;
using System.Linq;
using System.Web.Mvc;
namespace Helper
{
    public abstract  class Help<T>
    {
        protected PrestamoDbContext context;
        protected abstract HtmlToPdf HtmlToPdf { get; }

        public abstract IQueryable<T> TEntity { get; }
        public abstract void Guardar(T Entity);
        public abstract void Actualizar(int id, T Entity);
        public abstract void Eliminar(int id);
        public abstract byte[] ExportarPdf(Controller controller, string viewName, object model, PdfPageSize pageSize, PdfPageOrientation pdfOrientation, int webPageWidth);
        protected string RenderRazorViewToString( Controller controller, string viewName, object model)
        {
            controller.ViewData.Model = model;
            string convert;
            using (var sw = new StringWriter())
            {
                var viewResult = ViewEngines.Engines.FindPartialView(controller.ControllerContext,
                                                                         viewName);
                var viewContext = new ViewContext(controller.ControllerContext, viewResult.View,
                                            controller.ViewData, controller.TempData, sw);
                viewResult.View.Render(viewContext, sw);
                viewResult.ViewEngine.ReleaseView(controller.ControllerContext, viewResult.View);
                convert = sw.GetStringBuilder().ToString();
            }
            return convert;
        }
        /*public HtmlToPdf GetHtmlToPdf(PdfPageSize pageSize, PdfPageOrientation pdfOrientation,
                              int webPageWidth)
        {
            HtmlToPdf htmlToPdf = new HtmlToPdf();
            htmlToPdf.Options.PdfPageSize = pageSize;
            htmlToPdf.Options.PdfPageOrientation = pdfOrientation;
            htmlToPdf.Options.WebPageWidth = webPageWidth;
            return htmlToPdf;
        }
        public byte[] ConvertPdfToByte(Controller controller, string viewName, object model, HtmlToPdf htmlToPdf)
        {
            var html=RenderRazorViewToString(controller, viewName,  model);
            PdfDocument pdfDocument = htmlToPdf.ConvertHtmlString(html);
            byte[] bytes = pdfDocument.Save();
            pdfDocument.Close();
            return bytes;
        }*/
   
    }
}
