namespace FantasyEuroleague.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AllModelSoFar : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Games",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        HomeTeamID = c.Int(nullable: false),
                        GuestTeamID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Teams", t => t.GuestTeamID)
                .ForeignKey("dbo.Teams", t => t.HomeTeamID)
                .Index(t => t.HomeTeamID)
                .Index(t => t.GuestTeamID);
            
            CreateTable(
                "dbo.Teams",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.PlayerStats",
                c => new
                    {
                        PlayerID = c.Int(nullable: false),
                        GameID = c.Int(nullable: false),
                        TwoPointMade = c.Int(nullable: false),
                        TwoPointAttempted = c.Int(nullable: false),
                        ThreePointMade = c.Int(nullable: false),
                        ThreePointAttempted = c.Int(nullable: false),
                        FreeThrowMade = c.Int(nullable: false),
                        FreeThrowAttempted = c.Int(nullable: false),
                        Assists = c.Int(nullable: false),
                        DefensiveRebounds = c.Int(nullable: false),
                        OffensiveRebounds = c.Int(nullable: false),
                        Steals = c.Int(nullable: false),
                        Turnovers = c.Int(nullable: false),
                        BlocksMade = c.Int(nullable: false),
                        BlocksReceived = c.Int(nullable: false),
                        FoulsMade = c.Int(nullable: false),
                        FoulsReceived = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.PlayerID, t.GameID })
                .ForeignKey("dbo.Games", t => t.GameID, cascadeDelete: true)
                .ForeignKey("dbo.Players", t => t.PlayerID, cascadeDelete: true)
                .Index(t => t.PlayerID)
                .Index(t => t.GameID);
            
            CreateTable(
                "dbo.TeamStats",
                c => new
                    {
                        TeamID = c.Int(nullable: false),
                        GameID = c.Int(nullable: false),
                        TwoPointMade = c.Int(nullable: false),
                        TwoPointAttempted = c.Int(nullable: false),
                        ThreePointMade = c.Int(nullable: false),
                        ThreePointAttempted = c.Int(nullable: false),
                        FreeThrowMade = c.Int(nullable: false),
                        FreeThrowAttempted = c.Int(nullable: false),
                        Assists = c.Int(nullable: false),
                        DefensiveRebounds = c.Int(nullable: false),
                        OffensiveRebounds = c.Int(nullable: false),
                        Steals = c.Int(nullable: false),
                        Turnovers = c.Int(nullable: false),
                        BlocksMade = c.Int(nullable: false),
                        BlocksReceived = c.Int(nullable: false),
                        FoulsMade = c.Int(nullable: false),
                        FoulsReceived = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.TeamID, t.GameID })
                .ForeignKey("dbo.Games", t => t.GameID, cascadeDelete: true)
                .ForeignKey("dbo.Teams", t => t.TeamID, cascadeDelete: true)
                .Index(t => t.TeamID)
                .Index(t => t.GameID);
            
            AddColumn("dbo.Players", "TeamID", c => c.Int(nullable: false));
            AddColumn("dbo.Profiles", "Position", c => c.Int(nullable: false));
            CreateIndex("dbo.Players", "TeamID");
            AddForeignKey("dbo.Players", "TeamID", "dbo.Teams", "ID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TeamStats", "TeamID", "dbo.Teams");
            DropForeignKey("dbo.TeamStats", "GameID", "dbo.Games");
            DropForeignKey("dbo.Games", "HomeTeamID", "dbo.Teams");
            DropForeignKey("dbo.Games", "GuestTeamID", "dbo.Teams");
            DropForeignKey("dbo.Players", "TeamID", "dbo.Teams");
            DropForeignKey("dbo.PlayerStats", "PlayerID", "dbo.Players");
            DropForeignKey("dbo.PlayerStats", "GameID", "dbo.Games");
            DropIndex("dbo.TeamStats", new[] { "GameID" });
            DropIndex("dbo.TeamStats", new[] { "TeamID" });
            DropIndex("dbo.PlayerStats", new[] { "GameID" });
            DropIndex("dbo.PlayerStats", new[] { "PlayerID" });
            DropIndex("dbo.Players", new[] { "TeamID" });
            DropIndex("dbo.Games", new[] { "GuestTeamID" });
            DropIndex("dbo.Games", new[] { "HomeTeamID" });
            DropColumn("dbo.Profiles", "Position");
            DropColumn("dbo.Players", "TeamID");
            DropTable("dbo.TeamStats");
            DropTable("dbo.PlayerStats");
            DropTable("dbo.Teams");
            DropTable("dbo.Games");
        }
    }
}
