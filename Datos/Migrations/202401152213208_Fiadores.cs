namespace Datos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Fiadores : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Fiadors", "EmperesaDondeLabora", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Fiadors", "EmperesaDondeLabora");
        }
    }
}
