using DTO;
using EasyCredit.Models;
using Factory;
using Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EasyCredit.Controllers
{
    public class LoanController : Controller
    {
        private readonly ClienteHelp _clienteHelp;
        private readonly PrestamoHelp _prestamoHelp;
        private readonly TipoCobroHelp _tipoCobroHelp;
        List <PrestamoDTO> prestamos;
        public LoanController(ClienteHelp clienteHelp,PrestamoHelp prestamoHelp,TipoCobroHelp tipoCobroHelp)
        {
            _clienteHelp = clienteHelp;
            _prestamoHelp = prestamoHelp;
            _tipoCobroHelp = tipoCobroHelp;
            
        }
        // GET: Loan
        public ActionResult Index(string identificacion)
        {
            ViewBag.EmpleadoId =1 ;
            ViewBag.Tipocobro=_tipoCobroHelp.TEntity.ToList();
            if (!string.IsNullOrEmpty(identificacion))
            {
                var cliente = _clienteHelp.TEntity.Where( x=> x.Identificacion==identificacion).FirstOrDefault();
                if (cliente == null)
                {      
                    prestamos = _prestamoHelp.TEntity.ToList();
                    List<Message> messages = new List<Message> 
                    {
                        new Message { IsSuccess = false, Text = "Cliente no encontrado." }
                    };
                    TempData["error"]  = messages;
                    return View(prestamos);

                }
                prestamos = cliente.Prestamos;
                ViewBag.Cliente = cliente;
                return View(prestamos);
            }
            else
            {
                List<Message> messages = new List<Message>
                    {
                        new Message { IsSuccess = false, Text = "Por favor ingrese una identificación." }
                    };
                TempData["error"] = messages;
               
            }
             prestamos = _prestamoHelp.TEntity.ToList(); 
            return View(prestamos );
        }

        // GET: Loan/Details/5
        public ActionResult Details(int id)
        {
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
