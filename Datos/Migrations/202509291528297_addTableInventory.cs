namespace Datos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addTableInventory : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categorias",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, maxLength: 50),
                        Descripcion = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Productos",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Codigo = c.String(nullable: false, maxLength: 50),
                        Nombre = c.String(nullable: false, maxLength: 50),
                        Costo = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Precio = c.Decimal(nullable: false, precision: 18, scale: 2),
                        CategoriaId = c.Int(nullable: false),
                        UnidadMedidaId = c.Int(nullable: false),
                        RutaImagen = c.String(maxLength: 255),
                        Descripcion = c.String(maxLength: 255),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Categorias", t => t.CategoriaId, cascadeDelete: true)
                .ForeignKey("dbo.UnidadMedidas", t => t.UnidadMedidaId, cascadeDelete: true)
                .Index(t => t.Codigo, unique: true)
                .Index(t => t.CategoriaId)
                .Index(t => t.UnidadMedidaId);
            
            CreateTable(
                "dbo.Existencias",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Fecha = c.DateTime(nullable: false, storeType: "date"),
                        Concepto = c.String(nullable: false),
                        Cantidad = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Entrada = c.Boolean(nullable: false),
                        ProductoId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Productos", t => t.ProductoId, cascadeDelete: true)
                .Index(t => t.ProductoId);
            
            CreateTable(
                "dbo.UnidadMedidas",
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
            DropForeignKey("dbo.Productos", "UnidadMedidaId", "dbo.UnidadMedidas");
            DropForeignKey("dbo.Existencias", "ProductoId", "dbo.Productos");
            DropForeignKey("dbo.Productos", "CategoriaId", "dbo.Categorias");
            DropIndex("dbo.Existencias", new[] { "ProductoId" });
            DropIndex("dbo.Productos", new[] { "UnidadMedidaId" });
            DropIndex("dbo.Productos", new[] { "CategoriaId" });
            DropIndex("dbo.Productos", new[] { "Codigo" });
            DropTable("dbo.UnidadMedidas");
            DropTable("dbo.Existencias");
            DropTable("dbo.Productos");
            DropTable("dbo.Categorias");
        }
    }
}
