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
    public class CategoriaHelp : Help<CategoriaDTO>
    {
        public override IQueryable<CategoriaDTO> TEntity => context .Categorias.Select(c => new CategoriaDTO
        {
            Descripcion = c.Descripcion,
            Id = c.Id,
            Nombre = c.Nombre,
        }).AsQueryable();
        public CategoriaHelp( PrestamoDbContext dbContext)
        {
            context = dbContext;
        }
        protected override HtmlToPdf  HtmlToPdf => throw new NotImplementedException();

        public override void Actualizar(int id, CategoriaDTO Entity)
        {
            var categoria = context.Categorias.Find(id);
            categoria.Nombre=Entity.Nombre;
            categoria.Descripcion = Entity.Descripcion;
            context.SaveChanges();
            
        }

        public override void Eliminar(int id)
        {
            var categoria = context.Categorias.Find(id);
            context .Categorias.Remove(categoria);
            context.SaveChanges();
        }

        public override byte[] ExportarPdf(Controller controller, string viewName, object model, PdfPageSize pageSize, PdfPageOrientation pdfOrientation, int webPageWidth)
        {
            throw new NotImplementedException();
        }

        public override void Guardar(CategoriaDTO Entity)
        {
            Categoria categoria = new Categoria
            {
                Nombre= Entity.Nombre,
                Descripcion= Entity.Descripcion,                
            };
            context.Categorias.Add(categoria);
            context.SaveChanges();
        }
    }
}
