using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transporte
{
   public abstract  class Transport<T>
    {
        public BindingList<T> bindindList { get; set; }
        public abstract List<T> List { get; }
        public abstract List<T> GetList(int id);
        public abstract List <T> GetList(object list);
        public abstract void CargarDatos(List<T> telefonos);

    }
}
