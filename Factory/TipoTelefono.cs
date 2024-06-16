using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public class TipoTelefono : Tipo
    {
        public override int Id { get; set ; }
        public override string Nombre { get; set ; }
        public override string Descripcion { get; set ; }
    }
}
