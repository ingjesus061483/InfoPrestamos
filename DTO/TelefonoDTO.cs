using Factory;
using System.ComponentModel.DataAnnotations;
namespace DTO
{
    public class TelefonoDTO
    {

        public int Id { get; set; }

        [Required]
        [Phone]
        [Display(Name = "Numero Telefonico")]
        [MaxLength(20, ErrorMessage = "El campo telefono debe tener max 20 caracteres ")]
        public string NumeroTelefonico { get; set; }

        [Required]
        public int ClienteId { get; set; }
        public ClienteDTO Cliente { get; set; }

        [Required]
        public int TipoTelefonoId { get; set; }
        public TipoTelefono TipoTelefono { get; set; }
  
    }
}
