using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{    
    public class Empleado : Persona
    {
        public override int Id { get; set ; }
        public override string Identificacion { get ; set; }
        public override string Nombre { get; set; }
        public override string Apellido { get ; set ; }
        public override string Direccion { get ; set ; }

        [Required]
        [MaxLength(50)]
        public string Telefono { get; set ; }        
        public override DateTime FechaNacimiento { get; set; }
        public override string Email { get ; set ; }
       
        public int UsuarioId { get; set; }
        public Usuario Usuario { get; set; }        

        public override int TipoIdentificacionId { get ; set ; }
        public override TipoIdentificacion TipoIdentificacion { get ; set ; }
        public override List<Prestamo> Prestamos { get ; set ; }
        public List<Pago> Pagos { get; set; }
    }
}
