namespace DotNetAppSqlDb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddProperty11 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Todoes", "Nome_espectador", c => c.String());
            AddColumn("dbo.Todoes", "CreatedDate_espectador", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Todoes", "CreatedDate_espectador");
            DropColumn("dbo.Todoes", "Nome_espectador");
        }
    }
}
