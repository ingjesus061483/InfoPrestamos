using Datos;
using Factory;
using DTO;
using SelectPdf;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Helpers;
using System.Web.Mvc;
using System.Web.UI.WebControls;

namespace Helper
{
    public class EmpresaHelp : Help<EmpresaDTO>
    {
     public    EmpresaHelp(PrestamoDbContext _context)
        {
            context=_context;
        }
        public override IQueryable<EmpresaDTO> TEntity =>context.Empresas.
            Include("TipoRegimen")
            .Include("TipoIdentificaciones")
            .Include("Empleados")
           .Select(x=>new EmpresaDTO
           {
               Id = x.Id,
               CamaraComercio = x.CamaraComercio,
               Contacto = x.Contacto,
               Direccion = x.Direccion,
               Telefono = x.Telefono,
               RegistroMercantil = x.RegistroMercantil,
               TipoRegimen = x.TipoRegimen,
               TipoRegimenId = x.TipoRegimenId,
               TipoIdentificacion = x.TipoIdentificacion,
               TipoIdentificacionId = x.TipoIdentificacionId,
               Email = x.Email,
               Identificacion = x.Identificacion,
               InteresCartera = x.InteresCartera,
               Logo = x.Logo,
               Nombre = x.Nombre,
               Slogan = x.Slogan,
           Empleados =x.Empleados.Select(y=>new EmpleadoDTO
           {
               Id = y.Id,
               Nombre = y.Nombre,
                Apellido = y.Apellido,
                AreaId = y.AreaId,
                Direccion=y.Direccion,
                Telefono=y.Telefono,
                Email = y.Email,
                    EmpresaId = y.EmpresaId,
                    Identificacion=y.Identificacion,
                    TipoIdentificacionId=y.TipoIdentificacionId,
                    TipoIdentificacion=y.TipoIdentificacion,
                    UsuarioId = y.UsuarioId,


           }).ToList(),
        
        }) ;

        protected override HtmlToPdf HtmlToPdf => throw new NotImplementedException();

        public override void Actualizar(int id, EmpresaDTO Entity)
        { 
            var empresa = context.Empresas.Find(id);
            empresa.Id = Entity.Id;
            empresa.CamaraComercio = Entity.CamaraComercio;
            empresa.Contacto = Entity.Contacto;
            empresa.Direccion = Entity.Direccion;
            empresa.Email = Entity.Email;
            empresa.Identificacion = Entity.Identificacion;
            empresa.InteresCartera = Entity.InteresCartera;
            empresa.Logo = Entity.Logo;
            empresa.Nombre = Entity.Nombre;
            empresa.RegistroMercantil = Entity.RegistroMercantil;
            empresa.Slogan = Entity.Slogan;
            empresa.Telefono = Entity.Telefono;
            empresa.TipoIdentificacionId = Entity.TipoIdentificacionId;
            empresa.TipoRegimenId = Entity.TipoRegimenId;
             context.SaveChanges();


        }

        public override void Eliminar(int id)
        {
            throw new NotImplementedException();
        }

        public override byte[] ExportarPdf(Controller controller, string viewName, object model, PdfPageSize pageSize, PdfPageOrientation pdfOrientation, int webPageWidth)
        {
            throw new NotImplementedException();
        }

        public override void Guardar(EmpresaDTO Entity)
        {
            Empresa empresa = new Empresa 
            {
                Id=Entity.Id,
                CamaraComercio = Entity.CamaraComercio,
                Contacto = Entity.Contacto,
                Direccion = Entity.Direccion,
                Email = Entity.Email,
                Identificacion = Entity.Identificacion,
                InteresCartera = Entity.InteresCartera,
                Logo = Entity.Logo,
                Nombre = Entity.Nombre,
                RegistroMercantil = Entity.RegistroMercantil,
                Slogan  = Entity.Slogan,
                Telefono = Entity.Telefono,
                TipoIdentificacionId    = Entity.TipoIdentificacionId,
                TipoRegimenId = Entity.TipoRegimenId,
            };
            context.Empresas.Add(empresa);
            context.SaveChanges();

        }
    }
}
