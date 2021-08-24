namespace DotNetAppSqlDb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddProperty19 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Todoes", "Pago", c => c.Boolean(nullable: false));
            DropColumn("dbo.Todoes", "Done");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Todoes", "Done", c => c.Boolean(nullable: false));
            DropColumn("dbo.Todoes", "Pago");
        }
    }
}
