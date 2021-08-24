namespace DotNetAppSqlDb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddProperty13 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Todoes", "CreatedDate2", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Todoes", "CreatedDate2");
        }
    }
}
