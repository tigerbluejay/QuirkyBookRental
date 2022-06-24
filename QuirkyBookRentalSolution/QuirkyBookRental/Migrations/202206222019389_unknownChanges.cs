﻿namespace QuirkyBookRental.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class unknownChanges : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.AspNetUsers", "Disable", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.AspNetUsers", "Disable", c => c.Boolean(nullable: false));
        }
    }
}
