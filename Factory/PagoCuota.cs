using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public class PagoCuota
    {
        public int Id { get; set; }

        [Required]
        public int PagoId { get; set; }
        public Pago Pago { get; set; }

        [Required]
        public int CuotaId { get; set; }
        public Cuota Cuota { get; set; }

    }
}
