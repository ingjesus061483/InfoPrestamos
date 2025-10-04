using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfoPrestamos.Utilities
{
    public  class Persona
    {
        public   int Id { get; set; }

        [Required]
        [MaxLength(50)]
        [Index(IsUnique = true)]
        public   string Identificacion { get; set; }

        [Required]
        [MaxLength(50)]
        public   string Nombre { get; set; }

        [Required]
        [MaxLength(50)]
        public   string Apellido { get; set; }

        [Required]
        [MaxLength(50)]
        public  string Direccion { get; set; }
       
        [Required]
        [MaxLength(50)]
        [EmailAddress(ErrorMessage ="Email invalido")]
        public  string Email { get; set; }

        [Display(Name = "Fecha de nacimiento")]
        [Required]
        public DateTime FechaNacimiento{ get; set; }            
             
        public string NombreCompleto
        {
            get
            {
                return Nombre + " " + Apellido;
            }
        }


    }
}
