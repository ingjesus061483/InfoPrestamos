using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    [Table("TipoCobros")]
    public class TipoCobro : Tipo
    {
        public override int Id { get ; set ; }

        [Display(Name = "Tipo cobro")]

        public override string Nombre { get ; set ; }
        public int Valor { get ; set ; }
        public override string Descripcion { get ; set ; }
        public List <Prestamo> Prestamos { get; set; }
    }
}
