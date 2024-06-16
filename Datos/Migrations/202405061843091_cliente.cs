namespace Datos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class cliente : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Clientes", "Observacion", c => c.String(maxLength: 255));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Clientes", "Observacion");
        }
    }
}
