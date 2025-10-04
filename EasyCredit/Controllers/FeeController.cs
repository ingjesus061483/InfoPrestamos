using DTO;
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
        AmortizacionHelp _cuotaHelp;
        TipoCobroHelp _cobroHelp;
        
        public FeeController(AmortizacionHelp cuotaHelp,TipoCobroHelp tipoCobroHelp)
        {
            _cuotaHelp = cuotaHelp;
            _cobroHelp = tipoCobroHelp;
        }
        [HttpGet]
        public JsonResult GetfeeById(int id)
        {
            var cuota=_cuotaHelp.TEntity.Where(z => z.Id == id).FirstOrDefault();
            return Json(new { data = cuota }, JsonRequestBehavior.AllowGet);
        } 

        [HttpGet]
        public JsonResult Getfee(string fechaIni, int tipocobro, double monto, double porcentajeInteres, double tiempo)
        {
            DateTime fechaIniDt = DateTime.Parse(fechaIni);
           var cobro= _cobroHelp.TEntity.Where (x=>x.Id == tipocobro).FirstOrDefault();
            var AmortizacionCapitals = _cuotaHelp.GetAmortizacionCapitals(porcentajeInteres/100,tiempo,monto ,out double fee ).Select(z=> new
            {
                z.Periodo,               
                z.Interes,
                z.Capital,
                z.Saldo,               
            }).ToList();
            var Amortizacion = _cuotaHelp.GetAmortizacions(cobro.Valor,tiempo ,fechaIniDt , fee * tiempo).Select(x => new 
            {
                x.Referencia,
                x.Periodo,
                Fecha=    x.Fecha.ToString("yyyy-MM-dd"),
               x.Valor
            }
            ).ToList();

            return Json(new {  AmortizacionCapitals,  Amortizacion ,cuota= fee.ToString("N2"), Total =(fee*tiempo).ToString("N2") }, JsonRequestBehavior.AllowGet);
        }
        // GET: Fee
        public ActionResult Index()
        {
            return View();
        }
    }
}