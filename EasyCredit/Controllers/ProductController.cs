using EasyCredit.Models;
using Factory;
using Helper;
using DTO;
using SelectPdf;
using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EasyCredit.Controllers
{
    public class ProductController : Controller
    {
        PdfPageSize PageSize = PdfPageSize.A4;
        PdfPageOrientation PdfOrientation = PdfPageOrientation.Portrait;
        int WebPageWidth = 1500;
        ProductoHelp ProductoHelp;
        CategoriaHelp CategoriaHelp;
        UnidadMedidaHelp UnidadMedidaHelp;
        public ProductController(CategoriaHelp categoriaHelp,UnidadMedidaHelp unidadMedidaHelp, ProductoHelp productoHelp) { 
            ProductoHelp = productoHelp;
            CategoriaHelp = categoriaHelp;
            UnidadMedidaHelp = unidadMedidaHelp;
        }
        public JsonResult Search(int id)
        {
            var prod =ProductoHelp.TEntity.Where(x => x.Id == id).FirstOrDefault();
            return Json(new { data = prod }, JsonRequestBehavior.AllowGet);

        }
        // GET: Product
        public ActionResult Index()
        {
           var usuario = (UsuarioDTO)Session["Usuario"];

            if (usuario == null)
            {
                return RedirectToAction("Login", "Employee");
            }
            ViewBag.usuario = usuario;
            ViewBag.categoria = CategoriaHelp.TEntity.ToList();
            ViewBag.unidadmedida = UnidadMedidaHelp.TEntity.ToList();
            var produto =ProductoHelp.TEntity.ToList();
            return View(produto);
        }

        // GET: Product/Details/5
        public ActionResult Details(int id)
        {
            var usuario = (UsuarioDTO)Session["Usuario"];
            if (usuario == null)
            {
                return RedirectToAction("Login", "Employee");
            }
            ViewBag.usuario = usuario;
            var prod = ProductoHelp.TEntity.Where(x => x.Id == id).FirstOrDefault();
            return View(prod);
        }
        // POST: Product/Create
        [HttpPost]
        public JsonResult Create(ProductoDTO productoDTO)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    if (productoDTO.Id != 0)
                    {
                        ProductoHelp.Actualizar(productoDTO.Id, productoDTO);
                        return Json(new { data =ProductoHelp.TEntity.Where(x=>x.Id==productoDTO.Id).FirstOrDefault(),message= "Se ha actualizado un producto" }, JsonRequestBehavior.AllowGet);
                    }
                    ProductoHelp.Guardar(productoDTO);
                    return Json(new { data =ProductoHelp.TEntity.ToList().Last(),message= "Se ha registrado un producto" }, JsonRequestBehavior.AllowGet);

                }
                TempData["Error"] = ModelState.Values.SelectMany(x => x.Errors).Select(e => new Message
                {
                    Text = e.ErrorMessage,
                    IsSuccess = false
                }).ToList();
                return Json(new { data ="" ,message= "Ha ocurrido un error al validar el empleado" }, JsonRequestBehavior.AllowGet);

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
        // POST: Product/Delete/5
        [HttpPost]
        public ActionResult Delete(int id)
        {
            try
            {
                // TODO: Add delete logic here
                ProductoHelp.Eliminar(id);
                return RedirectToAction("Index");
            }
            catch(Exception ex) 
            {
                var errors = new List<Message> {
                    new Message {
                         Text = ex.Message,
                    IsSuccess = false
                    }
                };
                TempData["Error"] = errors;
                return RedirectToAction("Index");
            }
        }
        public ActionResult StocksMovementsReport(int id)
        {
        var    usuario = (UsuarioDTO)Session["Usuario"];
            if (usuario == null)
            {
                return RedirectToAction("Login", "Employee");
            }
            ViewBag.Empresa = usuario.Empleados[0].EmpresaDTO;
            var producto = ProductoHelp.TEntity.Where(x => x.Id == id).FirstOrDefault();
            byte[] pdf =ProductoHelp.ExportarPdf(this, "StocksMovementsReport", producto, PageSize, PdfOrientation, WebPageWidth);

            return File(pdf, "application/pdf");
        }
        public ActionResult StocksReport()
        {
            var usuario = (UsuarioDTO)Session["Usuario"];
            if (usuario == null)
            {
                return RedirectToAction("Login", "Employee");
            }
            ViewBag.Empresa = usuario.Empleados[0].EmpresaDTO;
            var producto = ProductoHelp.TEntity.ToList();
            byte[] pdf = ProductoHelp.ExportarPdf(this, "StocksReport", producto, PageSize, PdfOrientation, WebPageWidth);
            return File(pdf, "application/pdf");
        }
    }
}
