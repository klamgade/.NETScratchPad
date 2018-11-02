namespace DotNetCrud.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class added_membershiptype_model : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MembershipTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SignupFee = c.Double(nullable: false),
                        DurationInMonths = c.Int(nullable: false),
                        DiscountRate = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.MembershipTypes");
        }
    }
}
