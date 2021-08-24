namespace DotNetAppSqlDb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddProperty3 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Todoes", "End_instagram");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Todoes", "End_instagram", c => c.String());
        }
    }
}
