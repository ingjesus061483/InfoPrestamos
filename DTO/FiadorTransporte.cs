using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Helper;
using Transporte.View;

namespace Transporte
{
    public class FiadorTransporte : Transport<View.PersonaView>
    {
        FiadorHelp fiadorHelp;
        public FiadorTransporte(FiadorHelp _fiadorHelp)
        {
            fiadorHelp = _fiadorHelp;
        }
        public override List <View.PersonaView> List
        {
            get
            {
            
                return fiadorHelp.TEntity.AsEnumerable().Select(x => new View.PersonaView
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
                    TipoIdentificacionId = x.TipoIdentificacionId
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

        public override List<View.PersonaView > GetList(object list)
        {
            throw new NotImplementedException();
        }
    }
}
