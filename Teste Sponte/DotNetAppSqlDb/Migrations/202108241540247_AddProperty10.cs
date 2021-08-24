namespace DotNetAppSqlDb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddProperty10 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Todoes", "Nome_instrutor", c => c.String());
            DropColumn("dbo.Todoes", "NomeInstrutor");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Todoes", "NomeInstrutor", c => c.String());
            DropColumn("dbo.Todoes", "Nome_instrutor");
        }
    }
}
