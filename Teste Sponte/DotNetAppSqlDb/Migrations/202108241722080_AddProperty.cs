namespace DotNetAppSqlDb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddProperty : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Todoes", "Nascimento_espectador");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Todoes", "Nascimento_espectador", c => c.DateTime(nullable: false));
        }
    }
}
