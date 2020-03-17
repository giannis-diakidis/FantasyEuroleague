namespace FantasyEuroleague.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
                INSERT [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'd4e8af4a-8e71-4e3e-88c5-a698fdbfd252', N'AppManager')
                INSERT [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'06a77acc-df36-44ee-8909-fd675a7964bd', N'appManager@gmail.com', 0, N'AJ4F5MWee8g3dZ9cdQVH/38M9CZCkMQPNi6ayWQ6ns4y7punp+ZwJ0wc26Blo60fBA==', N'c91cb02c-d61a-4208-97b2-5f6d8faa516f', NULL, 0, 0, NULL, 1, 0, N'appManager@gmail.com')
                INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'06a77acc-df36-44ee-8909-fd675a7964bd', N'd4e8af4a-8e71-4e3e-88c5-a698fdbfd252')
                ");
        }
        
        public override void Down()
        {
        }
    }
}
