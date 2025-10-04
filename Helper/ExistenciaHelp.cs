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
    public class ExistenciaHelp : Help<ExistenciaDTO>
    {
        public ExistenciaHelp(PrestamoDbContext dbContext)
        {
            context = dbContext;
        }
        public override IQueryable<ExistenciaDTO> TEntity => context.Existencias
            .Include("Productos").Select(x => new ExistenciaDTO
            {
                Id = x.Id,
                Cantidad = x.Cantidad,
                Concepto = x.Concepto,
                Entrada = x.Entrada,
                Fecha = x.Fecha,
                Producto = new ProductoDTO
                {
                    Id = x.Producto.Id,
                    CategoriaId = x.Producto.CategoriaId,
                    UnidadMedidaId = x.Producto.UnidadMedidaId,
                    Codigo = x.Producto.Codigo,
                    Costo = x.Producto.Costo,
                    Nombre = x.Producto.Nombre,
                    Descripcion = x.Producto.Descripcion,
                    Precio = x.Producto.Precio,
                    Referencia = x.Producto.Referencia,
                    RutaImagen = x.Producto.RutaImagen,
                },
                ProductoId = x.ProductoId,

            });


        protected override HtmlToPdf HtmlToPdf => throw new NotImplementedException();

        public override void Actualizar(int id, ExistenciaDTO Entity)
        {
            throw new NotImplementedException();
        }

        public override void Eliminar(int id)
        {
            throw new NotImplementedException();
        }

        public override byte[] ExportarPdf(Controller controller, string viewName, object model, PdfPageSize pageSize, PdfPageOrientation pdfOrientation, int webPageWidth)
        {
            throw new NotImplementedException();
        }

        public override void Guardar(ExistenciaDTO Entity)
        {
            Existencia existencia = new Existencia
            {
                ProductoId = Entity.ProductoId,
                Cantidad = Entity.Cantidad,
                Concepto=Entity.Concepto,
                Entrada=Entity.Entrada,
                Fecha=Entity.Fecha,             
            };
            context.Existencias.Add(existencia);
            context.SaveChanges();
            
        }
    }
}
