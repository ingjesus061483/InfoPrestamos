using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public class Garantia
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Documento { get; set; }
        public string Descripcion { get; set; }

        [Required]
        public int TipoGarantiaId { get; set; }

        public TipoGarantia TipoGarantia { get; set; }
        public List<PrestamoGarantia>  PrestamoGarantias { get; set; }

    }
}
