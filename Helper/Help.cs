using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
namespace Helper
{
    public abstract  class Help
    {
        protected PrestamoDbContext context;       

        public abstract void Guardar(Dictionary<string, object> collection);
        public abstract void Guardar(FormCollection collection);
        public abstract void Actualizar(int id, Dictionary<string, object> collection);
        public abstract void Actualizar(int id, FormCollection collection);
        public abstract void Eliminar(int id);
    }
}
