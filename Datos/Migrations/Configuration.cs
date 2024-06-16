namespace Datos.Migrations
{
    using Factory;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Datos.PrestamoDbContext>
    {
        public Configuration()
        {
         //   AutomaticMigrationsEnabled = true;
           // AutomaticMigrationDataLossAllowed = true;
            
        }

        protected override void Seed(Datos.PrestamoDbContext context)
        {
            //  This method will be called after migrating to the latest version.
            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
            TipoPago[] tipoPagos =
            {
                new TipoPago{Nombre="Pago Cuota"},
                new TipoPago{Nombre="Abono a Capital"},
                new TipoPago{Nombre="Abono a Interes"},

            };
            FormaPago[] formaPagos =
            {
                new FormaPago {Nombre="Efectivo"},
                new FormaPago {Nombre="Tarjeta debito"},
                new FormaPago {Nombre="Tarjeta credito"},
            };


TipoIdentificacion[] tipoIdentificacions =
            {
                new TipoIdentificacion{Nombre="Cedula"},
                new TipoIdentificacion{ Nombre ="Nit"}
            };
            TipoTelefono[] tipoTelefono =
            {
                new TipoTelefono{Nombre="Fijo"},
                new TipoTelefono{Nombre="Celular"},
                new TipoTelefono {Nombre="whaatsapp"},
                new TipoTelefono {Nombre="Otro"}

            };
            TipoCobro[] tipoCobros =
            {
                new TipoCobro {Nombre="Mensual"},
                new TipoCobro {Nombre="Quincenal"},
                new TipoCobro {Nombre="Diario"},

            };

            Role[] roles =
            {
                new Role {Nombre="Administrador"},
                new Role {Nombre="Cobrador"},
            };
            context.TipoTelefonos.AddOrUpdate(tipoTelefono);
            context.Roles.AddOrUpdate(roles);
            context.TipoIdentificacions.AddOrUpdate(tipoIdentificacions);
            context.TipoCobros.AddOrUpdate(tipoCobros);
            context.FormaPagos.AddOrUpdate(formaPagos);
            context.TipoPagos.AddOrUpdate(tipoPagos);

            //Usuario[] usuarios =
            //{
            //    new Usuario ("admin","admin1234."),
            //};
            //context.Usuarios.AddOrUpdate(usuarios);
            //Empleado[] empleados =
            //{
            //    new Empleado { Apellido="administrador",
            //    Nombre="administrador",
            //    FechaNacimiento=DateTime .Now ,
            //    Identificacion="11111",
            //    TipoIdentificacionId=1,
            //    UsuarioId=1,
            //    Telefono ="333333",
            //    Email ="admin@example.com",
            //    Direccion="barranquilla",
            //    },
            //};
            //context.Empleados.AddOrUpdate(empleados);
                
      
        }
    }
}
