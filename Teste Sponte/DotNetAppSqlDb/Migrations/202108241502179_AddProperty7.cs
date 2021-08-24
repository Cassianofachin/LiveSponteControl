namespace DotNetAppSqlDb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddProperty7 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Todoes", "Description", c => c.String());
            AddColumn("dbo.Todoes", "Nome_instrutor", c => c.String());
            AddColumn("dbo.Todoes", "CreatedDate", c => c.DateTime(nullable: false));
            DropColumn("dbo.Todoes", "Nome");
            DropColumn("dbo.Todoes", "Email_instrutor");
            DropColumn("dbo.Todoes", "Data_de_Nascimento");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Todoes", "Data_de_Nascimento", c => c.DateTime(nullable: false));
            AddColumn("dbo.Todoes", "Email_instrutor", c => c.String());
            AddColumn("dbo.Todoes", "Nome", c => c.String());
            DropColumn("dbo.Todoes", "CreatedDate");
            DropColumn("dbo.Todoes", "Nome_instrutor");
            DropColumn("dbo.Todoes", "Description");
        }
    }
}
