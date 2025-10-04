using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace DTO
{
   public  class UnidadMedidaDTO
    {
        public  int Id { get; set; }
        [Display(Name = "Unidad medida")]
        public  string Nombre { get; set; }
        public string Descripcion { get; set; }
        public List<ProductoDTO> Productos { get; set; }
    }
}
