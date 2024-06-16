using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Helper
{
    public class PagoHelp : Help
    {  
        public PagoHelp(PrestamoDbContext dbContext)
        {
            context = dbContext;
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
