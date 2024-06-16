namespace Datos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Pagos : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.PagoCuotas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PagoId = c.Int(nullable: false),
                        CuotaId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Cuotas", t => t.CuotaId, cascadeDelete: true)
                .ForeignKey("dbo.Pagoes", t => t.PagoId, cascadeDelete: true)
                .Index(t => t.PagoId)
                .Index(t => t.CuotaId);
            
            CreateTable(
                "dbo.Pagoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Referencia = c.String(nullable: false, maxLength: 50),
                        Fecha = c.DateTime(nullable: false),
                        PagoMinimo = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ValorPagar = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Observaciones = c.String(),
                        FormaPagoId = c.Int(nullable: false),
                        TipoPagoId = c.Int(nullable: false),
                        EmpleadoId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Empleadoes", t => t.EmpleadoId, cascadeDelete: false)
                .ForeignKey("dbo.FormaPagoes", t => t.FormaPagoId, cascadeDelete: true)
                .ForeignKey("dbo.TipoPagoes", t => t.TipoPagoId, cascadeDelete: true)
                .Index(t => t.Referencia, unique: true)
                .Index(t => t.FormaPagoId)
                .Index(t => t.TipoPagoId)
                .Index(t => t.EmpleadoId);
            
            CreateTable(
                "dbo.FormaPagoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, maxLength: 50),
                        Descripcion = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TipoPagoes",
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
            DropForeignKey("dbo.Pagoes", "TipoPagoId", "dbo.TipoPagoes");
            DropForeignKey("dbo.PagoCuotas", "PagoId", "dbo.Pagoes");
            DropForeignKey("dbo.Pagoes", "FormaPagoId", "dbo.FormaPagoes");
            DropForeignKey("dbo.Pagoes", "EmpleadoId", "dbo.Empleadoes");
            DropForeignKey("dbo.PagoCuotas", "CuotaId", "dbo.Cuotas");
            DropIndex("dbo.Pagoes", new[] { "EmpleadoId" });
            DropIndex("dbo.Pagoes", new[] { "TipoPagoId" });
            DropIndex("dbo.Pagoes", new[] { "FormaPagoId" });
            DropIndex("dbo.Pagoes", new[] { "Referencia" });
            DropIndex("dbo.PagoCuotas", new[] { "CuotaId" });
            DropIndex("dbo.PagoCuotas", new[] { "PagoId" });
            DropTable("dbo.TipoPagoes");
            DropTable("dbo.FormaPagoes");
            DropTable("dbo.Pagoes");
            DropTable("dbo.PagoCuotas");
        }
    }
}
