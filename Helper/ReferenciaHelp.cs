using Datos;
using DTO;
using Factory;
using Helper.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helper
{
    public class ReferenciaHelp : Help<ReferenciaDTO>
    {
        public ReferenciaHelp(PrestamoDbContext prestamoDbContext)
        {   
            context = prestamoDbContext;
        }
        public override IQueryable<ReferenciaDTO> TEntity => context.Referencias.
            Include("TipoIdentificaciones").
            Include("Clientes").Select(x => new ReferenciaDTO
            {
                Id = x.Id,
                Identificacion = x.Identificacion,
                Nombre = x.Nombre,
                Apellido = x.Apellido,
                Direccion = x.Direccion,
                Email = x.Email,
                TipoIdentificacionId = x.TipoIdentificacionId,
                TipoIdentificacion = x.TipoIdentificacion,
                Telefono = x.Telefono,
                ClienteId = x.ClienteId,
                Cliente =context.Clientes.Where(z=>z.Id== x.Cliente.Id).Select(z=> new ClienteDTO
                {
                    Id = z.Id,
                    Codigo = z.Codigo,
                    Identificacion = z.Identificacion,
                    Nombre = z.Nombre,
                    EmperesaDondeLabora = z.EmperesaDondeLabora,
                    Apellido = z.Apellido,
                    Direccion = z.Direccion,
                    FechaNacimiento = z.FechaNacimiento,
                    Email = z.Email,
                    TipoIdentificacion = z.TipoIdentificacion,
                    TipoIdentificacionId = z.TipoIdentificacionId,
                    AreaId = z.AreaId,
                    Area = z.Area
                }).FirstOrDefault()
            });

        public override void Actualizar(int id, ReferenciaDTO Entity)
        {
            var referencia = context.Referencias.Find(id);
            referencia.Identificacion = Entity.Identificacion;
            referencia.Nombre = Entity.Nombre;
            referencia.Apellido = Entity.Apellido;
            referencia.Direccion = Entity.Direccion;
            referencia.Email = Entity.Email;
            referencia.TipoIdentificacionId = Entity.TipoIdentificacionId;
            referencia.Telefono = Entity.Telefono;
            referencia.ClienteId = Entity.ClienteId;
            context.SaveChanges();

        }

        public override void Eliminar(int id)
        {
            var referencia = context.Referencias.Find(id);
            context.Referencias.Remove(referencia);
            context.SaveChanges();

        }

        public override void Guardar(ReferenciaDTO Entity)
        {
            Referencia referencia = new Referencia
            {
                Id = Entity.Id,
                Identificacion = Entity.Identificacion,
                Nombre = Entity.Nombre,
                Apellido = Entity.Apellido,
                Direccion = Entity.Direccion,
                Email = Entity.Email,
                TipoIdentificacionId = Entity.TipoIdentificacionId,
                Telefono = Entity.Telefono,
                ClienteId = Entity.ClienteId

            };
            context.Referencias.Add(referencia);
            context.SaveChanges();
        }
    }
}
