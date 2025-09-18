using Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Transporte.View;

namespace Transporte
{
    public class TelefonoTransporte : Transport<TelefonoView>
    {
        TelefonoHelp telefonoHelp;
        public TelefonoTransporte( TelefonoHelp _telefonoHelp)
        {
            bindindList = new BindingList<TelefonoView>();
            telefonoHelp = _telefonoHelp;
        }
        public override List<TelefonoView> List
        {
            get
            {
                return telefonoHelp.TEntity.AsEnumerable().Select(x => new View.TelefonoView
                {
                    Id = x.Id,
                    NumeroTelefonico = x.NumeroTelefonico,
                    ClienteId = x.ClienteId,
                    TipoTelefonoId = x.TipoTelefonoId,
                    TipoTelefono=x.TipoTelef 
                    
                }).ToList();

            }
        }
        public override List<TelefonoView> GetList(int id)
        {
            return telefonoHelp.TEntity.Where (x=>x.ClienteId==id). AsEnumerable().Select(x => new View.TelefonoView
            {
                Id = x.Id,
                NumeroTelefonico = x.NumeroTelefonico,
                ClienteId = x.ClienteId,
                TipoTelefonoId = x.TipoTelefonoId,
                TipoTelefono = x.TipoTelef

            }).ToList();
        }
        public override  void CargarDatos(List <TelefonoView> telefonos)
        {
            
            bindindList.Clear();
            foreach (TelefonoView telefonoView in telefonos)
            {
                bindindList.Add(telefonoView);
            }

        }

        public override List<TelefonoView> GetList(object list)
        {
            throw new NotImplementedException();
        }
    }
}
