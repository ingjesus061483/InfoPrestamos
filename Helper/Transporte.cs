using Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helper
{
    public abstract  class Transporte
    {
        
        public static   object  Clientes
        {
            get 
            {   
                ClienteHelp ClienteHelp = new ClienteHelp();
                return ClienteHelp.Clientes.AsEnumerable().Select(x => new
                {
                    Id = x.Id,
                    Identificacion = x.Identificacion,
                    Nombre = x.Nombre,
                    Apellido = x.Apellido,
                    Direccion = x.Direccion,
                    FechaNacimiento = x.FechaNacimiento,
                    Email = x.Email,
                    Telefono = x.Telefono,
                    TipoIdentificacion = x.TipoIdentificacion.Nombre,
                    TipoIdentificacionId = x.TipoIdentificacionId
                }).ToList();
            }
        }
        public static object Prestamos
        {
            get
            {
                PrestamoHelp prestamoHelp = new PrestamoHelp();

                return prestamoHelp.Prestamos.AsEnumerable().Select(x => new {
                    Id = x.Id,
                    Codigo = x.Codigo,
                    Fecha = x.Fecha,
                    Monto = String.Format("{0:C}", x.Monto),
                    TipoCobro = x.TipoCobro.Nombre,
                    TipoCobroId = x.TipoCobroId,
                    Tiempo = x.Tiempo,
                    Interes = x.Interes,
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
        }
        public static object GetPrestamosByCliente(int idcliente)
        {
            PrestamoHelp prestamoHelp = new PrestamoHelp();

            return prestamoHelp.Prestamos.Where (x=>x.ClienteId ==idcliente ).AsEnumerable().Select(x => new {
                Id = x.Id,
                Codigo = x.Codigo,
                Fecha = x.Fecha,
                Monto = String.Format("{0:C}", x.Monto),
                TipoCobro = x.TipoCobro.Nombre,
                TipoCobroId = x.TipoCobroId,
                Tiempo = x.Tiempo,
                Interes = x.Interes,
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
        public static object  GetCuotasByPrestamos(List<Cuota> cuotas )
        {
            return cuotas.Select(x => new {
                Id = x.Id,
                Codigo = x.Codigo,
                Fecha = x.Fecha,
                Cuota = String.Format("{0:C}", x.Couta),
                Interes = String.Format("{0:C}", x.Interes),
                Capital = String.Format("{0:C}", x.Capital),
                Saldo = String.Format("{0:C}", x.Saldo),
                Observaciones = x.Observaciones,
                PagoCompleto = x.PagoCompleto,
                PrestamoId = x.PrestamoId,
                Prestamo = x.Prestamo != null ? x.Prestamo.Codigo:""
            }).ToList();
        }
        public static object GetCuotasByPrestamos(int idprestamo)
        {
            CuotaHelp cuotaHelp = new CuotaHelp();

            return cuotaHelp .GetCuotasByPrestamos(idprestamo ).AsEnumerable().Select(x => new {
                Id = x.Id,
                Codigo = x.Codigo,
                Fecha = x.Fecha,
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

        public static object Fiadores
        {
            get
            {
                FiadorHelp fiadorHelp  = new FiadorHelp ();
                return fiadorHelp .Fiadors .AsEnumerable().Select(x => new
                {
                    Id = x.Id,
                    Identificacion = x.Identificacion,
                    Nombre = x.Nombre,
                    Apellido = x.Apellido,
                    Direccion = x.Direccion,
                    FechaNacimiento = x.FechaNacimiento,
                    Email = x.Email,
                    EmperesaDondeLabora =x.EmperesaDondeLabora ,
                    Telefono = x.Telefono,
                    TipoIdentificacion = x.TipoIdentificacion.Nombre,
                    TipoIdentificacionId = x.TipoIdentificacionId
                }).ToList();
            }
        }
    }
}
