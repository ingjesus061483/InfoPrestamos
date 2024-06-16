namespace Datos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Clientes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Identificacion = c.String(nullable: false, maxLength: 50),
                        Nombre = c.String(nullable: false, maxLength: 50),
                        Apellido = c.String(nullable: false, maxLength: 50),
                        FechaNacimiento = c.DateTime(nullable: false),
                        Direccion = c.String(nullable: false, maxLength: 50),
                        Telefono = c.String(nullable: false, maxLength: 50),
                        Email = c.String(nullable: false, maxLength: 50),
                        TipoIdentificacionId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.TipoIdentificacions", t => t.TipoIdentificacionId, cascadeDelete: true)
                .Index(t => t.Identificacion, unique: true)
                .Index(t => t.TipoIdentificacionId);
            
            CreateTable(
                "dbo.Prestamoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Codigo = c.String(nullable: false, maxLength: 50),
                        Monto = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Tiempo = c.Int(nullable: false),
                        Interes = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Fecha = c.DateTime(nullable: false),
                        Observacion = c.String(),
                        EsCancelado = c.Boolean(nullable: false),
                        ClienteId = c.Int(nullable: false),
                        TipoCobroId = c.Int(nullable: false),
                        FiadorId = c.Int(),
                        EmpleadoId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Clientes", t => t.ClienteId, cascadeDelete: true)
                .ForeignKey("dbo.Empleadoes", t => t.EmpleadoId, cascadeDelete: true)
                .ForeignKey("dbo.Fiadors", t => t.FiadorId)
                .ForeignKey("dbo.TipoCobroes", t => t.TipoCobroId, cascadeDelete: true)
                .Index(t => t.Codigo, unique: true)
                .Index(t => t.ClienteId)
                .Index(t => t.TipoCobroId)
                .Index(t => t.FiadorId)
                .Index(t => t.EmpleadoId);
            
            CreateTable(
                "dbo.Cuotas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Codigo = c.String(nullable: false, maxLength: 50),
                        Observaciones = c.String(),
                        Fecha = c.DateTime(nullable: false),
                        Capital = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Interes = c.Decimal(nullable: false, precision: 18, scale: 2),
                        PagoCompleto = c.Boolean(nullable: false),
                        PrestamoId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Prestamoes", t => t.PrestamoId, cascadeDelete: true)
                .Index(t => t.Codigo, unique: true)
                .Index(t => t.PrestamoId);
            
            CreateTable(
                "dbo.Empleadoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Identificacion = c.String(nullable: false, maxLength: 50),
                        Nombre = c.String(nullable: false, maxLength: 50),
                        Apellido = c.String(nullable: false, maxLength: 50),
                        Direccion = c.String(nullable: false, maxLength: 50),
                        Telefono = c.String(nullable: false, maxLength: 50),
                        FechaNacimiento = c.DateTime(nullable: false),
                        Email = c.String(nullable: false, maxLength: 50),
                        UsuarioId = c.Int(nullable: false),
                        TipoIdentificacionId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.TipoIdentificacions", t => t.TipoIdentificacionId,  cascadeDelete:false)
                .ForeignKey("dbo.Usuarios", t => t.UsuarioId, cascadeDelete: true)
                .Index(t => t.Identificacion, unique: true)
                .Index(t => t.UsuarioId)
                .Index(t => t.TipoIdentificacionId);
            
            CreateTable(
                "dbo.TipoIdentificacions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, maxLength: 50),
                        Descripcion = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Fiadors",
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
                        TipoIdentificacionId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.TipoIdentificacions", t => t.TipoIdentificacionId, cascadeDelete: true)
                .Index(t => t.Identificacion, unique: true)
                .Index(t => t.TipoIdentificacionId);
            
            CreateTable(
                "dbo.Usuarios",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, maxLength: 50),
                        Password = c.String(nullable: false),
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
                "dbo.PrestamoGarantias",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PrestamoId = c.Int(nullable: false),
                        GarantiaId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Garantias", t => t.GarantiaId, cascadeDelete: true)
                .ForeignKey("dbo.Prestamoes", t => t.PrestamoId, cascadeDelete: true)
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
                "dbo.TipoCobroes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, maxLength: 50),
                        Descripcion = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Prestamoes", "TipoCobroId", "dbo.TipoCobroes");
            DropForeignKey("dbo.PrestamoGarantias", "PrestamoId", "dbo.Prestamoes");
            DropForeignKey("dbo.Garantias", "TipoGarantiaId", "dbo.TipoGarantias");
            DropForeignKey("dbo.PrestamoGarantias", "GarantiaId", "dbo.Garantias");
            DropForeignKey("dbo.Usuarios", "RoleId", "dbo.Roles");
            DropForeignKey("dbo.Empleadoes", "UsuarioId", "dbo.Usuarios");
            DropForeignKey("dbo.Fiadors", "TipoIdentificacionId", "dbo.TipoIdentificacions");
            DropForeignKey("dbo.Prestamoes", "FiadorId", "dbo.Fiadors");
            DropForeignKey("dbo.Empleadoes", "TipoIdentificacionId", "dbo.TipoIdentificacions");
            DropForeignKey("dbo.Clientes", "TipoIdentificacionId", "dbo.TipoIdentificacions");
            DropForeignKey("dbo.Prestamoes", "EmpleadoId", "dbo.Empleadoes");
            DropForeignKey("dbo.Cuotas", "PrestamoId", "dbo.Prestamoes");
            DropForeignKey("dbo.Prestamoes", "ClienteId", "dbo.Clientes");
            DropIndex("dbo.Garantias", new[] { "TipoGarantiaId" });
            DropIndex("dbo.PrestamoGarantias", new[] { "GarantiaId" });
            DropIndex("dbo.PrestamoGarantias", new[] { "PrestamoId" });
            DropIndex("dbo.Usuarios", new[] { "RoleId" });
            DropIndex("dbo.Usuarios", new[] { "Nombre" });
            DropIndex("dbo.Fiadors", new[] { "TipoIdentificacionId" });
            DropIndex("dbo.Fiadors", new[] { "Identificacion" });
            DropIndex("dbo.Empleadoes", new[] { "TipoIdentificacionId" });
            DropIndex("dbo.Empleadoes", new[] { "UsuarioId" });
            DropIndex("dbo.Empleadoes", new[] { "Identificacion" });
            DropIndex("dbo.Cuotas", new[] { "PrestamoId" });
            DropIndex("dbo.Cuotas", new[] { "Codigo" });
            DropIndex("dbo.Prestamoes", new[] { "EmpleadoId" });
            DropIndex("dbo.Prestamoes", new[] { "FiadorId" });
            DropIndex("dbo.Prestamoes", new[] { "TipoCobroId" });
            DropIndex("dbo.Prestamoes", new[] { "ClienteId" });
            DropIndex("dbo.Prestamoes", new[] { "Codigo" });
            DropIndex("dbo.Clientes", new[] { "TipoIdentificacionId" });
            DropIndex("dbo.Clientes", new[] { "Identificacion" });
            DropTable("dbo.TipoCobroes");
            DropTable("dbo.TipoGarantias");
            DropTable("dbo.Garantias");
            DropTable("dbo.PrestamoGarantias");
            DropTable("dbo.Roles");
            DropTable("dbo.Usuarios");
            DropTable("dbo.Fiadors");
            DropTable("dbo.TipoIdentificacions");
            DropTable("dbo.Empleadoes");
            DropTable("dbo.Cuotas");
            DropTable("dbo.Prestamoes");
            DropTable("dbo.Clientes");
        }
    }
}
