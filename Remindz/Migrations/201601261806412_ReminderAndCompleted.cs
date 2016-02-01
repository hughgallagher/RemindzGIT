namespace Remindz.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ReminderAndCompleted : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Rdates", "EventDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Rdates", "ReminderDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Rdates", "Completed", c => c.Boolean(nullable: false));
            DropColumn("dbo.Rdates", "date");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Rdates", "date", c => c.DateTime(nullable: false));
            DropColumn("dbo.Rdates", "Completed");
            DropColumn("dbo.Rdates", "ReminderDate");
            DropColumn("dbo.Rdates", "EventDate");
        }
    }
}
