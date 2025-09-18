using Datos;
using Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helper
{
    public class AreaHelp : Help<Area>
    {
        public AreaHelp(PrestamoDbContext dbContext)
        {
            context = dbContext;
        }
        public override IQueryable<Area> TEntity =>context .Areas.AsQueryable();

        public override void Actualizar(int id, Area Entity)
        {
            throw new NotImplementedException();
        }

        public override void Eliminar(int id)
        {
            throw new NotImplementedException();
        }

        public override void Guardar(Area Entity)
        {
            throw new NotImplementedException();
        }
    }
}
