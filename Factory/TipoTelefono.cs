using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    [Table("TipoTelefonos")]
    public class TipoTelefono : Tipo
    {
        public override int Id { get; set ; }
        public override string Nombre { get; set ; }
        public override string Descripcion { get; set ; }
        public List<Telefono>Telefonos { get; set ; }

    }
}
