namespace Datos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class feeTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Cuotas", "Valor", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.Prestamos", "Observacion", c => c.String(maxLength: 255));
            AlterColumn("dbo.Cuotas", "Observaciones", c => c.String(maxLength: 255));
            DropColumn("dbo.Cuotas", "Couta");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Cuotas", "Couta", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.Cuotas", "Observaciones", c => c.String());
            AlterColumn("dbo.Prestamos", "Observacion", c => c.String());
            DropColumn("dbo.Cuotas", "Valor");
        }
    }
}
