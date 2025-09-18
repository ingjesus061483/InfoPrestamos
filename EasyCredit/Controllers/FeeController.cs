using Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EasyCredit.Controllers
{
    public class FeeController : Controller
    {
        CuotaHelp _cuotaHelp;
        public FeeController(CuotaHelp cuotaHelp)
        {
            _cuotaHelp = cuotaHelp;
        }
        public JsonResult Getfee(string fechaIni, int tipocobro, double monto, double porcentajeInteres, double tiempo)
        {
            DateTime fechaIniDt = DateTime.Parse(fechaIni);
            var cuotas = _cuotaHelp.GetCuotas(fechaIniDt, tipocobro, monto, porcentajeInteres / 100, tiempo).Select(z=> new
            {
                z.Codigo,
               Fecha= z.Fecha.ToString("yyyy/MM/dd"),
                z.Valor,
                z.Capital,
                z.Interes,
                z.Saldo
            }).ToList();
            return Json(new { data = cuotas }, JsonRequestBehavior.AllowGet);
        }
        // GET: Fee
        public ActionResult Index()
        {
            return View();
        }
    }
}