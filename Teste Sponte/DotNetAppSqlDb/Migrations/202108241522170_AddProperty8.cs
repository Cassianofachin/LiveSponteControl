namespace DotNetAppSqlDb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddProperty8 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Todoes", "Email_instrutor", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Todoes", "Email_instrutor");
        }
    }
}
