using EasyCredit.Models;
using Helper;
using DTO;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EasyCredit.Controllers
{
    public class StockController : Controller
    {
        ExistenciaHelp ExistenciaHelp;
        public StockController(ExistenciaHelp existenciaHelp) { 
        ExistenciaHelp=existenciaHelp;
        }
        // GET: Stock
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(ExistenciaDTO existenciaDTO)
        {
            var url = Url.Action("Details", "Product", new { id = existenciaDTO.ProductoId });
            try
            {
                if (ModelState.IsValid)
                {
                    if (existenciaDTO.Id != 0)
                    {
                       ExistenciaHelp. Actualizar(existenciaDTO.Id, existenciaDTO);
                        return Redirect(url);
                    }
                    ExistenciaHelp.Guardar(existenciaDTO);
                    return Redirect(url);
                }
                TempData["Error"] = ModelState.Values.SelectMany(x => x.Errors).Select(e => new Message
                {
                    Text = e.ErrorMessage,
                    IsSuccess = false
                }).ToList();
                return Redirect(url);
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


                return Redirect(url);
            }
        }
    }
}