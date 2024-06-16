using Datos;
using Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Helper
{
    public class TipoTelefonoHelp : Help
    {
        public  TipoTelefonoHelp(PrestamoDbContext _context)
        {
            context = _context;
        }
        public IQueryable<TipoTelefono> TipoTelefonos
        {
            get
            {
                return context.TipoTelefonos.AsQueryable();
            }
        }


        public override void Actualizar(int id, Dictionary<string, object> collection)
        {
            throw new NotImplementedException();
        }

        public override void Actualizar(int id, FormCollection collection)
        {
            throw new NotImplementedException();
        }

        public override void Eliminar(int id)
        {
            throw new NotImplementedException();
        }

        public override void Guardar(Dictionary<string, object> collection)
        {
            throw new NotImplementedException();
        }

        public override void Guardar(FormCollection collection)
        {
            throw new NotImplementedException();
        }
    }
}
