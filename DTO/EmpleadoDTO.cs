using Factory;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace DTO
{
    public class EmpleadoDTO
    {
        [Required]
        [Display(Name = "Sector")]
        public int? AreaId { get; set; }
        public Area Area { get; set; }

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

        [Required]
        [MaxLength(50)]
        [Phone]
        public string Telefono { get; set; }

        [Required]
        [MaxLength(50)]
        [EmailAddress(ErrorMessage = "Email invalido")]
        public string Email { get; set; }

        [Required]
        public int UsuarioId { get; set; }
        public UsuarioDTO Usuario { get; set; }

        [Required]
        [Display(Name = "Tipo Identificacion")]

        public int? TipoIdentificacionId { get; set; }
        public TipoIdentificacion TipoIdentificacion { get; set; }

        public List<PrestamoDTO> Prestamos { get; set; }

        [Required]
        public int EmpresaId { get; set; }
        public EmpresaDTO EmpresaDTO { get; set; }

        
        public string NombreCompleto { get { return $"{Nombre} {Apellido}"; } } 

    }

}
