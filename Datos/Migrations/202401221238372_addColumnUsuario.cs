namespace Datos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addColumnUsuario : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Usuarios", "Sesion", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Usuarios", "Sesion");
        }
    }
}
