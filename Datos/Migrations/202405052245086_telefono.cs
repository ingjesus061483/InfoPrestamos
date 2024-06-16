namespace Datos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class telefono : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Telefonoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NumeroTelefonico = c.String(nullable: false, maxLength: 10),
                        ClienteId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Clientes", t => t.ClienteId, cascadeDelete: true)
                .Index(t => t.ClienteId);
            
            AddColumn("dbo.Clientes", "FechaExpedicion", c => c.DateTime(nullable: false));
            DropColumn("dbo.Clientes", "Telefono");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Clientes", "Telefono", c => c.String(nullable: false, maxLength: 50));
            DropForeignKey("dbo.Telefonoes", "ClienteId", "dbo.Clientes");
            DropIndex("dbo.Telefonoes", new[] { "ClienteId" });
            DropColumn("dbo.Clientes", "FechaExpedicion");
            DropTable("dbo.Telefonoes");
        }
    }
}
