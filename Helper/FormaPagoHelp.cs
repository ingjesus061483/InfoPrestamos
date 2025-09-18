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
    public class FormaPagoHelp : Help<FormaPago>
    {
        public FormaPagoHelp(PrestamoDbContext dbContext)
        {
            context = dbContext;
        }
        public override IQueryable<FormaPago> TEntity => context.FormaPagos.AsQueryable();               
        public override void Actualizar(int id, FormaPago Entity)
        {
            throw new NotImplementedException();
        }
        public override void Eliminar(int id)
        {
            throw new NotImplementedException();
        }        
        public override void Guardar(FormaPago Entity)
        {
            throw new NotImplementedException();
        }
    }
}
