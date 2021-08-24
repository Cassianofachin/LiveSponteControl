namespace DotNetAppSqlDb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddProperty15 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Todoes", "Nasc_espectador", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Todoes", "Nasc_espectador");
        }
    }
}
