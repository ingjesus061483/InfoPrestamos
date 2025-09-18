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
    public class PagoHelp : Help<Pago>
    {  
        public PagoHelp(PrestamoDbContext dbContext)
        {
            context = dbContext;
        }

        public override IQueryable<Pago> TEntity => throw new NotImplementedException();

     
        public override void Actualizar(int id, Pago Entity)
        {
            throw new NotImplementedException();
        }

        public override void Eliminar(int id)
        {
            throw new NotImplementedException();
        }

       
        public override void Guardar(Pago Entity)
        {
            throw new NotImplementedException();
        }
    }
}
