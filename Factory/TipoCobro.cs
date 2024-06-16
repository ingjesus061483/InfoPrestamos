using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public class TipoCobro : Tipo
    {
        public override int Id { get ; set ; }
        public override string Nombre { get ; set ; }
        public override string Descripcion { get ; set ; }
        public List <Prestamo> Prestamos { get; set; }
    }
}
