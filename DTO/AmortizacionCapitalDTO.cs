using Factory;
using System.ComponentModel.DataAnnotations;
namespace DTO
{
    public class AmortizacionCapitalDTO
    {
        public int Id { get; set; }

        [Required]
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
