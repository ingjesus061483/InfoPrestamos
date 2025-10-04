using EasyCredit.Models;
using Factory;
using Helper;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EasyCredit.Controllers
{
    public class PayController : Controller
    {
        UsuarioDTO usuario;
    PagoHelp _pagoHelp ;
        PrestamoHelp _prestamoHelp ;
        AmortizacionHelp _cuotaHelp;
        List<Message> errors;
        public PayController(AmortizacionHelp cuotaHelp, PagoHelp pagoHelp , PrestamoHelp prestamoHelp)
        {
            _prestamoHelp=prestamoHelp;
            _cuotaHelp = cuotaHelp;
            _pagoHelp = pagoHelp;
        }
        // GET: Pay
        public ActionResult Index(int? CuotaId)
        {
            usuario = (UsuarioDTO)Session["Usuario"];
            if (usuario == null)
            {
                return RedirectToAction("Login", "Employee");
            }     
            ViewBag.usuario = usuario;
            ViewBag.cuota = _cuotaHelp.TEntity.Where(x => x.Id == CuotaId).FirstOrDefault();
            List<PagoDTO> pagos = _pagoHelp.TEntity.Where(z=>z.AmortizacionId==CuotaId) .ToList();
            return View(pagos);
        }
        [HttpPost]
        public ActionResult Create(PagoDTO pagoDTO)
        {
            string url= Url.Action("Index", "Pay", new { CuotaId = pagoDTO.AmortizacionId });
            try
            {
                usuario = (UsuarioDTO)Session["Usuario"];

                if (ModelState.IsValid)
                {
                    if (pagoDTO.Id != 0)
                    {
                        _pagoHelp.Actualizar(pagoDTO.Id, pagoDTO);
                        return Redirect(url);
                    }
                    _pagoHelp.Guardar(pagoDTO);
                    _cuotaHelp.PagarCuota(pagoDTO.AmortizacionId, _pagoHelp.TEntity.Where(z => z.AmortizacionId == pagoDTO.AmortizacionId).Sum(x => x.ValorPagar));
                    var PrestamoId = _cuotaHelp.TEntity.Where(_x => _x.Id == pagoDTO.AmortizacionId).FirstOrDefault().PrestamoId ;
                    var prestamo =_prestamoHelp.TEntity.Where (x=>x.Id ==PrestamoId).FirstOrDefault();
                   var mensaje=$"Total deuda: {prestamo.Total.ToString("C0")+ Environment.NewLine}" +
                        $"total Abonado: {prestamo.TotalAmortizado.ToString("C0")+Environment.NewLine}"+
                        $"Saldo: {prestamo.Saldo.ToString("C0")}";
                    var cliente = prestamo.Cliente;
                    foreach (var tel in cliente.Telefonos)
                    { 
                        Sms.Main(tel.NumeroTelefonico, mensaje); 
                    }
                    return Redirect(url);
                }
                TempData["Error"] = ModelState.Values.SelectMany(x => x.Errors).Select(e => new Message
                {
                    Text = e.ErrorMessage,
                    IsSuccess = false
                }).ToList();
                return Redirect(url);
                // TODO: Add insert logic here

            }
            catch (Exception ex)
            {
                errors = new List<Message> {
                    new Message { Text = ex.Message, IsSuccess = false }

                };
                TempData["Error"] = errors;
                return Redirect(url);
            }        
        }
        [HttpPost]
        public ActionResult Delete(int id)
        {
            return View();
        }
    }
}