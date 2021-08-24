﻿namespace DotNetAppSqlDb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddProperty1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Todoes", "Email_espectador", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Todoes", "Email_espectador");
        }
    }
}
