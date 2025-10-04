using Datos;
using Factory;
using DTO;
using SelectPdf;
using System.Linq;
using System.Web.Mvc;
using System.Xml.Linq;
namespace Helper
{
    public class EmpleadoHelp:Help<EmpleadoDTO>
    {
        public EmpleadoHelp(PrestamoDbContext dbContext)
        {
            context = dbContext ;
        }
        public override  IQueryable <EmpleadoDTO> TEntity=>context.Empleados.
                    Include("Areas"). 
            Include("Empresas").
                    Include("Usuarios").
                    Include("Roles"). 
                    Include("TipoIdentificaciones").Select(x => new EmpleadoDTO
                    {
                        Id = x.Id,
                        Identificacion = x.Identificacion,
                        Nombre = x.Nombre,
                        Apellido = x.Apellido,
                        Direccion = x.Direccion,
                        Email = x.Email,
                        EmpresaId = x.EmpresaId,
                        Telefono = x.Telefono,
                        TipoIdentificacion = x.TipoIdentificacion,
                        TipoIdentificacionId = x.TipoIdentificacionId,
                        UsuarioId = x.UsuarioId,
                        Usuario = new UsuarioDTO {
                            Id=                            x.Usuario.Id,
                            Nombre= x.Usuario. Nombre,
                            Password=x.Usuario.Password,
                            Sesion=x.Usuario. Sesion,
                            Role=x.Usuario.Role,
                            RoleId=x.Usuario.RoleId,
                        },                       
                        Area = x.Area,
                        AreaId = x.AreaId,
                        EmpresaDTO=new DTO.EmpresaDTO
                        {
                            Id = x.Empresa.Id,
                            Nombre=x.Empresa.Nombre,
                            Identificacion=x.Empresa.Identificacion,
                            CamaraComercio=x.Empresa .CamaraComercio,
                            Direccion=x.Empresa .Direccion,
                            Contacto=x.Empresa .Contacto,
                            Email=x.Empresa .Email,
                            InteresCartera=x.Empresa.InteresCartera,
                            Logo=x.Empresa .Logo,
                             RegistroMercantil=x.Empresa.RegistroMercantil,
                             Telefono=x.Empresa.Telefono,
                             Slogan = x.Empresa .Slogan,
                             TipoIdentificacionId=x.TipoIdentificacionId,
                             TipoIdentificacion=x.TipoIdentificacion,
                             TipoRegimenId=x.Empresa.TipoRegimenId

                        }
                    });

        protected override HtmlToPdf HtmlToPdf => throw new System.NotImplementedException();

        public override void Actualizar(int id, EmpleadoDTO Entity)
        {
            var cliente = context.Empleados.Find(id);
            cliente.Identificacion = Entity.Identificacion;
            cliente.Nombre =Entity.Nombre;
            cliente.Apellido = Entity.Apellido;
            cliente.Direccion = Entity.Direccion;
            cliente.Telefono = Entity.Telefono;
            cliente.Email =Entity.Email;            
            cliente.TipoIdentificacionId = Entity.TipoIdentificacionId;
            cliente.AreaId = Entity.AreaId;
            context.SaveChanges();            
        }

        public override void Eliminar(int id)
        {
            var empleado = context.Empleados.Find(id);
            context .Empleados .Remove(empleado );
            context.SaveChanges();
        }

        public override byte[] ExportarPdf(Controller controller, string viewName, object model, PdfPageSize pageSize, PdfPageOrientation pdfOrientation, int webPageWidth)
        {
            throw new System.NotImplementedException();
        }

        public override void Guardar(EmpleadoDTO Entity)
        {
            Empleado cliente = new Empleado
            {
                Identificacion = Entity.Identificacion ,
                Nombre = Entity.Nombre,
                Apellido =Entity .Apellido,
                Direccion = Entity.Direccion,
                Telefono = Entity.Telefono,
                Email = Entity.Email,                
                TipoIdentificacionId =Entity.TipoIdentificacionId,
                UsuarioId =Entity.UsuarioId,
                AreaId = Entity.AreaId,            
                Usuario=new Usuario(Entity.Usuario.Nombre,Entity.Usuario.Password,Entity.Usuario.RoleId) ,
                EmpresaId=Entity.EmpresaId
            };
            context.Empleados.Add(cliente);
            context.SaveChanges();
        }    
    }
}
