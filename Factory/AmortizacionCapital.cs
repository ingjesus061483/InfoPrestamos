using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    [Table("Amortizaciones_Capital")]
    public class AmortizacionCapital
    {
       public  int Id { get; set; }

        public int Periodo { get; set; }


        [Required]
        public decimal Interes { get; set; }

        [Required]
        public decimal Capital { get; set; }

        [Required]
        public decimal Saldo { get; set; }
        
        [Required]
        public int PrestamoId { get; set; }
        public Prestamo Prestamo { get; set; }

    }
}
