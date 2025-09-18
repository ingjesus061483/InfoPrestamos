using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    [Table("Cuotas")]
    public class Cuota
    {
        public int  Id { get; set; }

        [Required]
        [MaxLength(50)]
        [Index(IsUnique = true)]
        public string Codigo { get; set; }        
        
        [Required] 
        public DateTime Fecha{ get; set; }

        [Required]
        public decimal Valor { get; set; }

        [Required]
        public decimal Interes { get; set; }

        [Required]        
        public decimal Capital { get; set; }

        [Required]
        public decimal Saldo { get; set; }

        [MaxLength(255)]
        public string Observaciones { get; set; }

        [Required]       
        public bool PagoCompleto { get; set; }


        [Required]
        public int PrestamoId { get; set; }
        public Prestamo Prestamo { get; set; }

        public List<Pago> Pagos { get; set; }
    }
}
