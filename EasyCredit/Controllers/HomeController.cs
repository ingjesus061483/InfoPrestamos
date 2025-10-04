using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EasyCredit.Controllers
{
  
  // [Authorize(Roles ="Administrador,Cobrador") ]
    public class HomeController : Controller
    {
        UsuarioDTO usuario;
        public HomeController()
        {
            
        }

        public ActionResult Index()
        {           
            usuario =(UsuarioDTO) Session["Usuario"];

            if (usuario == null)
            {
                return RedirectToAction("Login", "Employee");
            }

            ViewBag.usuario = usuario;
            return View();
        }

        public ActionResult About()
        {
            usuario = (UsuarioDTO)Session["Usuario"];
            if (usuario == null)
            {
                return RedirectToAction("Login", "Employee");
            }
            ViewBag.usuario = usuario;
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            usuario = (UsuarioDTO)Session["Usuario"];
            if (usuario == null)
            {
                return RedirectToAction("Login", "Employee");
            }

            ViewBag.usuario = usuario;
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}