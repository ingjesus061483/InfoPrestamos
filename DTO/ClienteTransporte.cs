using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Helper;
using Transporte.View;

namespace Transporte
{
   
    public  class ClienteTransporte : Transport<View.PersonaView>
    {
        ClienteHelp ClienteHelp;
        public ClienteTransporte(ClienteHelp _clienteHelp)
        {
            ClienteHelp = _clienteHelp;
        }
        public override List<View.PersonaView> List
        {
            get
            {
            
                    return ClienteHelp.TEntity.AsEnumerable().Select(x => new View.PersonaView
                    {
                        Id = x.Id,
                        Identificacion = x.Identificacion,
                        Nombre = x.Nombre,
                        Apellido = x.Apellido,
                        Direccion = x.Direccion,
                        Telefonos=x.Telefonos,
                        FechaNacimiento = x.FechaNacimiento.ToString("dd/MM/yyyy"),
                        FechaExpedicion=x.FechaExpedicion.ToString("dd/MM/yyyy"),
                        Email = x.Email,
                        TipoIdentificacion = x.TipoIdentificacion.Nombre,
                        TipoIdentificacionId =int.Parse( x.TipoIdentificacionId.ToString()),
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

        public override List <View.PersonaView > GetList(object list)
        {
            throw new NotImplementedException();
        }
    }
}
