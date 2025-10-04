using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
namespace DTO
{
    public class AmortizacionDTO
    {
        public int Id { get; set; }

        [Required]
        public int Periodo { get; set; }

        [Required]
        [MaxLength(50)]        
        public string Referencia { get; set; }

        [Required]
        public DateTime Fecha { get; set; }

        [Required]
        public decimal Valor { get; set; }

        [Required]
        public bool PagoCompleto { get; set; }

        [Required]
        public int PrestamoId { get; set; }

        public PrestamoDTO Prestamo { get; set; }

        public List<PagoDTO> Pagos { get; set; }

        public decimal Abono
        {
            get
            {
                if (Pagos != null && Pagos.Count > 0)
                {
                    return Pagos.Where(x=>x.AmortizacionId==Id). Sum(x => x.ValorPagar);
                }
                return 0;
            }
        }
        public decimal PagoMaximo
        {
            get 
            {
                return Math.Round( Valor - Abono);
            } 
        }
    }
}
