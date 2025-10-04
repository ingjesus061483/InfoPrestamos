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
    public class UsuarioHelp : Help<UsuarioDTO>
    {
        public string Encriptar(string password)
        {
            byte[] encryted = Encoding.Unicode.GetBytes(password);
            string result = Convert.ToBase64String(encryted);
            return result;
        }
        public UsuarioHelp(PrestamoDbContext dbContext)
        {
            context = dbContext;
        }
  
        public override IQueryable<UsuarioDTO> TEntity => context.Usuarios.
            Include("Empleados")
            .Include("Roles").
           Include("TipoIdentificaciones").
            Include("Empresas").
            Select(x => new UsuarioDTO
            {
                Id = x.Id,
                Nombre = x.Nombre,
                Password = x.Password,
                RoleId = x.RoleId,
                Role = x.Role,
                Sesion = x.Sesion,
                Empleados = x.Empleados.Select(z=>new EmpleadoDTO
                {
                    Id = z.Id,
                    Apellido = z.Apellido,
                    AreaId = z.AreaId,
                    Direccion = z.Direccion,
                    Email = z.Email,
                    EmpresaId = z.EmpresaId,
                    Identificacion = z.Identificacion,
                    Nombre=z.Nombre,
                    Telefono = z.Telefono,
                    TipoIdentificacionId=z.TipoIdentificacionId,
                    UsuarioId=z.UsuarioId,
                    EmpresaDTO=new EmpresaDTO
                    {
                        Id=z.Empresa.Id,
                        Nombre=z.Empresa .Nombre,
                        Identificacion=z.Empresa.Identificacion ,
                        Direccion=z.Empresa.Direccion ,
                        Email=z.Empresa. Email,
                        CamaraComercio=z.Empresa.CamaraComercio,
                        RegistroMercantil=z.Empresa.RegistroMercantil,
                        Contacto=z.Empresa.Contacto ,
                        InteresCartera=z.Empresa.InteresCartera,
                        Logo=z.Empresa.Logo,
                        Slogan=z.Empresa.Slogan,
                        Telefono=z.Empresa.Telefono,
                        TipoIdentificacionId=z.Empresa.TipoIdentificacionId ,
                        TipoIdentificacion=z .Empresa .TipoIdentificacion ,
                        TipoRegimenId=z.Empresa.TipoRegimenId                        
                    },
                }).ToList()
            });

        protected override HtmlToPdf HtmlToPdf => throw new NotImplementedException();

        public override void Eliminar(int id)
        {
            Usuario Usuario = context.Usuarios.Find(id);
            context.Usuarios.Remove(Usuario);
            context.SaveChanges();

        }
        public void ActivarSesion(int id,bool sesion)
        {
            Usuario Usuario = context.Usuarios.Find(id);
            Usuario.Sesion = sesion;
            context.SaveChanges();
        }

        public override void Guardar(UsuarioDTO Entity)
        {
            Usuario Usuario = new Usuario(Entity.Nombre,Entity .Password , Entity.RoleId );
            context.Usuarios.Add(Usuario);
            context.SaveChanges();
        }

        public override void Actualizar(int id, UsuarioDTO Entity)
        {
            Usuario Usuario = context.Usuarios.Find(id);
            Usuario.Password = Usuario.Encriptar(Entity.Password);
            Usuario.RoleId =Entity.RoleId ;
            context.SaveChanges();
        }

        public override byte[] ExportarPdf(Controller controller, string viewName, object model, PdfPageSize pageSize, PdfPageOrientation pdfOrientation, int webPageWidth)
        {
            throw new NotImplementedException();
        }
    }
}
