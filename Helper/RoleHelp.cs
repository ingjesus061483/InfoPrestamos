using Datos;
using Factory;
using System;
using System.Linq;

namespace Helper
{
    public  class RoleHelp : Help<Role>
    {
        public RoleHelp(PrestamoDbContext dbContext)
        {
            context = dbContext;
        }
        public override IQueryable<Role> TEntity => context.Roles.AsQueryable();
        public override void Actualizar(int id, Role Entity)
        {
            throw new NotImplementedException();
        }
        public override void Eliminar(int id)
        {
            throw new NotImplementedException();
        }
        public override void Guardar(Role Entity)
        {
            throw new NotImplementedException();
        }
    }
}
