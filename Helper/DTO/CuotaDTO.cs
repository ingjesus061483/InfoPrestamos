using Factory;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class CuotaDTO
    {

        public int Id { get; set; }

        [Required]
        [MaxLength(50)]        
        public string Codigo { get; set; }

        [Required]
        public DateTime Fecha { get; set; }

        [Required]
        public decimal Couta { get; set; }

        [Required]
        public decimal Interes { get; set; }

        [Required]
        public decimal Capital { get; set; }

        [Required]
        public decimal Saldo { get; set; }

        public string Observaciones { get; set; }

        [Required]
        public bool PagoCompleto { get; set; }


        [Required]
        public int PrestamoId { get; set; }
        public Prestamo Prestamo { get; set; }

        public List<PagoCuota> PagoCuotas { get; set; }
    }
}
