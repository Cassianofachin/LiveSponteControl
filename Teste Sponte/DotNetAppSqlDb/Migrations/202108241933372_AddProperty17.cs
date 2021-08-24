namespace DotNetAppSqlDb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddProperty17 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Todoes", "Nome_live", c => c.String());
            AddColumn("dbo.Todoes", "Desc_live", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Todoes", "Desc_live");
            DropColumn("dbo.Todoes", "Nome_live");
        }
    }
}
