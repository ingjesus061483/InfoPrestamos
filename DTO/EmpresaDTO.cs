using Factory;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DTO
{
 public class EmpresaDTO
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        [Index(IsUnique = true)]
        public string Identificacion { get; set; }

        [Required]
        [MaxLength(50)]
        [Display(Name = "Razon social")]

        public string Nombre { get; set; }

        [Required]
        public int TipoRegimenId { get; set; }
        public TipoRegimen TipoRegimen { get; set; }

        [MaxLength(50)]
        public string RegistroMercantil { get; set; }

        [Required]
        [MaxLength(50)]
        public string CamaraComercio { get; set; }

        [Required]
        [MaxLength(50)]
        public string Direccion { get; set; }

        [Required]
        [MaxLength(50)]
        public string Telefono { get; set; }

        [Required]
        [MaxLength(50)]
        [EmailAddress]
        public string Email { get; set; }

        [MaxLength(50)]
        public string Contacto { get; set; }
        public byte[] Logo { get; set; }

        [MaxLength(255)]
        public string Slogan { get; set; }

        [Required]
        public decimal InteresCartera { get; set; }

        public int? TipoIdentificacionId { get; set; }
        public TipoIdentificacion TipoIdentificacion { get; set; }

        public List <EmpleadoDTO> Empleados { get; set; }

    }
}
