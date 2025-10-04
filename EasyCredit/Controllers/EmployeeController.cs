using DTO;
using EasyCredit.Models;
using Factory;
using Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace EasyCredit.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly UsuarioHelp _usuarioHelp;
        private readonly EmpleadoHelp _empleadoHelp;
        TipoIdentificacionHelp _tipoIdentificacionHelp;
        RoleHelp _roleHelp;
        AreaHelp AreaHelp;
        UsuarioDTO usuario;
        public EmployeeController(RoleHelp roleHelp, AreaHelp areaHelp, TipoIdentificacionHelp identificacionHelp, UsuarioHelp usuarioHelp,EmpleadoHelp empleadoHelp            ) 
        {
            _roleHelp = roleHelp;
            AreaHelp = areaHelp;
            _tipoIdentificacionHelp = identificacionHelp;
            _empleadoHelp = empleadoHelp;
            _usuarioHelp = usuarioHelp;
        } 
        public JsonResult Search(int id)
        {
            EmpleadoDTO empleado =_empleadoHelp.TEntity.Where(x=>x.Id == id).FirstOrDefault();
            return Json(new { data = empleado }, JsonRequestBehavior.AllowGet);

        }
        // GET: Employee
        public ActionResult Index()
        {
            usuario = (UsuarioDTO)Session["Usuario"];
            if (usuario == null)
            {
                return RedirectToAction("Login", "Employee");
            }
            ViewBag.usuario = usuario;
            ViewBag.roles = _roleHelp.TEntity.ToList();
            ViewBag.empresa = usuario.Empleados[0].EmpresaDTO;
            ViewBag.areas = AreaHelp.TEntity.ToList();
            ViewBag.tipoidentificacion =_tipoIdentificacionHelp.TEntity.ToList();
            var empleado=_empleadoHelp.TEntity.ToList();
            return View(empleado);
        }
        public ActionResult Login()
        {
            usuario = (UsuarioDTO)Session["Usuario"];
            if (usuario != null)
            {           
                return RedirectToAction("index", "Home");
            }
            return View();
        }
        [HttpPost]
        public JsonResult Create(EmpleadoDTO empleado)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    if (empleado.Id != 0)
                    {
                        _empleadoHelp.Actualizar(empleado.Id, empleado);
                        return Json(new { data = "Se ha actualizado un empleado" }, JsonRequestBehavior.AllowGet);                        
                    }
                    _empleadoHelp.Guardar(empleado);
                    return Json(new { data = "Se ha registrado un empleado" }, JsonRequestBehavior.AllowGet);

                }
                TempData["Error"] = ModelState.Values.SelectMany(x => x.Errors).Select(e => new Message
                {
                    Text = e.ErrorMessage,
                    IsSuccess = false
                }).ToList();
                return Json(new { data ="Ha ocurrido un error al validar el empleado" }, JsonRequestBehavior.AllowGet);

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

                return Json(new { data = "Ha ocurrido un error " }, JsonRequestBehavior.AllowGet);

            }
        }
        [HttpPost]
        public ActionResult Delete(int id)
        {
            try
            {       
                var empleado = _empleadoHelp.TEntity.Where (x=>x.Id == id).FirstOrDefault();
                usuario = (UsuarioDTO)Session["Usuario"];
                if (usuario.Id != empleado.UsuarioId)
                {
                    _usuarioHelp.Eliminar(empleado.UsuarioId);
                    return RedirectToAction("index", "Employee");
                }
                var errors = new List<Message> {
                    new Message {
                         Text = "El usuario esta abierto",
                    IsSuccess = false
                    }
                };
                TempData["Error"] = errors;
                return RedirectToAction("index", "Employee");
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
                return RedirectToAction("index", "Employee");
            }
        }
        [HttpPost]
        public ActionResult Login(UsuarioDTO usuarioDTO)
        {

            var url = Url.Action("Index", "Home");
            try
            {
                if(ModelState.IsValid)
                {
                    var pwd= _usuarioHelp.Encriptar(usuarioDTO.Password);
                    var usuario= _usuarioHelp.TEntity.Where(x => x.Nombre == usuarioDTO.Nombre && x.Password == pwd).FirstOrDefault();
                    if(usuario == null)
                    {
                        TempData["Error"] = new List<Message> { new Message { IsSuccess = false, Text = "Usuario o contraseña incorrecta" } };
                        return View();
                    }
                    Session["Usuario"] = usuario;
            //        FormsAuthentication.SetAuthCookie(usuario.Nombre, true);
                    return Redirect(url);
                }
                var errors = ModelState.Values.SelectMany(x => x.Errors).Select(e => new Message
                {
                    Text = e.ErrorMessage,
                    IsSuccess = false
                }).ToList();
                TempData["Error"] = errors;
                return View();
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
                return View();
            }
            
        }
    }
}