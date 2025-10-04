
using Factory;
using Helper;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Biblioteca_app.Extensions
{
    public static class ControllerExtensions
    {
        public static List<SelectListItem> GetSelectList(this Controller controller, object model)
        {
           
            List<SelectListItem> result = new List<SelectListItem>();
            try
            {
                List < TipoIdentificacion > tipos = (List<TipoIdentificacion>)model;
                foreach (TipoIdentificacion tipoIdentificacion in tipos)
                {
                    SelectListItem item = new SelectListItem
                    {
                        Text = tipoIdentificacion.Nombre,
                        Value = tipoIdentificacion.Id.ToString(),
                    };
                    result.Add(item);
                }
            }
            catch
            {
                result = new List<SelectListItem>();
            }

            return result;
        }
        public static  string RenderRazorViewToString(this Controller controller,string viewName, object model)
        {
            controller. ViewData.Model  = model;        
            string convert;
            using (var sw = new StringWriter())
            {
                var viewResult = ViewEngines.Engines.FindPartialView(controller. ControllerContext,
                                                                         viewName);
                var viewContext = new ViewContext(controller. ControllerContext, viewResult.View,
                                            controller. ViewData,controller. TempData, sw);
                viewResult.View.Render(viewContext, sw);
                viewResult.ViewEngine.ReleaseView(controller. ControllerContext, viewResult.View);
               convert= sw.GetStringBuilder().ToString();
            }
            return convert;
        }
    }
}
