using Factory;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
namespace DTO
{
    public class PrestamoDTO
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        [Index(IsUnique = true)]
        public string Referencia { get; set; }

        [Required]
        public decimal Monto { get; set; }

        [Required]
        [Display(Name =("Plazo en meses"))]
        public int Tiempo { get; set; }

        [Required]
        public decimal Interes { get; set; }

        [Required]
        public DateTime Fecha { get; set; }

        [MaxLength(255)]
        public string Observacion { get; set; }

        [Required]
        public int ClienteId { get; set; }
        public ClienteDTO Cliente { get; set; }

        [Required]
        public int EstadoId { get; set; }
        public Estado Estado { get; set; }

        [Required]
        public int TipoCobroId { get; set; }
        public TipoCobro TipoCobro { get; set; }

        public int? FiadorId { get; set; }
        public FiadorDTO Fiador { get; set; }

        [Required]
        public int EmpleadoId { get; set; }
        public EmpleadoDTO Empleado { get; set; }

        public List<PrestamoGarantia> PrestamoGarantias { get; set; }

        [Required]
        public List<AmortizacionDTO> Amortizacions { get; set; }

        double _monto;
        double _interes;
        public  double  Cuota 
        { 
            get
            {
                _interes = double.Parse(Interes.ToString());
                _monto =double.Parse( Monto.ToString());
                return Math.Round(Financial.Pmt(_interes/100, Tiempo, -_monto, 2));

            } 
        }
        public double Total
        {
            get
            {
                return Cuota * Tiempo;
            }
        }
       
        double _plazo = 0;
        public string  Modo
        {
            get
            {
                if (TipoCobro != null)
                {
                    _plazo = TipoCobro.Valor == 30 || TipoCobro.Valor == 1 ? (Tiempo * TipoCobro.Valor) : double.Parse(TipoCobro.Valor.ToString()) == 0 ? 1 :
                       (double)(Tiempo * 30 / TipoCobro.Valor);
                    return $"{_plazo} {TipoCobro.Nombre}";
                }
                return string.Empty;
            }
        }
        [Display(Name = "Total Abonado")]
        public decimal TotalAmortizado
        {
            get
            {
                if (Amortizacions != null && Amortizacions.Count > 0)
                {
                    return Amortizacions. Sum(x => x.Abono);
                }
                return 0;
            }
        }
        public double Saldo
        {
            get
            {
                return Total - double.Parse(TotalAmortizado.ToString());
            }
        }
    }
}
