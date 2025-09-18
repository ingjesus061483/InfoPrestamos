using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Factory;
using Helper;
namespace InfoPrestamosWeb.Controllers
{
    public class ClienteController : Controller
    {
        ClienteHelp clienteHelp;
        TipoIdentificacionHelp TipoIdentificacionHelp;

        public List<SelectListItem> GetSelectList()
        {
            List<TipoIdentificacion> tipoIdentificacions =TipoIdentificacionHelp .TEntity .ToList();
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
        public  ClienteController (ClienteHelp _clienteHelp,TipoIdentificacionHelp _tipoIdentificacionHelp  )
        {
            TipoIdentificacionHelp = _tipoIdentificacionHelp;
            clienteHelp = _clienteHelp;
        }

        // GET: Cliente
        public ActionResult Index()
        {            
            var cliente = clienteHelp.TEntity.ToList().Select(x => new Cliente
            {
                Id = x.Id,
                Identificacion = x.Identificacion,
                Nombre = x.Nombre,
                Apellido = x.Apellido,
                FechaNacimiento = x.FechaNacimiento,
                Direccion = x.Direccion,
                Email = x.Email,
                TipoIdentificacionId = int.Parse(x.TipoIdentificacionId.ToString()),
                TipoIdentificacion = x.TipoIdentificacion
            }).ToList ();
            return View(cliente);
        }

        // GET: Cliente/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Cliente/Create
        public ActionResult Create()
        {            
            ViewBag.tipoidentificacion =GetSelectList();
            return View();
        }

        // POST: Cliente/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here
            //    clienteHelp.Guardar(collection);
                return RedirectToAction("Index");

            }
            catch
            {
                return View();
            }
        }

        // GET: Cliente/Edit/5
        public ActionResult Edit(int id)
        {
            var cliente = clienteHelp.TEntity.Where(x => x.Id == id).ToList().Select(x => new Cliente {
                Id = x.Id,
                Identificacion = x.Identificacion,
                Nombre = x.Nombre,
                Apellido = x.Apellido,
                FechaNacimiento = x.FechaNacimiento,
                Direccion = x.Direccion,
                Email = x.Email,
                TipoIdentificacionId =int.Parse( x.TipoIdentificacionId.ToString()),
                TipoIdentificacion =x.TipoIdentificacion 
            }).FirstOrDefault();
            ViewBag.tipoidentificacion =GetSelectList();
            return View(cliente );
        }

        // POST: Cliente/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here
             //   clienteHelp.Actualizar(id, collection);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
        // POST: Cliente/Delete/5
        [HttpPost]
        public ActionResult Delete(int id)
        {
            try
            {
                // TODO: Add delete logic here
                clienteHelp.Eliminar(id);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
