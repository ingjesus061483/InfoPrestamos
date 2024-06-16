using Factory;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class PrestamoDTO
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Codigo { get; set; }

        [Required]
        public decimal Monto { get; set; }

        [Required]
        public int Tiempo { get; set; }

        [Required]
        public decimal Interes { get; set; }

        [Required]
        public DateTime Fecha { get; set; }

        public string Observacion { get; set; }


        public bool EsCancelado { get; set; }

        [Required]
        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; }

        [Required]
        public int TipoCobroId { get; set; }
        public TipoCobro TipoCobro { get; set; }

        public int? FiadorId { get; set; }
        public Fiador Fiador { get; set; }

        [Required]
        public int EmpleadoId { get; set; }
        public Empleado Empleado { get; set; }

        public List<PrestamoGarantia> PrestamoGarantias { get; set; }
        public List<Cuota> Cuotas { get; set; }
    }
}
