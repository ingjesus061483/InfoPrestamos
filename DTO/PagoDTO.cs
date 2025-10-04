using Factory;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DTO
{
    public class PagoDTO
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        [Index(IsUnique = true)]
        public string Referencia { get; set; }

        [Required]
        public DateTime Fecha { get; set; }


        [Required]
        [Display(Name ="Valor")]
        public decimal ValorPagar { get; set; }

        public string Observaciones { get; set; }

        [Required]
        public int FormaPagoId { get; set; }
        public FormaPago FormaPago { get; set; }

        [Required]
        public int TipoPagoId { get; set; }
        public TipoPago TipoPago { get; set; }

        public int? EmpleadoId { get; set; }
        public EmpleadoDTO Empleado { get; set; }

        [Required]
        public int AmortizacionId { get; set; }
        public AmortizacionDTO AmortizacionDTO { get; set; }

    
    }
}
