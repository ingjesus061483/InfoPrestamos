using Factory;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DTO
{
    public class UsuarioDTO
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        [Index(IsUnique = true)]
        [Display (Name ="Usuario")]
        public string Nombre { get; set; }

        [Required]
        public string Password { get; set; }

        public bool Sesion { get; set; }

        [Required]
        public int RoleId { get; set; }
        public Role Role { get; set; }

        public List<EmpleadoDTO> Empleados { get; set; }
    }
}
