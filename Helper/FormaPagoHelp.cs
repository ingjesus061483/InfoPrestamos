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
    public class FormaPagoHelp : Help
    {
        public FormaPagoHelp(PrestamoDbContext dbContext)
        {
            context = dbContext;
        }
        public  IQueryable<FormaPago> FormaPagos
        {
            get
            {
                return context.FormaPagos.AsQueryable();
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
