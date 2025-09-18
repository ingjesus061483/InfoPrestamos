using Helper;
using Helper.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EasyCredit.Controllers
{
    public class ReferencesController : Controller
    {
        ReferenciaHelp referenciaHelp;
        List<string> errors;
        public ReferencesController(ReferenciaHelp referenciaHelp)
        {
            this.referenciaHelp = referenciaHelp;
        }
        // GET: References
        public ActionResult Index()
        {
            return View();
        }

        // GET: References/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: References/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: References/Create
        [HttpPost]
        public ActionResult Create(ReferenciaDTO referenciaDTO )
        {
            var url = Url.Action("Details", "client", new { id = referenciaDTO.ClienteId });
            try
            {
                if (ModelState.IsValid)
                {
                    if (referenciaDTO.Id != 0)
                    {
                        referenciaHelp.Actualizar(referenciaDTO.Id, referenciaDTO);
                        return Redirect(url);
                    }
                    referenciaHelp.Guardar(referenciaDTO);
                    return Redirect(url);
                }
                TempData["Error"] = ModelState.Values.SelectMany(x => x.Errors).Select(e => e.ErrorMessage).ToList();
                return Redirect(url);
                // TODO: Add insert logic here
            }
            catch (Exception ex)
            {
                errors = new List<string>
                    {
                        ex.Message
                    };
                TempData["Error"] = errors;
                return Redirect(url);
            }

         
        }

        // GET: References/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: References/Edit/5
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
        // POST: References/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            var url = Url.Action("Details", "client", new { id = collection["ClienteId"] });
            try
            {
                // TODO: Add delete logic here
                referenciaHelp.Eliminar(id);
                return Redirect(url);
            }
            catch (Exception ex)
            {
                {
                    errors = new List<string> {
                    ex.Message
                };
                    TempData["Error"] = errors;
                    return Redirect(url);
                }
            }
        }
    }
}
