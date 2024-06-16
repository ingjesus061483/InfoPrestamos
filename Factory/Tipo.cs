using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
  public  abstract  class Tipo
    {
        public abstract  int Id { get; set; }

        [Required(ErrorMessage = "Campo nombre es requerido")]
        [MaxLength(50, ErrorMessage = "Campo nombre no puede tener mas de 50 caracteres")]
        public abstract  string Nombre { get; set; }
        
        public abstract  string Descripcion { get; set; }

    }
}
