using Datos;
using Factory;
using DTO;
using SelectPdf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Helper
{
    public class ProductoHelp : Help<ProductoDTO>
    {

        public ProductoHelp(PrestamoDbContext dbContext)
        {
            context = dbContext;
        }
        public override IQueryable<ProductoDTO> TEntity => context.Productos.
            Include ("Existencias").
            Include ("Categorias").
            Include("UnidadMedidas").
            Select(x=>new ProductoDTO {
                Id = x.Id,
                Codigo = x.Codigo,
                Nombre = x.Nombre,
                Referencia = x.Referencia,
                Costo = x.Costo,
                Precio = x.Precio,
                Descripcion = x.Descripcion,
                CategoriaId = x.CategoriaId,
                Categoria=new CategoriaDTO
                {
                   Id = x.Categoria.Id,
                   Nombre=x.Categoria.Nombre,
                   Descripcion=x.Categoria.Descripcion
                },
                UnidadMedida = new UnidadMedidaDTO {
                   Id= x.UnidadMedida.Id,
                   Nombre=x.UnidadMedida .Nombre,
                    Descripcion=x.UnidadMedida.Descripcion ,
                },
                UnidadMedidaId=x.UnidadMedidaId,
                RutaImagen = x.RutaImagen,
                Existencias=x.Existencias.Select(y => new ExistenciaDTO
                {
                   Cantidad = y.Cantidad,
                   Concepto = y.Concepto,
                   Entrada = y.Entrada,
                   Fecha = y.Fecha,
                   Id = y.Id,
                   ProductoId = y.ProductoId,

                }).ToList(),
               
            }).AsQueryable();

        protected override HtmlToPdf HtmlToPdf => new HtmlToPdf();

        public override void Actualizar(int id, ProductoDTO Entity)
        {
            var producto = context.Productos.Find(id);
            producto.Codigo = Entity.Codigo;
            producto.Nombre = Entity.Nombre;
            producto.Referencia = Entity.Referencia;
            producto.Costo = Entity.Costo;
            producto.Precio = Entity.Precio;
            producto.Descripcion = Entity.Descripcion;
            producto.RutaImagen = Entity.RutaImagen;
            producto.CategoriaId = Entity.CategoriaId;
            producto.UnidadMedidaId = Entity.UnidadMedidaId;
            context.SaveChanges();
        }

        public override void Eliminar(int id)
        {
            var producto = context.Productos.Find(id);
            context.Productos.Remove(producto);
            context.SaveChanges();
        }

        public override byte[] ExportarPdf(Controller controller, string viewName, object model, PdfPageSize pageSize, PdfPageOrientation pdfOrientation, int webPageWidth)
        {
            HtmlToPdf.Options.PdfPageSize = pageSize;
            HtmlToPdf.Options.PdfPageOrientation = pdfOrientation;
            HtmlToPdf.Options.WebPageWidth = webPageWidth;
            var html = RenderRazorViewToString(controller, viewName, model);
            PdfDocument pdfDocument = HtmlToPdf.ConvertHtmlString(html);
            byte[] bytes = pdfDocument.Save();
            pdfDocument.Close();
            return bytes;
        }

        public override void Guardar(ProductoDTO Entity)
        {
            Producto producto = new Producto { 
                Codigo=Entity.Codigo,
                Nombre=Entity.Nombre,
                Referencia=Entity.Referencia,
                Costo=Entity.Costo,
                Precio=Entity.Precio,
                Descripcion=Entity.Descripcion,
                RutaImagen=Entity.RutaImagen,                  
                CategoriaId=Entity.CategoriaId,
                UnidadMedidaId  = Entity.UnidadMedidaId,
                Existencias=Entity .Existencias.Select (x=>new Existencia {
                    Cantidad=x.Cantidad,
                    Concepto=x.Concepto,
                    Entrada=x.Entrada,
                    Fecha=x.Fecha,
                    Id=x.Id,
                    ProductoId=x.ProductoId,
                }).ToList(),
            };
            context .Productos.Add(producto);
            context .SaveChanges();
        }
    }
}
