namespace DotNetAppSqlDb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddProperty18 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Todoes", "Instrutor_live", c => c.String());
            AddColumn("dbo.Todoes", "Tempo_live", c => c.Int(nullable: false));
            AddColumn("dbo.Todoes", "Valor_live", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Todoes", "Valor_live");
            DropColumn("dbo.Todoes", "Tempo_live");
            DropColumn("dbo.Todoes", "Instrutor_live");
        }
    }
}
