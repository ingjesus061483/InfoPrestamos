using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transporte.View
{
    public class PrestamoView
    {
        public int Id { get; set; }
        public string Codigo { get; set; }
        public string Fecha { get; set; }
        public string Monto { get; set; }
        public string TipoCobro { get; set; }
        public int TipoCobroId { get; set; }
        public int Tiempo { get; set; }
        public decimal Interes { get; set; }
        public string Cuotas { get; set; }
        public string Cliente { get; set; }
        public int ClienteId { get; set; }
        public string Empleado { get; set; }
        public int EmpleadoId { get; set; }
        public string Fiador { get; set; }
        public int? FiadorId { get; set; }
        public bool EsCancelado { get; set; }
        public string Observacion { get; set; }
    }
}
