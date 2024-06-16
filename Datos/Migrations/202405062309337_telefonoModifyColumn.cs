namespace Datos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class telefonoModifyColumn : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Telefonoes", "NumeroTelefonico", c => c.String(nullable: false, maxLength: 20));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Telefonoes", "NumeroTelefonico", c => c.String(nullable: false, maxLength: 10));
        }
    }
}
