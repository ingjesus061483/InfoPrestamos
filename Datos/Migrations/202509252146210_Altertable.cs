  namespace Datos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Altertable : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Prestamos", new[] { "Codigo" });
            AddColumn("dbo.Prestamos", "Referencia", c => c.String(nullable: false, maxLength: 50));
            CreateIndex("dbo.Prestamos", "Referencia", unique: true);
            DropColumn("dbo.Prestamos", "Codigo");
            DropColumn("dbo.Clientes", "Observacion");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Clientes", "Observacion", c => c.String(maxLength: 255));
            AddColumn("dbo.Prestamos", "Codigo", c => c.String(nullable: false, maxLength: 50));
            DropIndex("dbo.Prestamos", new[] { "Referencia" });
            DropColumn("dbo.Prestamos", "Referencia");
            CreateIndex("dbo.Prestamos", "Codigo", unique: true);
        }
    }
}
