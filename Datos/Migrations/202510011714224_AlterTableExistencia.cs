namespace Datos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AlterTableExistencia : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Existencias", "Concepto", c => c.String(nullable: false, maxLength: 100));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Existencias", "Concepto", c => c.String(nullable: false));
        }
    }
}
