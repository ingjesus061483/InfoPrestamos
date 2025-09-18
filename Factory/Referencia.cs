using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    [Table("Referencias")]
    public class Referencia : Persona
    {
        public override int Id { get; set; }
        public override string Identificacion { get ; set ; }
        public override string Nombre { get; set; }
        public override string Apellido { get; set; }
        public override string Direccion { get; set; }
        public override string Email { get; set; }

        [NotMapped]
        public override DateTime FechaNacimiento { get; set; }
        public int TipoIdentificacionId { get; set; }
        public TipoIdentificacion TipoIdentificacion { get; set; }

        [NotMapped]
        public override List<Prestamo> Prestamos { get; set; }

        [Required]
        [MaxLength(15)]
        public string Telefono { get; set; }
        
        public int? ClienteId { get; set; }
        public Cliente Cliente { get; set; }
    }
}
