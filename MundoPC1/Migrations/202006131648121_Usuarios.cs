namespace MundoPC1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Usuarios : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "Nombre", c => c.String());
            AddColumn("dbo.AspNetUsers", "Apellidos", c => c.String());
            AddColumn("dbo.AspNetUsers", "Direccion", c => c.String());
            AddColumn("dbo.AspNetUsers", "Colonia", c => c.String());
            AddColumn("dbo.AspNetUsers", "Region", c => c.String());
            AddColumn("dbo.AspNetUsers", "CP", c => c.String());
            AddColumn("dbo.AspNetUsers", "Telefono", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "Telefono");
            DropColumn("dbo.AspNetUsers", "CP");
            DropColumn("dbo.AspNetUsers", "Region");
            DropColumn("dbo.AspNetUsers", "Colonia");
            DropColumn("dbo.AspNetUsers", "Direccion");
            DropColumn("dbo.AspNetUsers", "Apellidos");
            DropColumn("dbo.AspNetUsers", "Nombre");
        }
    }
}
