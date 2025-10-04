namespace Datos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Amortizaciones_Capital",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Periodo = c.Int(nullable: false),
                        Interes = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Capital = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Saldo = c.Decimal(nullable: false, precision: 18, scale: 2),
                        PrestamoId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Prestamos", t => t.PrestamoId, cascadeDelete: true)
                .Index(t => t.PrestamoId);
            
            CreateTable(
                "dbo.Prestamos",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Codigo = c.String(nullable: false, maxLength: 50),
                        Monto = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Tiempo = c.Int(nullable: false),
                        Interes = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Fecha = c.DateTime(nullable: false),
                        Observacion = c.String(maxLength: 255),
                        ClienteId = c.Int(nullable: false),
                        TipoCobroId = c.Int(nullable: false),
                        FiadorId = c.Int(),
                        EmpleadoId = c.Int(nullable: false),
                        EstadoId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Clientes", t => t.ClienteId, cascadeDelete: true)
                .ForeignKey("dbo.Fiadores", t => t.FiadorId)
                .ForeignKey("dbo.Empleados", t => t.EmpleadoId, cascadeDelete: true)
                .ForeignKey("dbo.Estados", t => t.EstadoId, cascadeDelete: true)
                .ForeignKey("dbo.TipoCobros", t => t.TipoCobroId, cascadeDelete: true)
                .Index(t => t.Codigo, unique: true)
                .Index(t => t.ClienteId)
                .Index(t => t.TipoCobroId)
                .Index(t => t.FiadorId)
                .Index(t => t.EmpleadoId)
                .Index(t => t.EstadoId);
            
            CreateTable(
                "dbo.Amortizaciones",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Referencia = c.String(nullable: false, maxLength: 50),
                        Periodo = c.Int(nullable: false),
                        Fecha = c.DateTime(nullable: false),
                        Valor = c.Decimal(nullable: false, precision: 18, scale: 2),
                        PagoCompleto = c.Boolean(nullable: false),
                        PrestamoId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Prestamos", t => t.PrestamoId, cascadeDelete: true)
                .Index(t => t.Referencia, unique: true)
                .Index(t => t.PrestamoId);
            
            CreateTable(
                "dbo.Pagos",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Referencia = c.String(nullable: false, maxLength: 50),
                        Fecha = c.DateTime(nullable: false),
                        ValorPagar = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Observaciones = c.String(maxLength: 255),
                        FormaPagoId = c.Int(nullable: false),
                        TipoPagoId = c.Int(nullable: false),
                        EmpleadoId = c.Int(),
                        AmortizacionId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Amortizaciones", t => t.AmortizacionId, cascadeDelete: true)
                .ForeignKey("dbo.Empleados", t => t.EmpleadoId)
                .ForeignKey("dbo.FormaPagos", t => t.FormaPagoId, cascadeDelete: true)
                .ForeignKey("dbo.TipoPagos", t => t.TipoPagoId, cascadeDelete: true)
                .Index(t => t.Referencia, unique: true)
                .Index(t => t.FormaPagoId)
                .Index(t => t.TipoPagoId)
                .Index(t => t.EmpleadoId)
                .Index(t => t.AmortizacionId);
            
            CreateTable(
                "dbo.Empleados",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Identificacion = c.String(nullable: false, maxLength: 50),
                        Nombre = c.String(nullable: false, maxLength: 50),
                        Apellido = c.String(nullable: false, maxLength: 50),
                        Direccion = c.String(nullable: false, maxLength: 50),
                        Telefono = c.String(nullable: false, maxLength: 50),
                        Email = c.String(nullable: false, maxLength: 50),
                        UsuarioId = c.Int(nullable: false),
                        AreaId = c.Int(),
                        TipoIdentificacionId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.TipoIdentificaciones", t => t.TipoIdentificacionId)
                .ForeignKey("dbo.Areas", t => t.AreaId)
                .ForeignKey("dbo.Usuarios", t => t.UsuarioId, cascadeDelete: true)
                .Index(t => t.Identificacion, unique: true)
                .Index(t => t.UsuarioId)
                .Index(t => t.AreaId)
                .Index(t => t.TipoIdentificacionId);
            
            CreateTable(
                "dbo.Areas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, maxLength: 50),
                        Descripcion = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Clientes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Codigo = c.Int(nullable: false),
                        Identificacion = c.String(nullable: false, maxLength: 50),
                        Nombre = c.String(nullable: false, maxLength: 50),
                        Apellido = c.String(nullable: false, maxLength: 50),
                        FechaNacimiento = c.DateTime(nullable: false),
                        FechaExpedicion = c.DateTime(nullable: false),
                        Direccion = c.String(nullable: false, maxLength: 50),
                        Email = c.String(nullable: false, maxLength: 50),
                        EmperesaDondeLabora = c.String(nullable: false, maxLength: 50),
                        AreaId = c.Int(nullable: false),
                        TipoIdentificacionId = c.Int(nullable: false),
                        Observacion = c.String(maxLength: 255),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Areas", t => t.AreaId, cascadeDelete: true)
                .ForeignKey("dbo.TipoIdentificaciones", t => t.TipoIdentificacionId, cascadeDelete: true)
                .Index(t => t.Identificacion, unique: true)
                .Index(t => t.AreaId)
                .Index(t => t.TipoIdentificacionId);
            
            CreateTable(
                "dbo.Referencias",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Identificacion = c.String(nullable: false, maxLength: 50),
                        Nombre = c.String(nullable: false, maxLength: 50),
                        Apellido = c.String(nullable: false, maxLength: 50),
                        Direccion = c.String(nullable: false, maxLength: 50),
                        Email = c.String(nullable: false, maxLength: 50),
                        TipoIdentificacionId = c.Int(nullable: false),
                        Telefono = c.String(nullable: false, maxLength: 15),
                        ClienteId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Clientes", t => t.ClienteId)
                .ForeignKey("dbo.TipoIdentificaciones", t => t.TipoIdentificacionId, cascadeDelete: true)
                .Index(t => t.Identificacion, unique: true)
                .Index(t => t.TipoIdentificacionId)
                .Index(t => t.ClienteId);
            
            CreateTable(
                "dbo.TipoIdentificaciones",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, maxLength: 50),
                        Descripcion = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Fiadores",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Identificacion = c.String(nullable: false, maxLength: 50),
                        Nombre = c.String(nullable: false, maxLength: 50),
                        Apellido = c.String(nullable: false, maxLength: 50),
                        Direccion = c.String(nullable: false, maxLength: 50),
                        Telefono = c.String(nullable: false, maxLength: 50),
                        Email = c.String(nullable: false, maxLength: 50),
                        FechaNacimiento = c.DateTime(nullable: false),
                        EmperesaDondeLabora = c.String(nullable: false, maxLength: 50),
                        TipoIdentificacionId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.TipoIdentificaciones", t => t.TipoIdentificacionId, cascadeDelete: true)
                .Index(t => t.Identificacion, unique: true)
                .Index(t => t.TipoIdentificacionId);
            
            CreateTable(
                "dbo.Telefonos",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NumeroTelefonico = c.String(nullable: false, maxLength: 20),
                        ClienteId = c.Int(nullable: false),
                        TipoTelefonoId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Clientes", t => t.ClienteId, cascadeDelete: true)
                .ForeignKey("dbo.TipoTelefonos", t => t.TipoTelefonoId, cascadeDelete: true)
                .Index(t => t.ClienteId)
                .Index(t => t.TipoTelefonoId);
            
            CreateTable(
                "dbo.TipoTelefonos",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, maxLength: 50),
                        Descripcion = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Usuarios",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, maxLength: 50),
                        Password = c.String(nullable: false),
                        Sesion = c.Boolean(nullable: false),
                        RoleId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Roles", t => t.RoleId, cascadeDelete: true)
                .Index(t => t.Nombre, unique: true)
                .Index(t => t.RoleId);
            
            CreateTable(
                "dbo.Roles",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, maxLength: 50),
                        Descripcion = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.FormaPagos",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, maxLength: 50),
                        Descripcion = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TipoPagos",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, maxLength: 50),
                        Descripcion = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Estados",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, maxLength: 50),
                        Descripcion = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.PrestamoGarantias",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PrestamoId = c.Int(nullable: false),
                        GarantiaId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Garantias", t => t.GarantiaId, cascadeDelete: true)
                .ForeignKey("dbo.Prestamos", t => t.PrestamoId, cascadeDelete: true)
                .Index(t => t.PrestamoId)
                .Index(t => t.GarantiaId);
            
            CreateTable(
                "dbo.Garantias",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Documento = c.String(nullable: false, maxLength: 50),
                        Descripcion = c.String(),
                        TipoGarantiaId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.TipoGarantias", t => t.TipoGarantiaId, cascadeDelete: true)
                .Index(t => t.TipoGarantiaId);
            
            CreateTable(
                "dbo.TipoGarantias",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, maxLength: 50),
                        Descripcion = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TipoCobros",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, maxLength: 50),
                        Valor = c.Int(nullable: false),
                        Descripcion = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Prestamos", "TipoCobroId", "dbo.TipoCobros");
            DropForeignKey("dbo.PrestamoGarantias", "PrestamoId", "dbo.Prestamos");
            DropForeignKey("dbo.Garantias", "TipoGarantiaId", "dbo.TipoGarantias");
            DropForeignKey("dbo.PrestamoGarantias", "GarantiaId", "dbo.Garantias");
            DropForeignKey("dbo.Prestamos", "EstadoId", "dbo.Estados");
            DropForeignKey("dbo.Amortizaciones", "PrestamoId", "dbo.Prestamos");
            DropForeignKey("dbo.Pagos", "TipoPagoId", "dbo.TipoPagos");
            DropForeignKey("dbo.Pagos", "FormaPagoId", "dbo.FormaPagos");
            DropForeignKey("dbo.Usuarios", "RoleId", "dbo.Roles");
            DropForeignKey("dbo.Empleados", "UsuarioId", "dbo.Usuarios");
            DropForeignKey("dbo.Prestamos", "EmpleadoId", "dbo.Empleados");
            DropForeignKey("dbo.Pagos", "EmpleadoId", "dbo.Empleados");
            DropForeignKey("dbo.Empleados", "AreaId", "dbo.Areas");
            DropForeignKey("dbo.Telefonos", "TipoTelefonoId", "dbo.TipoTelefonos");
            DropForeignKey("dbo.Telefonos", "ClienteId", "dbo.Clientes");
            DropForeignKey("dbo.Referencias", "TipoIdentificacionId", "dbo.TipoIdentificaciones");
            DropForeignKey("dbo.Fiadores", "TipoIdentificacionId", "dbo.TipoIdentificaciones");
            DropForeignKey("dbo.Prestamos", "FiadorId", "dbo.Fiadores");
            DropForeignKey("dbo.Empleados", "TipoIdentificacionId", "dbo.TipoIdentificaciones");
            DropForeignKey("dbo.Clientes", "TipoIdentificacionId", "dbo.TipoIdentificaciones");
            DropForeignKey("dbo.Referencias", "ClienteId", "dbo.Clientes");
            DropForeignKey("dbo.Prestamos", "ClienteId", "dbo.Clientes");
            DropForeignKey("dbo.Clientes", "AreaId", "dbo.Areas");
            DropForeignKey("dbo.Pagos", "AmortizacionId", "dbo.Amortizaciones");
            DropForeignKey("dbo.Amortizaciones_Capital", "PrestamoId", "dbo.Prestamos");
            DropIndex("dbo.Garantias", new[] { "TipoGarantiaId" });
            DropIndex("dbo.PrestamoGarantias", new[] { "GarantiaId" });
            DropIndex("dbo.PrestamoGarantias", new[] { "PrestamoId" });
            DropIndex("dbo.Usuarios", new[] { "RoleId" });
            DropIndex("dbo.Usuarios", new[] { "Nombre" });
            DropIndex("dbo.Telefonos", new[] { "TipoTelefonoId" });
            DropIndex("dbo.Telefonos", new[] { "ClienteId" });
            DropIndex("dbo.Fiadores", new[] { "TipoIdentificacionId" });
            DropIndex("dbo.Fiadores", new[] { "Identificacion" });
            DropIndex("dbo.Referencias", new[] { "ClienteId" });
            DropIndex("dbo.Referencias", new[] { "TipoIdentificacionId" });
            DropIndex("dbo.Referencias", new[] { "Identificacion" });
            DropIndex("dbo.Clientes", new[] { "TipoIdentificacionId" });
            DropIndex("dbo.Clientes", new[] { "AreaId" });
            DropIndex("dbo.Clientes", new[] { "Identificacion" });
            DropIndex("dbo.Empleados", new[] { "TipoIdentificacionId" });
            DropIndex("dbo.Empleados", new[] { "AreaId" });
            DropIndex("dbo.Empleados", new[] { "UsuarioId" });
            DropIndex("dbo.Empleados", new[] { "Identificacion" });
            DropIndex("dbo.Pagos", new[] { "AmortizacionId" });
            DropIndex("dbo.Pagos", new[] { "EmpleadoId" });
            DropIndex("dbo.Pagos", new[] { "TipoPagoId" });
            DropIndex("dbo.Pagos", new[] { "FormaPagoId" });
            DropIndex("dbo.Pagos", new[] { "Referencia" });
            DropIndex("dbo.Amortizaciones", new[] { "PrestamoId" });
            DropIndex("dbo.Amortizaciones", new[] { "Referencia" });
            DropIndex("dbo.Prestamos", new[] { "EstadoId" });
            DropIndex("dbo.Prestamos", new[] { "EmpleadoId" });
            DropIndex("dbo.Prestamos", new[] { "FiadorId" });
            DropIndex("dbo.Prestamos", new[] { "TipoCobroId" });
            DropIndex("dbo.Prestamos", new[] { "ClienteId" });
            DropIndex("dbo.Prestamos", new[] { "Codigo" });
            DropIndex("dbo.Amortizaciones_Capital", new[] { "PrestamoId" });
            DropTable("dbo.TipoCobros");
            DropTable("dbo.TipoGarantias");
            DropTable("dbo.Garantias");
            DropTable("dbo.PrestamoGarantias");
            DropTable("dbo.Estados");
            DropTable("dbo.TipoPagos");
            DropTable("dbo.FormaPagos");
            DropTable("dbo.Roles");
            DropTable("dbo.Usuarios");
            DropTable("dbo.TipoTelefonos");
            DropTable("dbo.Telefonos");
            DropTable("dbo.Fiadores");
            DropTable("dbo.TipoIdentificaciones");
            DropTable("dbo.Referencias");
            DropTable("dbo.Clientes");
            DropTable("dbo.Areas");
            DropTable("dbo.Empleados");
            DropTable("dbo.Pagos");
            DropTable("dbo.Amortizaciones");
            DropTable("dbo.Prestamos");
            DropTable("dbo.Amortizaciones_Capital");
        }
    }
}
