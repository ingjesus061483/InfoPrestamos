
using DTO;
using Factory;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helper.DTO
{
    public class ReferenciaDTO
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Identificacion { get; set; }

        [Required]
        [MaxLength(50)]
        public string Nombre { get; set; }

        [Required]
        [MaxLength(50)]
        public string Apellido { get; set; }

        [Required]
        [MaxLength(50)]
        public string Direccion { get; set; }

        [EmailAddress]
        [MaxLength(50)]
        public string Email { get; set; }

        public int TipoIdentificacionId { get; set; }
        public TipoIdentificacion TipoIdentificacion { get; set; }

        [Required]
        [MaxLength(15)]
        [Phone]
        public string Telefono { get; set; }
        public int? ClienteId { get; set; }
        public ClienteDTO Cliente { get; set; }

        [Display(Name = "Nombre Completo")]
        public string NombreCompleto
        {
            get
            {
                return Nombre + " " + Apellido;
            }
        }

    }
}
