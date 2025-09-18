using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    [Table("PrestamoGarantias")]
   public  class PrestamoGarantia
    {
        public int Id { get; set; }

        [Required ]
        public int PrestamoId { get; set; }
        public Prestamo Prestamo { get; set; }
        
        [Required]
        public int GarantiaId { get; set; }
        public Garantia Garantia { get; set; }
    }
}
