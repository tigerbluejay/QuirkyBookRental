namespace QuirkyBookRental.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MembershipTypeMappingtoDB : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.MembershipTypes", "ChargeRateOneMonth", c => c.Byte(nullable: false));
            AddColumn("dbo.MembershipTypes", "ChargeRateSixMonth", c => c.Byte(nullable: false));
            DropColumn("dbo.MembershipTypes", "ChargeRateOneMonth1");
            DropColumn("dbo.MembershipTypes", "ChargeRateSixMonths");
        }
        
        public override void Down()
        {
            AddColumn("dbo.MembershipTypes", "ChargeRateSixMonths", c => c.Byte(nullable: false));
            AddColumn("dbo.MembershipTypes", "ChargeRateOneMonth1", c => c.Byte(nullable: false));
            DropColumn("dbo.MembershipTypes", "ChargeRateSixMonth");
            DropColumn("dbo.MembershipTypes", "ChargeRateOneMonth");
        }
    }
}
