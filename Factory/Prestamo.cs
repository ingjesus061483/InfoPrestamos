using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    [Table("Prestamos")]
    public class Prestamo
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        [Index(IsUnique = true)]
        public string Codigo { get; set; }

        [Required]
        public decimal Monto { get; set; }

        [Required]
        public int Tiempo { get; set; }

        [Required]
        public decimal Interes { get;set; }

        [Required]
        public DateTime Fecha { get; set; }

        [MaxLength(255)]
        public string Observacion { get; set; }
        
        [Required]
        public  int ClienteId { get; set; }
        public Cliente Cliente { get; set; }

        [Required]
        public int TipoCobroId { get; set; }
        public TipoCobro TipoCobro { get; set; }

        public int? FiadorId { get; set; }
        public Fiador Fiador { get; set; }

        [Required]
        public int EmpleadoId { get; set; }
        public Empleado Empleado { get; set; }

        [Required]
        public int EstadoId { get; set; }
        public Estado Estado { get; set; }
        public List<PrestamoGarantia>  PrestamoGarantias  { get; set; }
        public List<Cuota> Cuotas { get; set; }

    }
}
