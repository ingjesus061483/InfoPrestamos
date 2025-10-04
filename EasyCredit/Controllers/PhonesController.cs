using Helper;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Web;
using System.Web.Mvc;

namespace EasyCredit.Controllers
{
    public class PhonesController : Controller
    {
        List<string> errors;

        TelefonoHelp telefonoHelp;

        public PhonesController(TelefonoHelp telefonoHelp)
        {
            this.telefonoHelp = telefonoHelp;
        }
        public JsonResult SearchPhone(int id)
        {
            TelefonoDTO telefonoDTO = telefonoHelp.TEntity.Where(x => x.Id == id).FirstOrDefault();
            return Json(new { data = telefonoDTO }, JsonRequestBehavior.AllowGet);


        }
        // GET: Phones
        public ActionResult Index()
        {
            return View();
        }

        // GET: Phones/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Phones/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Phones/Create
        [HttpPost]
        public ActionResult Create(TelefonoDTO telefonoDTO)
        {
            var url = Url.Action("Details", "client", new { id = telefonoDTO.ClienteId });

            try
            {
                if (ModelState.IsValid)
                {
                    if (telefonoDTO.Id != 0)
                    {
                        telefonoHelp.Actualizar(telefonoDTO.Id, telefonoDTO);
                        return Redirect(url);
                    }
                    telefonoHelp.Guardar(telefonoDTO);
                    return Redirect(url);
                }
                TempData["Error"] = ModelState.Values.SelectMany(x => x.Errors).Select(e => e.ErrorMessage).ToList();
                return Redirect(url);

                // TODO: Add insert logic here
            }
            catch (Exception ex)
            {
                errors = new List<string> {
                    ex.Message
                };
                TempData["Error"] = errors;
                return Redirect(url);
            }
        }

        // GET: Phones/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Phones/Edit/5
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

        // GET: Phones/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Phones/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            var url = Url.Action("Details", "client", new { id = collection["ClienteId"] });
            try
            {
                // TODO: Add delete logic here
                telefonoHelp.Eliminar(id);
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
