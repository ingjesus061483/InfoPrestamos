using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
   public class Usuario
    {
        public Usuario()
        {

        }
        public Usuario(string nombre, string password  ,int role = 1)
        {
            Nombre = nombre;
            Password = Encriptar(password);
            RoleId = role;
        }
        public int Id { get; set; }

        [Required(ErrorMessage = "Campo nombre es requerido")]
        [MaxLength(50, ErrorMessage = "Campo nombre no puede tener mas de 50 caracteres")]
        [Index(IsUnique = true)]
        public string Nombre { get; set; }       

        [Required]
        public string Password { get; set; }
        
        public bool Sesion { get; set; }

        [Required]
        public int RoleId { get; set; }
        public Role Role { get; set; }

        public List<Empleado> Empleados { get; set; }

        public string Encriptar(string password) 
        {
            byte[] encryted = Encoding.Unicode.GetBytes(password);
            string result = Convert.ToBase64String(encryted);
            return result;            
        }
    }
}
