using Biblioteca_app.Extensions;
using DTO;
using EasyCredit.Models;
using Factory;
using Helper;
using SelectPdf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EasyCredit.Controllers
{
    public class LoanController : Controller
    {
        PdfPageSize PageSize => PdfPageSize.A4;
        PdfPageOrientation PdfOrientation =>PdfPageOrientation.Portrait;
        int WebPageWidth => 1500;
        UsuarioDTO usuario;
        private readonly ClienteHelp _clienteHelp;
        private readonly PrestamoHelp _prestamoHelp;
        private readonly TipoCobroHelp _tipoCobroHelp;
        private readonly TipoPagoHelp _tipoPagoHelp;
        private readonly FormaPagoHelp _formapagoHelp;
        List <PrestamoDTO> prestamos;
        public LoanController(FormaPagoHelp formaPagoHelp, ClienteHelp clienteHelp,PrestamoHelp prestamoHelp,
            TipoCobroHelp tipoCobroHelp,TipoPagoHelp tipoPagoHelp)
        {
            _formapagoHelp= formaPagoHelp;
            _clienteHelp = clienteHelp;
            _prestamoHelp = prestamoHelp;
            _tipoCobroHelp = tipoCobroHelp;
            _tipoPagoHelp = tipoPagoHelp;
        }
        [HttpGet]
        // GET: Loan
        public ActionResult Index(string identificacion)
        {
            usuario = (UsuarioDTO)Session["Usuario"];
            if (usuario == null)
            {
                return RedirectToAction("Login", "Employee");
            }
            ViewBag.usuario = usuario;
            ViewBag.EmpleadoId =usuario.Empleados[0].Id ;
            ViewBag.Tipocobro=_tipoCobroHelp.TEntity.ToList();
            if (string.IsNullOrEmpty(identificacion))
            { 
                List<Message> messages = new List<Message>
                {
                    new Message { IsSuccess = false, Text = "Por favor ingrese una identificación." }
                };
                TempData["error"] = messages;
                prestamos = _prestamoHelp.TEntity.ToList(); 
                return View(prestamos );
            }
            var cliente = _clienteHelp.TEntity.Where(x => x.Identificacion == identificacion).FirstOrDefault();
            if (cliente == null)
            {
                prestamos = _prestamoHelp.TEntity.ToList();
                List<Message> messages = new List<Message>
                    {
                        new Message { IsSuccess = false, Text = "Cliente no encontrado." }
                    };
                TempData["error"] = messages;
                return View(prestamos);
            }
            prestamos = _prestamoHelp.TEntity.Where(x=>x.ClienteId==cliente.Id) .ToList();
            ViewBag.Cliente = cliente;
            return View(prestamos);
        }

        [HttpGet]
        // GET: Loan/Details/5
        public ActionResult Details(int id)
        {
            usuario = (UsuarioDTO)Session["Usuario"];
            if (usuario == null)
            {
                return RedirectToAction("Login", "Employee");
            }
            ViewBag.usuario = usuario;
            ViewBag.FormasPagos = _formapagoHelp.TEntity.ToList();
            ViewBag.TipoPagos = _tipoPagoHelp.TEntity.ToList();
            var prestamo = _prestamoHelp.TEntity.Where(z=>z.Id==id).FirstOrDefault();
            return View(prestamo);
        }

        // GET: Loan/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Loan/Create
        [HttpPost]
        public JsonResult Create(PrestamoDTO prestamoDTO)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    if (prestamoDTO.Id != 0)
                    {
                       _prestamoHelp. Actualizar(prestamoDTO.Id, prestamoDTO);
                        return Json(new { data = "El registro se ha actualizado" }, JsonRequestBehavior.AllowGet);
                    }
                    _prestamoHelp.Guardar(prestamoDTO);
                    return Json(new { data = "Has registrado un prestamo" }, JsonRequestBehavior.AllowGet);

                }
                var errors= ModelState.Values.SelectMany(x => x.Errors).Select(e => new Message
                {
                    Text = e.ErrorMessage,
                    IsSuccess = false
                }).ToList();
                TempData["Error"] = errors;
                // TODO: Add insert logic here

                return Json(new { data = errors }, JsonRequestBehavior.AllowGet);

            }
            catch (Exception ex) 
            {
                var errors = new List<Message> {
                    new Message {
                         Text = ex.Message,
                    IsSuccess = false
                    }
                };
                TempData["Error"] = errors;
                return Json(new { data = errors }, JsonRequestBehavior.AllowGet);
            }
        }

        // GET: Loan/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Loan/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
        public ActionResult PayHistorial(int idprestamo)
        {
            usuario = (UsuarioDTO)Session["Usuario"];
            if (usuario == null)
            {
                return RedirectToAction("Login", "Employee");
            }
            ViewBag.Empresa = usuario.Empleados[0].EmpresaDTO;
            var prestamo=   _prestamoHelp.TEntity.Where(x=>x.Id ==idprestamo).FirstOrDefault();
          //  string htmlString = this.RenderRazorViewToString("PayHistorial", prestamo );
            //PdfPageSize pageSize = PdfPageSize.A4;
            //PdfPageOrientation pdfOrientation = PdfPageOrientation.Portrait;
           // int webPageWidth = 1500;
            byte[] pdf = _prestamoHelp.ExportarPdf(this, "PayHistorial", prestamo, PageSize, PdfOrientation, WebPageWidth);

            return File(pdf, "application/pdf"); 
            
        }
        public ActionResult LoanHistorial()
        {
            usuario = (UsuarioDTO)Session["Usuario"];
            if (usuario == null)
            {
                return RedirectToAction("Login", "Employee");
            }
            
            ViewBag.Empresa = usuario.Empleados[0].EmpresaDTO;
            int id = usuario.Empleados[0].Id;
            var prestamos  = _prestamoHelp.TEntity.Where(x => x.EmpleadoId == id ).ToList();
         //   string htmlString = this.RenderRazorViewToString("LoanHistorial", prestamos);         
            byte[] pdf = _prestamoHelp.ExportarPdf(this, "LoanHistorial",prestamos , PageSize,PdfOrientation,WebPageWidth);
            return File(pdf, "application/pdf");                
        }

        // GET: Loan/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Loan/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
