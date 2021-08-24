namespace DotNetAppSqlDb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddProperty9 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Todoes", "Email_instrutor", c => c.String());
            DropColumn("dbo.Todoes", "Email");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Todoes", "Email", c => c.String());
            DropColumn("dbo.Todoes", "Email_instrutor");
        }
    }
}
