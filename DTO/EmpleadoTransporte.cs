using Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Transporte.View;

namespace Transporte
{
  public   class EmpleadoTransporte : Transport<View.PersonaView>
    {
        EmpleadoHelp empleadoHelp;
        RoleHelp RoleHelp;
        public  EmpleadoTransporte(EmpleadoHelp _empleadoHelp,RoleHelp _roleHelp  )
        {
            empleadoHelp = _empleadoHelp;
            RoleHelp = _roleHelp;
        }
        public override List<View.PersonaView>  List
        {
            get
            {
                return empleadoHelp .TEntity  .AsEnumerable().Select(x => new View.PersonaView
                {
                    Id = x.Id,
                    Identificacion = x.Identificacion,
                    Nombre = x.Nombre,
                    Apellido = x.Apellido,
                    Direccion = x.Direccion,
                    FechaNacimiento = x.FechaNacimiento.ToString("yyyy/MM/dd"),
                    Email = x.Email,
                    Telefono = x.Telefono,
                    TipoIdentificacion = x.TipoIdentificacion.Nombre,
                    TipoIdentificacionId = x.TipoIdentificacionId,
                    UsuarioId=x.UsuarioId,
                    Usuario=x.Usuario.Nombre, 
                    RoleId=x.Usuario .RoleId ,
                  Role=  x.Role                  //  Role =RoleHelp .Roles .Where (y=>y.Id ==x.Usuario.RoleId ).FirstOrDefault ().Nombre 

                }).ToList();
            }

        }

        public override void CargarDatos(List<PersonaView> telefonos)
        {
            throw new NotImplementedException();
        }

        public override List<View.PersonaView> GetList(int id)
        {
            throw new NotImplementedException();
        }

        public override List<View.PersonaView> GetList(object list)
        {
            throw new NotImplementedException();
        }
    }
}
