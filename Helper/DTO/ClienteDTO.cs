using Factory;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace DTO
{
    public class ClienteDTO
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="")]
        [MaxLength(ErrorMessage ="")]
        public string Identificacion { get; set; }

        [Required(ErrorMessage = "")]
        [MaxLength(ErrorMessage = "")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "")]
        [MaxLength(ErrorMessage = "")]
        public string Apellido { get; set; }

        [Required(ErrorMessage = "")]        
        public DateTime FechaNacimiento { get; set; }

        [Required(ErrorMessage = "")]
        [MaxLength(ErrorMessage = "")]
        public string Direccion { get; set; }

        [Required]
        [Display(Name = "Fecha de expedicion")]
        public DateTime FechaExpedicion { get; set; }


        [Required(ErrorMessage = "")]
        [MaxLength(ErrorMessage = "")]
        [EmailAddress(ErrorMessage ="")]
        public string Email { get; set; }

        [Required(ErrorMessage = "")]
        [Display(Name ="Tipo de identificacion")]
        public int TipoIdentificacionId { get; set; }
        public TipoIdentificacion TipoIdentificacion { get; set; }
        public List<Prestamo> Prestamos { get; set; }
        public List<Telefono > Telefonos { get; set; }
    }
}
