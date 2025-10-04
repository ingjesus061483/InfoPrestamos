namespace Datos.Migrations
{
    using Datos.Seeder;
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
            UnidadMedidaSeeder.Run(context);
            Area[] areas =
            {
                new Area{Nombre="Chinita"},
                new Area{Nombre="Nieves"},
                new Area{Nombre="La luz"},
                
            };
            TipoPago[] tipoPagos =
            {
                new TipoPago{Nombre="Pago completo"},
                new TipoPago{Nombre="Abono"},
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
            TipoTelefono[] tipoTelefonos =
            {
                new TipoTelefono{Nombre="Fijo"},
                new TipoTelefono{Nombre="Celular"},
                new TipoTelefono {Nombre="whaatsapp"},
                new TipoTelefono {Nombre="Otro"}

            };
            Estado[] estados =
            {
                new Estado {Nombre="Cancelado"},
                new Estado {Nombre="Activo" }
                
            };
            TipoCobro[] tipoCobros =
            {
                new TipoCobro {Nombre="Mensual" ,Valor=1},
                new TipoCobro {Nombre="Quincenal",Valor = 15},
                new TipoCobro {Nombre="Diario",Valor = 30},

            };

            Role[] roles =
            {
                new Role {Nombre="Administrador"},
                new Role {Nombre="Cobrador"},
            };
            TipoRegimen[] regimens =
            {
                new TipoRegimen{Nombre="Comun"}, 
                new TipoRegimen{Nombre="Simplificado" },

            };
            context.TipoRegimens.AddOrUpdate(a=>a.Nombre,regimens);
            context.Estados.AddOrUpdate (e=>e.Nombre , estados);
            context.TipoTelefonos.AddOrUpdate(t=>t.Nombre, tipoTelefonos);
            context.Roles.AddOrUpdate(r=>r.Nombre, roles);
            context.TipoIdentificacions.AddOrUpdate(ti=>ti.Nombre, tipoIdentificacions);
            context.TipoCobros.AddOrUpdate(tc=>tc.Nombre, tipoCobros);
            context.FormaPagos.AddOrUpdate(fp=>fp.Nombre , formaPagos);
            context.TipoPagos.AddOrUpdate(tp=>tp.Nombre , tipoPagos );
            context.Areas.AddOrUpdate(tp => tp.Nombre, areas);
            Usuario[] usuarios =
            {
                new Usuario ("admin","admin1234."),
            };
            context.Usuarios.AddOrUpdate(us=>us.Nombre, usuarios);
            context.SaveChanges();
            Empresa[] empresas={
                new Empresa
                {
                    TipoIdentificacionId = 1,
                    Identificacion="1111",
                    Nombre="Empresa de ejemplo",
                    Direccion="calle con carrera",
                    InteresCartera=20,
                    Email="alguien@ejemplo.com",
                    CamaraComercio="aaaaa",
                    Telefono="3015106510",
                    TipoRegimenId=1                    
                }
            };
            context.Empresas.AddOrUpdate(e=>e.Identificacion, empresas);
            context.SaveChanges();
            Empleado[] empleados =
            {
                new Empleado 
                {
                    Apellido="administrador",
                    Nombre="administrador",
                    FechaNacimiento=DateTime .Now ,
                    Identificacion="11111",
                    TipoIdentificacionId=1,
                    UsuarioId=context.Usuarios.Where(x=>x.Nombre=="admin").FirstOrDefault().Id ,
                    Telefono ="333333",
                    Email ="admin@example.com",
                    Direccion="barranquilla",
                    EmpresaId=1,                    
                },
            };
            context.Empleados.AddOrUpdate (em =>em.Identificacion , empleados);
            context.SaveChanges();
        }
    }
}
