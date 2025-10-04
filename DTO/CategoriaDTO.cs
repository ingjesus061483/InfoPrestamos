using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace DTO
{
    public class CategoriaDTO
    {
        public int Id { get; set; }

        [Required ]
        [Display(Name ="Categoria")]
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public List<ProductoDTO> Productos { get; set; }
    }
}
