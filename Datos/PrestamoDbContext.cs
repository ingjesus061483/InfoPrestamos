using Factory;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class PrestamoDbContext:DbContext
    {
        public PrestamoDbContext() : base(ConfigurationManager.ConnectionStrings["Prestamo-app"].ConnectionString)
        {

        }
        public DbSet<TipoIdentificacion> TipoIdentificacions { get; set; }
        public DbSet<Empleado> Empleados { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Fiador> Fiadors { get; set; }
        public DbSet<TipoCobro > TipoCobros { get; set; }
        public DbSet<Prestamo> Prestamos { get; set; }
        public DbSet <Cuota > Cuotas { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Garantia > Garantias { get; set; }
        public DbSet <PrestamoGarantia> PrestamoGarantias { get; set; }
        public DbSet<TipoPago >TipoPagos { get; set; }
        public DbSet <FormaPago >FormaPagos { get; set; }
        public DbSet <Pago> Pagos { get; set; }
        public DbSet <PagoCuota >PagoCuotas { get; set; }
        public DbSet<Telefono> Telefonos { get; set; }
        public DbSet<TipoTelefono> TipoTelefonos { get; set; }

    }
}
