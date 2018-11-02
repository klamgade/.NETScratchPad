namespace DotNetCrud.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class added_isactive_itemmodel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Items", "IsActive", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Items", "IsActive");
        }
    }
}
