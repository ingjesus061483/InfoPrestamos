using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public abstract class Persona
    {
        public abstract  int Id { get; set; }


        [Required]
        [MaxLength(50)]
        [Index(IsUnique = true)]
        public abstract  string Identificacion { get; set; }

        [Required]
        [MaxLength(50)]
        public abstract  string Nombre { get; set; }

        [Required]
        [MaxLength(50)]
        public abstract  string Apellido { get; set; }

        [Required]
        [MaxLength(50)]
        public abstract  string Direccion { get; set; }
       
        [Required]
        [MaxLength(50)]
        [EmailAddress(ErrorMessage ="Email invalido")]
        public abstract string Email { get; set; }

        [Display(Name = "Fecha de nacimiento")]
        [Required]
        public abstract  DateTime FechaNacimiento{ get; set; }      

        [Display(Name ="Tipo identificacion")]
        public abstract  int TipoIdentificacionId { get; set; }
        public abstract TipoIdentificacion TipoIdentificacion { get; set; }

        public abstract List<Prestamo> Prestamos { get; set; }

         
        public string NombreCompleto
        {
            get
            {
                return Nombre + " " + Apellido;
            }
        }


    }
}
