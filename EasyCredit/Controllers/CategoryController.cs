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
    
    public class CategoryController : Controller
    {
        
        CategoriaHelp _categoriaHelp;
        public CategoryController(CategoriaHelp categoriaHelp) 
        {
            _categoriaHelp = categoriaHelp;
        }
        public JsonResult Search(int id)
        {
            var category=_categoriaHelp.TEntity.Where(x=>x.Id == id).FirstOrDefault();
            return Json(new { data = category }, JsonRequestBehavior.AllowGet);

        }
        // GET: Category
        public ActionResult Index()
        {
           var usuario = (UsuarioDTO)Session["Usuario"];
            if (usuario == null)
            {
                return RedirectToAction("Login", "Employee");
            }
            ViewBag.usuario = usuario;
            var cat= _categoriaHelp.TEntity.ToList();
            return View(cat);
        }

        // GET: Category/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // POST: Category/Create
        [HttpPost]
        public ActionResult Create(CategoriaDTO categoriaDTO)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    if (categoriaDTO .Id != 0)
                    {
                        _categoriaHelp.Actualizar(categoriaDTO.Id, categoriaDTO);
                        return RedirectToAction("Index");
                    }
                    _categoriaHelp.Guardar(categoriaDTO);
                    return RedirectToAction("Index");

                }
                TempData["Error"] = ModelState.Values.SelectMany(x => x.Errors).Select(e => new Message
                {
                    Text = e.ErrorMessage,
                    IsSuccess = false
                }).ToList();
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                TempData["Error"] = new List<Message>()
                {
                    new Message
                    {
                        Text = ex.Message,
                        IsSuccess = false
                    }
                };
                return RedirectToAction("Index");
            }
        }
        // POST: Category/Delete/5
        [HttpPost]
        public ActionResult Delete(int id)
        {
            try
            {
                // TODO: Add delete logic here
                _categoriaHelp.Eliminar(id);
                return RedirectToAction("Index");
            }
            catch(Exception ex) 
            {
                TempData["Error"] = new List<Message>()
                {
                    new Message
                    {
                        Text = ex.Message,
                        IsSuccess = false
                    }
                };
                return RedirectToAction("Index");
            }
        }
    }
}
