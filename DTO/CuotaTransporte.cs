using Factory;
using Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Transporte.View;

namespace Transporte
{
    public class CuotaTransporte : Transport<View.CuotaView>
    {
         CuotaHelp cuotaHelp;
        public CuotaTransporte(CuotaHelp _cuotaHelp )
        {
            cuotaHelp = _cuotaHelp ;
        }
        public override List<View.CuotaView> List => throw new NotImplementedException();

        public override void CargarDatos(List<CuotaView> telefonos)
        {
            throw new NotImplementedException();
        }

        public override List<View.CuotaView >  GetList(object list)
        {
            List<Cuota> cuotas = (List<Cuota>)list; 
            return cuotas.Select(x => new View.CuotaView
            {
                Id = x.Id,
                Codigo = x.Codigo,
                Fecha = x.Fecha.ToString("yyyy/MM/dd"),
                Cuota = String.Format("{0:C}", x.Couta),
                Interes = String.Format("{0:C}", x.Interes),
                Capital = String.Format("{0:C}", x.Capital),
                Saldo = String.Format("{0:C}", x.Saldo),
                Observaciones = x.Observaciones,
                PagoCompleto = x.PagoCompleto,
                PrestamoId = x.PrestamoId,
                Prestamo = x.Prestamo != null ? x.Prestamo.Codigo : ""
            }).ToList();
        }
        public override List<View.CuotaView> GetList(int idprestamo)
        {
            return cuotaHelp.TEntity.Where(x=>x.PrestamoId== idprestamo).AsEnumerable().Select(x => new View.CuotaView
            {
                Id = x.Id,
                Codigo = x.Codigo,
                Fecha = x.Fecha.ToString("yyyy/MM/dd"),
                Cuota = String.Format("{0:C}", x.Couta),
                Interes = String.Format("{0:C}", x.Interes),
                Capital = String.Format("{0:C}", x.Capital),
                Saldo = String.Format("{0:C}", x.Saldo),
                Observaciones = x.Observaciones,
                PagoCompleto = x.PagoCompleto,
                PrestamoId = x.PrestamoId,
                Prestamo = x.Prestamo != null ? x.Prestamo.Codigo : ""
            }).ToList();
        }

       
    }
}
