namespace Datos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EstadoPrestamos : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Estados",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, maxLength: 50),
                        Descripcion = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Prestamos", "EstadoId", c => c.Int(nullable: false));
            CreateIndex("dbo.Prestamos", "EstadoId");
            AddForeignKey("dbo.Prestamos", "EstadoId", "dbo.Estados", "Id", cascadeDelete: true);
            DropColumn("dbo.Prestamos", "EsCancelado");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Prestamos", "EsCancelado", c => c.Boolean(nullable: false));
            DropForeignKey("dbo.Prestamos", "EstadoId", "dbo.Estados");
            DropIndex("dbo.Prestamos", new[] { "EstadoId" });
            DropColumn("dbo.Prestamos", "EstadoId");
            DropTable("dbo.Estados");
        }
    }
}
