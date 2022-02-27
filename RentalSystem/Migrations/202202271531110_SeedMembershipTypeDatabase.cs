namespace RentalSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedMembershipTypeDatabase : DbMigration
    {
        public override void Up()
        {
            // How to add data with SQL commands
            Sql("INSERT INTO [dbo].[MembershipTypes](Name,SignUpFee, ChargeRateOneMonth, ChargeRateSixMonth) VALUES('Pay Per Rental',0,25,50)");
            Sql("INSERT INTO [dbo].[MembershipTypes](Name,SignUpFee, ChargeRateOneMonth, ChargeRateSixMonth) VALUES('Member',150,10,20)");
            Sql("INSERT INTO [dbo].[MembershipTypes](Name,SignUpFee, ChargeRateOneMonth, ChargeRateSixMonth) VALUES('SuperAdmin',0,0,0)");
        }
        
        public override void Down()
        {
        }
    }
}
