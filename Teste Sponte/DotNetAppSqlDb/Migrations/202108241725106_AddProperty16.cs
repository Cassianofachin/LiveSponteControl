namespace DotNetAppSqlDb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddProperty16 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Todoes", "Nasc_espectador");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Todoes", "Nasc_espectador", c => c.DateTime(nullable: false));
        }
    }
}
