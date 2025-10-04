using DTO;
using Factory;
using Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EasyCredit.Models;

namespace EasyCredit.Controllers
{
    public class CompanyController : Controller
    {
        UsuarioDTO usuario;
        EmpresaHelp EmpresaHelp;
        TipoRegimenHelp TipoRegimenHelp;
        TipoIdentificacionHelp TipoIdentificacionHelp;

        public CompanyController(TipoRegimenHelp tipoRegimenHelp,TipoIdentificacionHelp tipoIdentificacionHelp, EmpresaHelp empresaHelp)
        {
            TipoIdentificacionHelp = tipoIdentificacionHelp;
            TipoRegimenHelp = tipoRegimenHelp;
            EmpresaHelp=empresaHelp;
        }
        [HttpGet]
        public JsonResult Search()
        {
            var company =EmpresaHelp.TEntity.ToList()[0];
            return Json(new { data = company }, JsonRequestBehavior.AllowGet);

        }
        // GET: Company
        public ActionResult Index()
        {
            usuario = (UsuarioDTO)Session["Usuario"];
            if (usuario == null)
            {
                return RedirectToAction("Login", "Employee");
            }
            ViewBag.usuario = usuario;
          ViewBag.tipoIdentificacions=TipoIdentificacionHelp .TEntity.ToList();
            ViewBag.tipoRegimen = TipoRegimenHelp.TEntity.ToList();
            return View(EmpresaHelp.TEntity .ToList());
        }

        // GET: Company/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Company/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Company/Create
        [HttpPost]
        public ActionResult Create(EmpresaDTO empresaDTO)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    if (empresaDTO.Id != 0)
                    {
                       EmpresaHelp.Actualizar(empresaDTO.Id, empresaDTO);
                        return RedirectToAction("Index");
                    }
                    EmpresaHelp.Guardar(empresaDTO);
                    return RedirectToAction("Index");
                }
                TempData["Error"] = ModelState.Values.SelectMany(x => x.Errors).Select(e => new Message
                {
                    Text = e.ErrorMessage,
                    IsSuccess = false
                }).ToList();
                return RedirectToAction("Index");
                // TODO: Add insert logic here

            }
            catch (Exception ex)
            {
                var errors = new List<Message> {
                    new Message { Text = ex.Message, IsSuccess = false }

                };
                TempData["Error"] = errors;
                return RedirectToAction("Index");
            }
            
        }

        // GET: Company/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Company/Edit/5
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

        // GET: Company/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Company/Delete/5
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
