namespace Datos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addTableCompany : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Empresas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Identificacion = c.String(nullable: false, maxLength: 50),
                        Nombre = c.String(nullable: false, maxLength: 50),
                        TipoRegimenId = c.Int(nullable: false),
                        RegistroMercantil = c.String(maxLength: 50),
                        CamaraComercio = c.String(nullable: false, maxLength: 50),
                        Direccion = c.String(nullable: false, maxLength: 50),
                        Telefono = c.String(nullable: false, maxLength: 50),
                        Email = c.String(nullable: false, maxLength: 50),
                        Contacto = c.String(maxLength: 50),
                        Logo = c.Binary(),
                        Slogan = c.String(maxLength: 255),
                        InteresCartera = c.Decimal(nullable: false, precision: 18, scale: 2),
                        TipoIdentificacionId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.TipoIdentificaciones", t => t.TipoIdentificacionId)
                .ForeignKey("dbo.TipoRegimen", t => t.TipoRegimenId, cascadeDelete: true)
                .Index(t => t.Identificacion, unique: true)
                .Index(t => t.TipoRegimenId)
                .Index(t => t.TipoIdentificacionId);
            
            CreateTable(
                "dbo.TipoRegimen",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, maxLength: 50),
                        Descripcion = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Empleados", "EmpresaId", c => c.Int(nullable: false));
            CreateIndex("dbo.Empleados", "EmpresaId");
            AddForeignKey("dbo.Empleados", "EmpresaId", "dbo.Empresas", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Empleados", "EmpresaId", "dbo.Empresas");
            DropForeignKey("dbo.Empresas", "TipoRegimenId", "dbo.TipoRegimen");
            DropForeignKey("dbo.Empresas", "TipoIdentificacionId", "dbo.TipoIdentificaciones");
            DropIndex("dbo.Empresas", new[] { "TipoIdentificacionId" });
            DropIndex("dbo.Empresas", new[] { "TipoRegimenId" });
            DropIndex("dbo.Empresas", new[] { "Identificacion" });
            DropIndex("dbo.Empleados", new[] { "EmpresaId" });
            DropColumn("dbo.Empleados", "EmpresaId");
            DropTable("dbo.TipoRegimen");
            DropTable("dbo.Empresas");
        }
    }
}
