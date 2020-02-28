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
                INSERT [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'51b629da-99c7-4034-be50-18651435c46c', N'player1@gmail.com', 0, N'AOgcEYm0ti55bGmE3I1aoWP5JPMSuXIMb6oq7dJMmCn1j/g58PWutUW3zBYJaS67jg==', N'da56e4e8-50fc-4258-b9a0-333dca7a2352', NULL, 0, 0, NULL, 1, 0, N'player1@gmail.com')
                INSERT [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'f074ff01-1e27-4a6e-832c-2aabb1c7b842', N'player2@gmail.com', 0, N'ALmIInIflgu1LBjqF60v6Ejg47I5sehmsacueLoUZNtO/WJrdewIZUWJXOAhPy42bA==', N'c3b1b2b7-87ff-4f95-8fd5-c77f04a3193b', NULL, 0, 0, NULL, 1, 0, N'player2@gmail.com')
                ");
        }
        
        public override void Down()
        {
        }
    }
}
