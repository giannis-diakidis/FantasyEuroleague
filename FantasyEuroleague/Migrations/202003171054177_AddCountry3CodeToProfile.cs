namespace FantasyEuroleague.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCountry3CodeToProfile : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Profiles", "Country3Code", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Profiles", "Country3Code");
        }
    }
}
