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
    public class PrestamoHelp : Help<PrestamoDTO>
    {
        public PrestamoHelp(PrestamoDbContext dbContext  )
        {
            context = dbContext;
        }
        public override IQueryable<PrestamoDTO> TEntity => context.Prestamos
            .Include("Clientes").
            Include("Fiadores").
            Include("Empleados").
            Include("TipoCobros").
            Include("Cuotas").
            Include ("Pagos")
            .Select(x => new PrestamoDTO
            {
                Id = x.Id,
                Codigo = x.Codigo,
                Fecha = x.Fecha,
                Monto = x.Monto,
                TipoCobro = x.TipoCobro,
                TipoCobroId = x.TipoCobroId,
                Tiempo = x.Tiempo,
                Interes = x.Interes,
                Cliente =context.Clientes
                .Where(z=>z.Id== x.ClienteId)
                .Select(y=>new ClienteDTO
                { 
                    Id = y.Id,
                    Nombre = y.Nombre,
                    Apellido = y.Apellido,
                    Codigo = y.Codigo,
                    Direccion = y.Direccion,
                    Email = y.Email,
                    EmperesaDondeLabora = y.EmperesaDondeLabora,
                    FechaExpedicion = y.FechaExpedicion,
                    FechaNacimiento = y.FechaNacimiento,
                    Identificacion = y.Identificacion,
                    TipoIdentificacionId = y.TipoIdentificacionId,                    
                    AreaId = y.AreaId,
                    Observacion = y.Observacion,


                }).FirstOrDefault(),
                ClienteId = x.ClienteId,
                Empleado = context.Empleados.Where(z=>z.Id == x.EmpleadoId).Select (y=>new EmpleadoDTO 
                {
                    Id = y.Id,
                    Nombre = y.Nombre,
                    Apellido = y.Apellido,
                    AreaId = y.AreaId,
                    Direccion = y.Direccion,
                    Email   = y.Email,
                    Identificacion = y.Identificacion,
                    FechaNacimiento = y.FechaNacimiento,
                    TipoIdentificacionId = y.TipoIdentificacionId,
                    UsuarioId = y.UsuarioId,
                }).FirstOrDefault (),
                EmpleadoId = x.EmpleadoId,
                Fiador = context .Fiadors.Where(z=>z.Id== x.FiadorId).Select(y=> new FiadorDTO
                {
                    Id = y.Id,
                    Nombre = y.Nombre,
                    Apellido = y.Apellido,
                    Identificacion = y.Identificacion,
                    Direccion = y.Direccion,
                    Telefono = y.Telefono,
                    Email = y.Email,
                    EmperesaDondeLabora = y.EmperesaDondeLabora,
                    FechaNacimiento = y.FechaNacimiento,
                    TipoIdentificacionId = y.TipoIdentificacionId,
                }).FirstOrDefault(),
                FiadorId = x.FiadorId,
                EstadoId=x.EstadoId,
                Estado = x.Estado,
                Observacion = x.Observacion,
                Cuotas = x.Cuotas.Select(y => new CuotaDTO
                {
                    Id= y.Id,
                    Codigo  = y.Codigo,
                    Capital = y.Capital,
                    Interes = y.Interes,
                    Fecha = y.Fecha,
                    Valor = y.Valor,
                    PrestamoId = y.PrestamoId,
                    PagoCompleto = y.PagoCompleto,
                    Saldo = y.Saldo,
                    Observaciones = y.Observaciones,
                }).ToList()
            });

        public override void Actualizar(int id, PrestamoDTO Entity)
        {
            throw new NotImplementedException();
        }

        public override void Eliminar(int id)
        {
            Prestamo prestamo = context.Prestamos.Find(id);
            context.Prestamos.Remove(prestamo);
            context.SaveChanges();
        }       
        public override void Guardar(PrestamoDTO Entity)
        {            
            Prestamo prestamo = new Prestamo
            {
                Codigo = Entity.Codigo,
                Monto = Entity.Monto,
                Tiempo =Entity. Tiempo,
                Interes =Entity.Interes,
                Fecha = Entity.Fecha,
                Observacion = Entity.Observacion,
                EstadoId =Entity.EstadoId,
                ClienteId =Entity.ClienteId,
                TipoCobroId = Entity.TipoCobroId,
                FiadorId = Entity.FiadorId ==0 ? null : Entity.FiadorId,
                EmpleadoId =Entity .EmpleadoId ,
                Cuotas = Entity.Cuotas.Select(x=>new Cuota
                {
                    Codigo = x.Codigo,
                    Fecha = x.Fecha,
                   Valor= x.Valor,
                   Capital= x.Capital,
                 Interes=   x.Interes,
                   Saldo= x.Saldo

                }).ToList()

            };
            context.Prestamos.Add(prestamo);
            context.SaveChanges();              
        }
    }
}
