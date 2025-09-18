using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    [Table("TipoIdentificaciones")]
   public  class TipoIdentificacion : Tipo
    {
        public override int Id { get;set; }
        [Display(Name = "Tipo de identificacion")]
        public override string Nombre { get ; set ; }
        public override string Descripcion { get ; set ; }
        public List<Cliente>Clientes { get; set; }
        public List<Empleado> Empleados { get; set; }
        public List<Fiador> Fiadors { get; set; }

    }
}
