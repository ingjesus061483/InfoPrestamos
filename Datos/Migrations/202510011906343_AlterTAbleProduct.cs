namespace Datos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AlterTAbleProduct : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Productos", "Referencia", c => c.String(nullable: false, maxLength: 50));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Productos", "Referencia");
        }
    }
}
