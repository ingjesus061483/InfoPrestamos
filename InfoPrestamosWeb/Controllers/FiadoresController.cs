using Factory;
using Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace InfoPrestamosWeb.Controllers
{
    public class FiadoresController : Controller
    {
        public List<SelectListItem> GetSelectList()
        {
            List<TipoIdentificacion> tipoIdentificacions = TipoIdentificacionHelp.TEntity.ToList();
            List<SelectListItem> result = new List<SelectListItem>();
            try
            {
                foreach (TipoIdentificacion tipoIdentificacion in tipoIdentificacions)
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
        FiadorHelp fiadorHelp;
        TipoIdentificacionHelp TipoIdentificacionHelp;
        public FiadoresController(FiadorHelp _fiadorHelp, TipoIdentificacionHelp _tipoIdentificacionHelp)
        {
            TipoIdentificacionHelp = _tipoIdentificacionHelp;
            fiadorHelp = _fiadorHelp;
        }
        // GET: Fiadores
        public ActionResult Index()
        {
            var fiadores = fiadorHelp.TEntity.ToList().Select(x => new Fiador {
                Id =x.Id ,
                Identificacion=x.Identificacion ,
                Nombre =x.Nombre ,
                Apellido =x.Apellido,
                FechaNacimiento =x.FechaNacimiento ,
                Direccion=x.Direccion ,
                Telefono =x.Telefono ,
                Email = x.Email ,
                EmperesaDondeLabora=x.EmperesaDondeLabora ,
                TipoIdentificacionId =x.TipoIdentificacionId ,
                TipoIdentificacion=x.TipoIdentificacion ,
            }).ToList(); 
            return View(fiadores);
        }

        // GET: Fiadores/Details/5
        public ActionResult Details(int id)
        {
            
            return View();
        }

        // GET: Fiadores/Create
        public ActionResult Create()
        {
            ViewBag.tipoidentificacion =GetSelectList();
            return View();
        }

        // POST: Fiadores/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here
             //   fiadorHelp.Guardar(collection);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Fiadores/Edit/5
        public ActionResult Edit(int id)
        {
            ViewBag.tipoidentificacion = GetSelectList();
            return View();
        }

        // POST: Fiadores/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here
                //fiadorHelp.Actualizar(id, collection);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        

        // POST: Fiadores/Delete/5
        [HttpPost]
        public ActionResult Delete(int id)
        {
            try
            {
                // TODO: Add delete logic here
                fiadorHelp.Eliminar(id);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
