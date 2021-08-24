namespace DotNetAppSqlDb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddProperty5 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Todoes", "Email_instrutor", c => c.String());
            DropColumn("dbo.Todoes", "Nome_instrutor");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Todoes", "Nome_instrutor", c => c.String());
            DropColumn("dbo.Todoes", "Email_instrutor");
        }
    }
}
