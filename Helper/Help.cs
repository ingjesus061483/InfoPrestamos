using Datos;
using System.Linq;
namespace Helper
{
    public abstract  class Help<T>
    {
        protected PrestamoDbContext context;
        public abstract IQueryable<T> TEntity { get; }
        public abstract void Guardar(T Entity);
        public abstract void Actualizar(int id, T Entity);
        public abstract void Eliminar(int id);
    }
}
