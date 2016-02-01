namespace Remindz.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RequiredAttributes : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Rdates", "Name", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Rdates", "Name", c => c.String());
        }
    }
}
