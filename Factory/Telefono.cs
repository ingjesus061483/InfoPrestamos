using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    [Table("Telefonos")]
    public class Telefono
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(20,ErrorMessage ="El campo telefono debe tener max 20 caracteres ")]
        public string NumeroTelefonico { get; set; }
        
        [Required]
        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; }

        [Required]
        public int TipoTelefonoId { get; set; }
        public TipoTelefono TipoTelefono { get; set; }
    }
}
