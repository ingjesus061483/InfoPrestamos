using Factory;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class UsuarioDTO
    {

        public int Id { get; set; }

        [Required(ErrorMessage = "Campo nombre es requerido")]
        [MaxLength(50, ErrorMessage = "Campo nombre no puede tener mas de 50 caracteres")]
        public string Nombre { get; set; }

        [Required]
        public string Password { get; set; }

        public bool Sesion { get; set; }

        [Required]
        public int RoleId { get; set; }
        public Role Role { get; set; }

        public List<Empleado> Empleados { get; set; }
    }
}
