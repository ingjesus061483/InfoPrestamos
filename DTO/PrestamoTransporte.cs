using Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Transporte.View;

namespace Transporte
{
   
    public class PrestamoTransporte : Transport<View. PrestamoView>
    {
        PrestamoHelp prestamoHelp;
        public PrestamoTransporte( PrestamoHelp _prestamoHelp )
        {
             prestamoHelp = _prestamoHelp;

        }

        public override List < View . PrestamoView> List
        {
            get
            {
                return prestamoHelp.Prestamos.AsEnumerable().Select(x => new View.PrestamoView
                {
                    Id= x.Id,
                    Codigo = x.Codigo,
                    Fecha= x.Fecha.ToString("yyyy/MM/dd"),
                    Monto = String.Format("{0:C}", x.Monto),
                    TipoCobro=x.TipoCobro.Nombre,
                     TipoCobroId = x.TipoCobroId,
                    Tiempo = x.Tiempo,
                    Interes = x.Interes,
                    Cuotas= String.Format("{0:C}", Utilities  .CalcularCuotas(double .Parse ( x.Monto.ToString ()) ,double .Parse( x.Interes.ToString ()) ,x.Tiempo )),
                    Cliente = x.Cliente.NombreCompleto,
                    ClienteId = x.ClienteId,
                    Empleado = x.Empleado.NombreCompleto,
                   EmpleadoId= x.EmpleadoId,
                    Fiador = x.Fiador != null ? x.Fiador.NombreCompleto : "",
                    FiadorId = x.FiadorId,
                    EsCancelado = x.EsCancelado,
                    Observacion = x.Observacion,

                }).ToList();
            }
        }

        public override void CargarDatos(List<PrestamoView> telefonos)
        {
            throw new NotImplementedException();
        }

        public override List<View.PrestamoView> GetList(int idcliente)
        {
            return prestamoHelp.Prestamos.Where(x => x.ClienteId == idcliente).AsEnumerable().Select(x => new View.PrestamoView
            {
                Id = x.Id,
                Codigo = x.Codigo,
                Fecha = x.Fecha.ToString("yyyy/MM/dd"),
                Monto = String.Format("{0:C}", x.Monto),
                TipoCobro = x.TipoCobro.Nombre,
                TipoCobroId = x.TipoCobroId,
                Tiempo = x.Tiempo,
                Interes = x.Interes,
                Cuotas = String.Format("{0:C}", Utilities.CalcularCuotas(double.Parse(x.Monto.ToString()), double.Parse(x.Interes.ToString()), x.Tiempo)),
                Cliente = x.Cliente.NombreCompleto,
                ClienteId = x.ClienteId,
                Empleado = x.Empleado.NombreCompleto,
                EmpleadoId = x.EmpleadoId,
                Fiador = x.Fiador != null ? x.Fiador.NombreCompleto : "",
                FiadorId = x.FiadorId,
                EsCancelado = x.EsCancelado,
                Observacion = x.Observacion,
            }).ToList();
        }

        public override List <View.PrestamoView > GetList(object list)
        {
            throw new NotImplementedException();
        }
    }
}
