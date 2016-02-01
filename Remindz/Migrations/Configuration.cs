namespace Remindz.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

     using Remindz.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<Remindz.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Remindz.Models.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            context.Rdates.AddOrUpdate(
              p => p.Name,
              new Rdate { Name = "Car Insurance", EventDate = new DateTime(2016,12,04), ReminderDate = new DateTime(2016, 12, 01) },
              new Rdate { Name = "Life Time Wealth Subscription", EventDate = new DateTime(2016, 06, 04), ReminderDate = new DateTime(2016, 06, 01) }
            );

        }
    }
}
