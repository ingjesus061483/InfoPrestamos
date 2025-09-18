using Datos;
using DTO;
using Factory;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Helper
{
    public class CuotaHelp : Help<CuotaDTO>
    {
        public CuotaHelp(PrestamoDbContext dbContext)
        {
            context = dbContext;
        }
        public override IQueryable<CuotaDTO> TEntity => context.Cuotas.Include("Pestamos").Select(x => new CuotaDTO
        {
            Id = x.Id,
            Codigo = x.Codigo,
            Fecha = x.Fecha,
            Valor = x.Valor,
            Interes = x.Interes,
            Capital = x.Capital,
            Saldo = x.Saldo,
            Observaciones = x.Observaciones,
            PagoCompleto = x.PagoCompleto,
            PrestamoId = x.PrestamoId,
            Prestamo = x.Prestamo
        });
        public List<CuotaDTO> GetCuotas(DateTime fechaIni, int tipocobro, double monto, double porcentajeInteres, double tiempo)
        {
            List<CuotaDTO> cuotas = new List<CuotaDTO>();
            double cuota = CalcularCuota(monto, porcentajeInteres, tiempo);
            double montoInicial = monto;
            for (int i = 1; i <= tiempo; i++)
            {
                double interes = Math.Round(montoInicial * porcentajeInteres);
                double capital = Math.Round(cuota - interes);
                double saldoInicial = Math.Round(montoInicial - capital);
                switch (tipocobro)
                {
                    
                    case 1:
                        {
                            Random random = new Random();
                            int next = random.Next();
                            DateTime date = fechaIni.AddMonths(i);
                            CuotaDTO  cuotaDTO = new CuotaDTO
                            {
                                Fecha = date,
                                Valor = decimal.Parse(cuota.ToString()),
                                Capital = decimal.Parse(capital.ToString()),
                                Saldo = decimal.Parse(saldoInicial.ToString()),
                                Interes = decimal.Parse(interes.ToString()),
                                Codigo = date.ToOADate().ToString()+next.ToString()

                            };
                            cuotas.Add(cuotaDTO);
                            montoInicial = saldoInicial;
                            break;
                        }
                    case 2:
                        {
                            //dtpFechaFinal.Value = dateTimePicker.Value.AddDays(1);
                            break;
                        }
                    case 3:                        
                        {
                            break; 
                        }
                }
            }
            return cuotas;
        }
        double CalcularCuota(double monto, double interes, double tiempo)
        {
            double numerador = monto * interes;
            double denominador = 1 - Math.Pow(1 / (1 + interes), tiempo);
            double cuota = numerador / denominador;
            return Math.Round(cuota, 2);
        }
        public override void Eliminar(int id)
        {
            var cuota = context.Cuotas.Find(id);
            context.Cuotas.Remove(cuota);
            context.SaveChanges();
        }
        public override void Guardar(CuotaDTO Entity)
        {
            Cuota cuota = new Cuota
            {
                Codigo = Entity.Codigo,
                Fecha = Entity.Fecha,
                Valor = Entity.Valor ,
                Interes = Entity.Interes,
                Capital = Entity.Capital,
                Saldo = Entity.Saldo,
                Observaciones = Entity.Observaciones,
                PagoCompleto = Entity.PagoCompleto,
                PrestamoId = Entity.PrestamoId
            };
            context.Cuotas.Add(cuota);
            context.SaveChanges();
        }
        public override void Actualizar(int id, CuotaDTO Entity)
        {
            Cuota cuota = context.Cuotas.Find(id);
            cuota.Codigo = Entity.Codigo;
            cuota.Fecha = Entity.Fecha;
            cuota.Valor = Entity.Valor;
            cuota.Interes = Entity.Interes;
            cuota.Capital = Entity.Capital;
            cuota.Saldo = Entity.Saldo;
            cuota.Observaciones = Entity.Observaciones;
            cuota.PagoCompleto = Entity.PagoCompleto;
            cuota.PrestamoId = Entity.PrestamoId;
            context.SaveChanges();
        }
    }
}
