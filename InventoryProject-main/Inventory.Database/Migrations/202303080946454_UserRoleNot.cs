namespace Inventory.Database.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UserRoleNot : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Users", "UserRole", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Users", "UserRole", c => c.String(nullable: false));
        }
    }
}
