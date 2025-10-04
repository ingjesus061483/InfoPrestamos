using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
namespace DTO
{
    public  class ProductoDTO
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
        public decimal Costo { get; set; }

        [Required]      
        public decimal Precio { get; set; }

        [Required]
        public int CategoriaId { get; set; }
        public CategoriaDTO Categoria { get; set; }

        [Required]
        public int UnidadMedidaId { get; set; }
        public UnidadMedidaDTO UnidadMedida { get; set; }

        [MaxLength(255)]
        public string RutaImagen { get; set; }

        [MaxLength(255)]
        public string Descripcion { get; set; }
        public List<ExistenciaDTO> Existencias { get; set; }

        public List<ExistenciaDTO> Entradas
        {
            get
            {
                return Existencias != null ? Existencias.Where(x => x.ProductoId == Id && x.Entrada == true).ToList() : null;

            }
          
        }

        public List<ExistenciaDTO> Salidas
        {
            get
            {
                return Existencias != null ? Existencias.Where(x => x.ProductoId == Id && x.Entrada == false).ToList() : null;
            }
        }
        [Display(Name ="Total Entrada")]
        decimal _totalEntrada;
        public decimal TotalEntrada
        {
            get
            {
                _totalEntrada = 0;
                if (Entradas != null)
                {
                    foreach (var existencia in Entradas)
                    {
                        _totalEntrada += existencia.Cantidad;
                    }
                }
                return _totalEntrada;
            }
        }
        [Display(Name = "Total Salida")]
        decimal _totalSalida;
        public decimal TotalSalida
        {
            get
            {
                if (Salidas != null)
                {
                    _totalSalida = 0;
                    foreach (var existencia in Salidas)
                    {
                        _totalSalida += existencia.Cantidad;
                    }
                }
                return _totalSalida;
            }
        }
        [Display(Name = "Total Existencia")]
        public decimal TotalExistencia
        {
            get
            {
                return TotalEntrada - TotalSalida;
            }
        }
    }
}
