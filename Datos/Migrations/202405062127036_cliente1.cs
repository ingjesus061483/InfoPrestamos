namespace Datos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class cliente1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TipoTelefonoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, maxLength: 50),
                        Descripcion = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Telefonoes", "TipoTelefonoId", c => c.Int(nullable: false));
            CreateIndex("dbo.Telefonoes", "TipoTelefonoId");
            AddForeignKey("dbo.Telefonoes", "TipoTelefonoId", "dbo.TipoTelefonoes", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Telefonoes", "TipoTelefonoId", "dbo.TipoTelefonoes");
            DropIndex("dbo.Telefonoes", new[] { "TipoTelefonoId" });
            DropColumn("dbo.Telefonoes", "TipoTelefonoId");
            DropTable("dbo.TipoTelefonoes");
        }
    }
}
