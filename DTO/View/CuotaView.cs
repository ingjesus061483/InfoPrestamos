using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transporte.View
{

    public class CuotaView
    {
        public int Id { get; set; }
        public string Codigo { get; set; }
        public string Fecha { get; set; }
        public string Cuota { get; set; }
        public string Interes { get; set; }
        public string Capital { get; set; }
        public string Saldo { get; set; }
        public string Observaciones { get; set; }
        public bool PagoCompleto { get; set; }
        public int PrestamoId { get; set; }
        public string Prestamo { get; set; }
    }
}
