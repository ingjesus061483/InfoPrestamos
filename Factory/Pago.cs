using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    [Table("Pagos")]
    public class Pago
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        [Index(IsUnique = true)]
        public string Referencia { get; set; }

        [Required]
        public DateTime Fecha { get; set; }

        [Required]
        public decimal PagoMinimo { get; set; }

        [Required]
        public decimal ValorPagar { get; set; }

        public string Observaciones { get; set; }

        [Required]
        public int FormaPagoId { get; set; }
        public FormaPago FormaPago { get; set; }

        [Required]
        public int TipoPagoId { get; set; }
        public TipoPago TipoPago { get; set; }

        public int? EmpleadoId { get; set; }
        public Empleado Empleado { get; set; }

        [Required]
        public int CuotaId {  get; set; }
        public Cuota Cuota{ get; set; }

    }
}
