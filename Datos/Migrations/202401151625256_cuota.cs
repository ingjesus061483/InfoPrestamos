namespace Datos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class cuota : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Cuotas", "Couta", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.Cuotas", "Saldo", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Cuotas", "Saldo");
            DropColumn("dbo.Cuotas", "Couta");
        }
    }
}
