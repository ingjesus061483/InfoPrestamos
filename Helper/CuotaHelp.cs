using Datos;
using DTO;
using Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Helper
{
    public class CuotaHelp : Help
    {
        public IQueryable<CuotaDTO> Cuotas
        {
            get
            {
                return context.Cuotas.Include("Pestamos").Select(x => new CuotaDTO
                {
                    Id = x.Id,
                    Codigo = x.Codigo,
                    Fecha = x.Fecha,
                    Couta = x.Couta,
                    Interes = x.Interes,
                    Capital = x.Capital,
                    Saldo = x.Saldo,
                    Observaciones = x.Observaciones,
                    PagoCompleto = x.PagoCompleto,
                    PrestamoId = x.PrestamoId,
                    Prestamo = x.Prestamo
                });
            }
        }
        public CuotaHelp(PrestamoDbContext dbContext )
        {
            context = dbContext;
        }
        public IQueryable<CuotaDTO>GetCuotasByPrestamos(int prestamoId)
        {
            return context.Cuotas.Include("Pestamos").Where(x => x.PrestamoId == prestamoId).Select(x => new CuotaDTO
            {
                Id = x.Id,
                Codigo = x.Codigo,
                Fecha = x.Fecha,
                Couta = x.Couta,
                Interes = x.Interes,
                Capital = x.Capital,
                Saldo = x.Saldo,
                Observaciones = x.Observaciones,
                PagoCompleto = x.PagoCompleto,
                PrestamoId = x.PrestamoId,
                Prestamo = x.Prestamo
            });            
        }  
        public override void Actualizar(int id, Dictionary<string, object> collection)
        {
            throw new NotImplementedException();
        }
        public override void Eliminar(int id)
        {
            throw new NotImplementedException();
        }
        public override void Guardar(Dictionary<string, object> collection)
        {
            Prestamo prestamo = (Prestamo)collection["prestamo"];
            Cuota cuota = (Cuota)collection["cuota"];
            cuota.PrestamoId = prestamo.Id;
            context.Cuotas.Add(cuota);
            context.SaveChanges();
        }

        public override void Guardar(FormCollection collection)
        {
            throw new NotImplementedException();
        }

        public override void Actualizar(int id, FormCollection collection)
        {
            throw new NotImplementedException();
        }
    }
}
