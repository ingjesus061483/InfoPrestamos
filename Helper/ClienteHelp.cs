using Datos;
using DTO;
using Factory;
using Helper.DTO;
using System.Linq;
using System.Web.WebPages;
namespace Helper
{
    public class ClienteHelp : Help<ClienteDTO>
    {
        public override IQueryable<ClienteDTO> TEntity => context.Clientes.
            Include("Areas").
            Include("TipoIdentificaciones").
            Include("Telefonos").
            Include("TipoTelefonos").
            Include("Referencias").
            Include("Prestamos").
            Include("Fiadores").
            Include("TipoPrestamos").
            Include("Cuotas").
            Include ("Empleados").
            OrderBy(x => x.Nombre).Select(x => new ClienteDTO
            {
                Id = x.Id,
                Codigo = x.Codigo,
                Identificacion = x.Identificacion,
                Nombre = x.Nombre,
                Observacion = x.Observacion,
                EmperesaDondeLabora = x.EmperesaDondeLabora,
                FechaExpedicion = x.FechaExpedicion,
                Apellido = x.Apellido,
                Direccion = x.Direccion,
                FechaNacimiento = x.FechaNacimiento,
                Email = x.Email,
                Referencias=x.Referencias.Select(z=>new ReferenciaDTO
                {
                    Id=z.Id,
                    TipoIdentificacionId=z.TipoIdentificacionId,
                    TipoIdentificacion=z.TipoIdentificacion,
                    Identificacion=z.Identificacion,
                    Nombre=z.Nombre,
                    Apellido=z.Apellido,
                    Direccion=z.Direccion,
                    Email=z.Email,
                    Telefono=z.Telefono,
                    ClienteId=z.ClienteId,
                }).ToList(),
                Prestamos=x.Prestamos.Select(a=>new PrestamoDTO
                {
                    Id = a.Id,
                    ClienteId = a.ClienteId,
                    Monto = a.Monto,
                    Fecha = a.Fecha,
                    Interes = a.Interes,
                    Tiempo= a.Tiempo ,
                    EstadoId= a.EstadoId,
                    Estado = a.Estado,
                    Codigo = a.Codigo,
                    Observacion = a.Observacion,
                    TipoCobroId = a.TipoCobroId,
                    TipoCobro = a.TipoCobro,                    
                    FiadorId = a.FiadorId,
                    Fiador = context.Fiadors.Where(y => y.Id == a.FiadorId).Select(y => new FiadorDTO { }).FirstOrDefault(),
                    EmpleadoId = a.EmpleadoId,
                    Cuotas=a . Cuotas.Select(c=>new CuotaDTO
                    {
                        Codigo = c.Codigo,
                        Capital = c.Capital,
                        Valor = c.Valor,
                        Fecha=c.Fecha,
                        Id = c.Id,
                        Saldo = c.Saldo,
                        PagoCompleto = c.PagoCompleto,
                        Interes=c.Interes,
                        Observaciones   =c.Observaciones,
                        PrestamoId = c.PrestamoId,       
                    }).ToList(),
                }).ToList(),
                Telefonos = x.Telefonos.Select(z => new TelefonoDTO
                {
                    Id=z.Id,
                    NumeroTelefonico = z.NumeroTelefonico,
                    ClienteId = z.ClienteId,
                    TipoTelefono=z.TipoTelefono,
                    TipoTelefonoId=z.TipoTelefonoId,
                   
                }).ToList(),

                TipoIdentificacion = x.TipoIdentificacion,
                TipoIdentificacionId = x.TipoIdentificacionId,
                Area = x.Area,
                AreaId = x.AreaId
            });
        public ClienteHelp(PrestamoDbContext dbContext)
        {
            context =dbContext;
        }

        public override void Eliminar(int id)
        {
            var cliente = context.Clientes.Find(id);
            context.Clientes.Remove(cliente);
            context.SaveChanges();    
        }
        public override void Guardar(ClienteDTO clienteDTO)
        {
            Cliente cliente = new Cliente
            {
                EmperesaDondeLabora = clienteDTO.EmperesaDondeLabora,
                FechaExpedicion =clienteDTO.FechaExpedicion,
                Codigo = clienteDTO.Codigo,
                Identificacion = clienteDTO .Identificacion,
                Nombre = clienteDTO .Nombre,
                Apellido = clienteDTO.Apellido,
                Direccion = clienteDTO.Direccion ,                
                Email =clienteDTO .Email,
                FechaNacimiento =clienteDTO . FechaNacimiento,
                TipoIdentificacionId =int.Parse( clienteDTO.TipoIdentificacionId.ToString()),
                AreaId = clienteDTO.AreaId,
                Observacion = clienteDTO.Observacion


            };
            context.Clientes.Add(cliente);
            context.SaveChanges();
        }

        public override void Actualizar(int id, ClienteDTO clienteDTO)
        {
            var cliente = context.Clientes.Find(id);
            cliente.Identificacion = clienteDTO.Identificacion;
            cliente.EmperesaDondeLabora = clienteDTO.EmperesaDondeLabora;   
            cliente.Nombre = clienteDTO.Nombre;
            cliente.Apellido = clienteDTO.Apellido;
            cliente.Direccion = clienteDTO.Direccion;
            cliente.Email = clienteDTO.Email;
            cliente.FechaExpedicion = cliente.FechaExpedicion;
            cliente.FechaNacimiento = clienteDTO.FechaNacimiento;
            cliente.TipoIdentificacionId = int.Parse(clienteDTO.TipoIdentificacionId.ToString());
            cliente.AreaId = clienteDTO.AreaId;
            cliente.Observacion = clienteDTO.Observacion;
            cliente.Codigo = clienteDTO.Codigo;
            context.SaveChanges();
        }    
    }
}
