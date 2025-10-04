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
    public class ClientController : Controller
    {
        UsuarioDTO usuario;
        TipoIdentificacionHelp tipoIdentificacionHelp;
        ClienteHelp clienteHelp;
        AreaHelp areaHelp;
        TipoTelefonoHelp tipoTelefonoHelp;
        List<Message> errors;
        public ClientController(ClienteHelp clienteHelp,
            TipoIdentificacionHelp tipoIdentificacionHelp,
            AreaHelp areaHelp,
            TipoTelefonoHelp tipoTelefonoHelp)
        {
            this.tipoTelefonoHelp = tipoTelefonoHelp;
            this.clienteHelp = clienteHelp;
            this.tipoIdentificacionHelp = tipoIdentificacionHelp;
            this.areaHelp = areaHelp;
        }
        [HttpGet]
        public JsonResult Search(int id)
        {
            ClienteDTO cliente = clienteHelp.TEntity.Where(x=>x.Id==id).FirstOrDefault();
            return Json(new { data = cliente }, JsonRequestBehavior.AllowGet);
        }
        // GET: Client
        [HttpGet]
        public ActionResult Index()
        {
            usuario = (UsuarioDTO)Session["Usuario"];

            if (usuario == null)
            {
                return RedirectToAction("Login", "Employee");
            }
            ViewBag.usuario = usuario;
            ViewBag.TipoIdentificaciones = tipoIdentificacionHelp.TEntity.ToList();
            ViewBag.Areas = areaHelp.TEntity.ToList();
            List <ClienteDTO> clientes = clienteHelp .TEntity.ToList();
            return View( clientes);
        }

        // GET: Client/Details/5
        [HttpGet]
        public ActionResult Details(int id)
        {
            usuario = (UsuarioDTO)Session["Usuario"];

            if (usuario == null)
            {
                return RedirectToAction("Login", "Employee");
            }
            ViewBag.usuario = usuario;

            ViewBag.TipoIdentificaciones = tipoIdentificacionHelp.TEntity.ToList();
            ViewBag.tipoTelefonos = tipoTelefonoHelp.TEntity.ToList();
            ClienteDTO cliente = clienteHelp.TEntity.Where(x => x.Id == id).FirstOrDefault();
            return View(cliente);
        }        
        // POST: Client/Create
        [HttpPost]
        public ActionResult Create(ClienteDTO clienteDTO)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    if (clienteDTO.Id != 0)
                    {
                        clienteHelp.Actualizar(clienteDTO.Id, clienteDTO);
                        return RedirectToAction("Index");
                    }
                    clienteHelp.Guardar(clienteDTO);                    
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
                errors = new List<Message> {
                    new Message { Text = ex.Message, IsSuccess = false }
                    
                };                
                TempData["Error"] = errors;
                return RedirectToAction("Index");
            }
        }
        // POST: Client/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                clienteHelp.Eliminar(id);            
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                errors = new List<Message>
                {
                    new Message{Text = ex.Message,IsSuccess = false}                    
                };                
                TempData["Error"] = errors;
                return RedirectToAction("Index");
            }
        }
    }
}
