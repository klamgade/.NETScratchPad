namespace DotNetCrud.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class seeding_membershiptype_table : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO MembershipTypes ( SignupFee, DurationInMonths, DiscountRate) VALUES (600.0, 3, 25);");
            Sql("INSERT INTO MembershipTypes ( SignupFee, DurationInMonths, DiscountRate) VALUES (300.0, 6, 35);");
            Sql("INSERT INTO MembershipTypes ( SignupFee, DurationInMonths, DiscountRate) VALUES (200.0, 8, 15);");
        }
        
        public override void Down()
        {

        }
    }
}
