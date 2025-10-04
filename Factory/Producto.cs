using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    [Table("Productos")]
    public class Producto
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        [Index(IsUnique = true)]
        public string Codigo { get; set; }

        [Required]
        [MaxLength(50)]
        public string Nombre { get; set; }

        [Required]
        [MaxLength(50)]
        public string Referencia { get; set; }

        [Required]
        [Column(TypeName = "decimal")]
        public decimal Costo { get; set; }

        [Required]
        [Column(TypeName = "decimal")]
        public decimal Precio { get; set; }

        [Required]
        public int CategoriaId { get; set; }
        public Categoria Categoria { get; set; }

        [Required]
        public int UnidadMedidaId { get; set; }
        public UnidadMedida UnidadMedida { get; set; }

        [MaxLength(255)]
        public string RutaImagen { get; set; }

        [MaxLength(255)]
        public string Descripcion { get; set; }

       public List <Existencia> Existencias {  get; set; }
    }
}
