using System;
using System.ComponentModel.DataAnnotations;
namespace DTO
{
    public  class ExistenciaDTO
    {
        public int Id { get; set; }

        [Required]
        public DateTime Fecha { get; set; }

        [Required]
        [MaxLength(100)]
        public string Concepto { get; set; }

        [Required]
        public decimal Cantidad { get; set; }

        public bool Entrada { get; set; }

        [Required]
        public int ProductoId { get; set; }
        public ProductoDTO Producto { get; set; }
    }
}
