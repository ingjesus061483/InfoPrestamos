using Datos;
using Factory;
using Helper.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Helper
{
    public class TelefonoHelp : Help
    {
        public IQueryable<TelefonoDTO> Telefonos 
        { 
            get 
            {
                return context.Telefonos .Include("TipoTelefonoes").Include("clientes").Select(x => new TelefonoDTO
                {
                    Id = x.Id,
                  NumeroTelefonico=x.NumeroTelefonico ,
                  ClienteId=x.ClienteId,
                                       Cliente  = x.Cliente ,
                                       TipoTelefono=x.TipoTelefono ,
                                      TipoTelefonoId =x.TipoTelefonoId

                });
            }    
        }

        public TelefonoHelp(PrestamoDbContext _context )
        {
            context = _context;
        }

        public override void Actualizar(int id, Dictionary<string, object> collection)
        {
            var telefono = context.Telefonos.Find(id);
            telefono.ClienteId = int.Parse(collection["ClienteId"].ToString());
            telefono.NumeroTelefonico = collection["NumeroTelefonico"].ToString();
            telefono.TipoTelefonoId = int.Parse(collection["TipoTelefonoId"].ToString());
            context.SaveChanges();


        }

        public override void Actualizar(int id, FormCollection collection)
        {
            

            
        }

        public override void Eliminar(int id)
        {
            var telefono = context.Telefonos.Find(id);
            context.Telefonos.Remove(telefono);
            context.SaveChanges();
        }

        public override void Guardar(Dictionary<string, object> collection)
        {
            Telefono telefono  = new Telefono 
            {
                ClienteId =int.Parse( collection[   "ClienteId" ].ToString()), 
                NumeroTelefonico =collection[ "NumeroTelefonico"].ToString(),
                TipoTelefonoId=int.Parse( collection["TipoTelefonoId"].ToString())
            };
            context.Telefonos.Add(telefono);
            context.SaveChanges();
        }

        public override void Guardar(FormCollection collection)
        {
            throw new NotImplementedException();
        }
    }
}
