using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    [Table("FormaPagos")]
    public class FormaPago : Tipo
    {
        public override int Id { get ; set ; }

        [Display(Name = "Forma de Pago")]
        public override string Nombre { get; set; }
        public override string Descripcion { get; set ; }
        public List<Pago> Pagos { get; set; }
    }
}
