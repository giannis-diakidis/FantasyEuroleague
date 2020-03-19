namespace FantasyEuroleague.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateTeams : DbMigration
    {
        public override void Up()
        {
            Sql("Insert INTO Teams (Name) VALUES ('ALBA Berlin')");
            Sql("Insert INTO Teams (Name) VALUES ('Anadolu Efes Istanbul')");
            Sql("Insert INTO Teams (Name) VALUES ('AX Armani Exchange Milan')");
            Sql("Insert INTO Teams (Name) VALUES ('Crvena Zvezda mts Belgrade')");
            Sql("Insert INTO Teams (Name) VALUES ('CSKA Moscow')");
            Sql("Insert INTO Teams (Name) VALUES ('FC Barcelona')");
            Sql("Insert INTO Teams (Name) VALUES ('FC Bayern Munich')");
            Sql("Insert INTO Teams (Name) VALUES ('Fenerbahce Beko Istanbul')");
            Sql("Insert INTO Teams (Name) VALUES ('Khimki Moscow Region')");
            Sql("Insert INTO Teams (Name) VALUES ('KIROLBET Baskonia Vitoria-Gasteiz')");
            Sql("Insert INTO Teams (Name) VALUES ('LDLC ASVEL Villeurbanne')");
            Sql("Insert INTO Teams (Name) VALUES ('Maccabi FOX Tel Aviv')");
            Sql("Insert INTO Teams (Name) VALUES ('Olympiacos Piraeus')");
            Sql("Insert INTO Teams (Name) VALUES ('Panathinaikos OPAP Athens')");
            Sql("Insert INTO Teams (Name) VALUES ('Real Madrid')");
            Sql("Insert INTO Teams (Name) VALUES ('Valencia Basket')");
            Sql("Insert INTO Teams (Name) VALUES ('Zalgiris Kaunas')");
            Sql("Insert INTO Teams (Name) VALUES ('Zenit St Petersburg')");
        }
        
        public override void Down()
        {
            Sql("DELETE FROM Teams WHERE ID IN (1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18)");
        }
    }
}
