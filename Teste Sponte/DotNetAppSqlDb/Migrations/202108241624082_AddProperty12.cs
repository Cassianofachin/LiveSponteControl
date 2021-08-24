namespace DotNetAppSqlDb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddProperty12 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Todoes", "CreatedDate_espectador");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Todoes", "CreatedDate_espectador", c => c.DateTime(nullable: false));
        }
    }
}
