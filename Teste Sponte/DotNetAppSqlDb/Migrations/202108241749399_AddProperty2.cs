namespace DotNetAppSqlDb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddProperty2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Todoes", "End_instagram", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Todoes", "End_instagram");
        }
    }
}
