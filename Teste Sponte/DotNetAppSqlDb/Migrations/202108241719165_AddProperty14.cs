namespace DotNetAppSqlDb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddProperty14 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Todoes", "Nascimento_espectador", c => c.DateTime(nullable: false));
            DropColumn("dbo.Todoes", "CreatedDate2");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Todoes", "CreatedDate2", c => c.DateTime(nullable: false));
            DropColumn("dbo.Todoes", "Nascimento_espectador");
        }
    }
}
