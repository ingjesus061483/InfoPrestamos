using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
   public class Cliente : Persona
    {
        public override int Id { get ; set ; }
        public override string Identificacion { get ; set; }
        public override string Nombre { get ; set ; }
        public override string Apellido { get ; set ; }
        public override DateTime FechaNacimiento { get; set; }

        [Required]
        [Display(Name = "Fecha de expedicion")]
        public DateTime FechaExpedicion { get; set; }

        public override string Direccion { get ; set ; }
        public List<Telefono > Telefonos { get; set; }
        public override string Email { get; set; }
        public override int TipoIdentificacionId { get ; set ; }
        public override TipoIdentificacion TipoIdentificacion { get ; set ; }      
        public override List<Prestamo> Prestamos { get ; set ; }

        [MaxLength(255)]
        public string Observacion { get; set; }

    }
}
