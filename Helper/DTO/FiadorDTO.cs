using Factory;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class FiadorDTO
    {
        public int Id { get; set; }
        
        [Required]
        [MaxLength(50)]
        public string Identificacion { get; set; }


        [Required]
        public string Nombre { get; set; }

        [Required]
        public string Apellido { get; set; }

        [Required]
        public DateTime FechaNacimiento { get; set; }

        [Required]
        public string Direccion { get; set; }

        [Required]
        public string Telefono { get; set; }

        [Required]
        [EmailAddress]
         public string Email { get; set; }

        [Required]
        public string EmperesaDondeLabora { get; set; }

        [Required]
        public int TipoIdentificacionId { get; set; }
        public TipoIdentificacion TipoIdentificacion { get; set; }
        public List<Prestamo> Prestamos { get; set; }
    }
}
