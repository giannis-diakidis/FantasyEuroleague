namespace FantasyEuroleague.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using FantasyEuroleague.Models;
    using FantasyEuroleague.Enumerations;

    internal sealed class Configuration : DbMigrationsConfiguration<FantasyEuroleague.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(FantasyEuroleague.Models.ApplicationDbContext context)
        {

            var panathinaikosID = context.Teams.Single(t => t.Name == "Panathinaikos OPAP Athens").ID;
            var crvenaID = context.Teams.Single(t => t.Name == "Crvena Zvezda mts Belgrade").ID;
            var villeurbanneID = context.Teams.Single(t => t.Name == "LDLC ASVEL Villeurbanne").ID;

            var games = new List<Game>
            {
                new Game
                {
                    HomeTeamID = panathinaikosID,
                    GuestTeamID = crvenaID
                },
                new Game
                {
                    HomeTeamID = villeurbanneID,
                    GuestTeamID = panathinaikosID
                }
            };
            games.ForEach(g => context.Games.AddOrUpdate(p => new { p.HomeTeamID, p.GuestTeamID } , g));
            context.SaveChanges();

            var players = new List<Player>
            {
                // Panathinaikos Players
                new Player{
                    Firstname = "Deshaun", Lastname = "Thomas",
                    TeamID = panathinaikosID},
                new Player{
                    Firstname = "Tyrese", Lastname = "Rice",
                    TeamID = panathinaikosID},
                new Player{
                    Firstname = "Georgios", Lastname = "Papagiannis",
                    TeamID = panathinaikosID},
                new Player{
                    Firstname = "Andy", Lastname = "Rautins",
                    TeamID = panathinaikosID},
                new Player{
                    Firstname = "Ioannis", Lastname = "Papapetrou",
                    TeamID = panathinaikosID},
                new Player{
                    Firstname = "Nikos", Lastname = "Pappas",
                    TeamID = panathinaikosID},
                new Player{
                    Firstname = "Ian", Lastname = "Vougioukas",
                    TeamID = panathinaikosID},
                new Player{
                    Firstname = "Konstantinos", Lastname = "Papadakis",
                    TeamID = panathinaikosID},
                new Player{
                    Firstname = "Wesley", Lastname = "Johnson",
                    TeamID = panathinaikosID},
                new Player{
                    Firstname = "Jimmer", Lastname = "Fredette",
                    TeamID = panathinaikosID},
                new Player{
                    Firstname = "Nick", Lastname = "Calathes",
                    TeamID = panathinaikosID},
                new Player{
                    Firstname = "Jacob", Lastname = "Wiley",
                    TeamID = panathinaikosID},
                new Player{
                    Firstname = "Konstantinos", Lastname = "Mitoglou",
                    TeamID = panathinaikosID},
                new Player{
                    Firstname = "Benjamin", Lastname = "Bentil",
                    TeamID = panathinaikosID},

                // Former team Player (Brown)
                new Player{
                    Firstname = "Rion", Lastname = "Brown",
                    TeamID = panathinaikosID},
                // Former team Player (Brown)

                //Crvena Zvezda Players
                new Player{
                    Firstname = "Ognjen", Lastname = "Kuzmic",
                    TeamID = crvenaID},
                new Player{
                    Firstname = "Kevin", Lastname = "Punter",
                    TeamID = crvenaID},
                new Player{
                    Firstname = "Filip", Lastname = "Covic",
                    TeamID = crvenaID},
                new Player{
                    Firstname = "Lorenzo", Lastname = "Brown",
                    TeamID = crvenaID},
                new Player{
                    Firstname = "Stratos", Lastname = "Perperoglou",
                    TeamID = crvenaID},
                new Player{
                    Firstname = "Dejan", Lastname = "Davidovac",
                    TeamID = crvenaID},
                new Player{
                    Firstname = "Branko", Lastname = "Lazic",
                    TeamID = crvenaID},
                new Player{
                    Firstname = "Billy", Lastname = "Baron",
                    TeamID = crvenaID},
                new Player{
                    Firstname = "Ognjen", Lastname = "Dobric",
                    TeamID = crvenaID},
                new Player{
                    Firstname = "James", Lastname = "Gist",
                    TeamID = crvenaID},
                new Player{
                    Firstname = "Marko", Lastname = "Jagodic-Kuridza",
                    TeamID = crvenaID},
                new Player{
                    Firstname = "Charles", Lastname = "Jenkins",
                    TeamID = crvenaID},
                new Player{
                    Firstname = "Borisa", Lastname = "Simanic",
                    TeamID = crvenaID},
                new Player{
                    Firstname = "Nikola", Lastname = "Jovanovic",
                    TeamID = crvenaID},
                new Player{
                    Firstname = "Michael", Lastname = "Ojo",
                    TeamID = crvenaID},
                new Player{
                    Firstname = "Vladimir", Lastname = "Stimac",
                    TeamID = crvenaID},
                // Former team Players (Faye & Brown)
                new Player{
                    Firstname = "Mouhammad", Lastname = "Faye",
                    TeamID = crvenaID},
                new Player{
                    Firstname = "Derrick", Lastname = "Brown",
                    TeamID = crvenaID},
                // Former team Players (Faye & Brown)

                // LDLC ASVEL Villeurbanne Players
                new Player{
                     Firstname = "Jordan", Lastname = "Taylor",
                     TeamID = villeurbanneID},
                new Player{
                    Firstname = "Tonye", Lastname = "Jekiri",
                    TeamID = villeurbanneID},
                new Player{
                    Firstname = "Charles", Lastname = "Kahudi",
                    TeamID = villeurbanneID},
                new Player{
                    Firstname = "Theo", Lastname = "Maledon",
                    TeamID = villeurbanneID},
                new Player{
                    Firstname = "Davion", Lastname = "Berry",
                    TeamID = villeurbanneID},
                new Player{
                    Firstname = "Rihards", Lastname = "Lomazs",
                    TeamID = villeurbanneID},
                new Player{
                    Firstname = "Charles", Lastname = "Galliou",
                    TeamID = villeurbanneID},
                new Player{
                    Firstname = "Amine", Lastname = "Noua",
                    TeamID = villeurbanneID},
                new Player{
                    Firstname = "Livio", Lastname = "Jean-Charles",
                    TeamID = villeurbanneID},
                new Player{
                    Firstname = "Antoine", Lastname = "Diot",
                    TeamID = villeurbanneID},
                new Player{
                    Firstname = "Ismael", Lastname = "Bako",
                    TeamID = villeurbanneID},
                new Player{
                    Firstname = "David", Lastname = "Lighty",
                    TeamID = villeurbanneID},
                new Player{
                    Firstname = "Guerschon", Lastname = "Yabusele",
                    TeamID = villeurbanneID},
                new Player{
                    Firstname = "Matthew", Lastname = "Strazel",
                    TeamID = villeurbanneID},
                new Player{
                    Firstname = "Adreian", Lastname = "Payne",
                    TeamID = villeurbanneID},
                new Player{
                    Firstname = "Edwin", Lastname = "Jackson",
                    TeamID = villeurbanneID}
            };
            players.ForEach(pl => context.Players.AddOrUpdate(p => new {p.Firstname, p.Lastname }, pl));
            context.SaveChanges();

            var profiles = new List<Profile>
            { 
                // Panathinaikos Players Profiles
                new Profile{
                     PlayerID= players.Single(p => p.Firstname == "Deshaun" && p.Lastname == "Thomas").ID,
                     Country3Code = "USA",
                     Country = "United States of America",
                     Position = Position.Forward
                     },
                new Profile{
                    PlayerID= players.Single(p => p.Firstname == "Tyrese" && p.Lastname == "Rice").ID,
                    Country3Code = "USA",
                    Country = "United States of America",
                    Position = Position.Guard
                    },
                new Profile{
                    PlayerID= players.Single(p => p.Firstname == "Georgios" && p.Lastname == "Papagiannis").ID,
                    Country3Code = "GRE",
                    Country = "Greece",
                    Position = Position.Center
                    },
                new Profile{
                    PlayerID= players.Single(p => p.Firstname == "Andy" && p.Lastname == "Rautins").ID,
                    Country3Code = "CAN",
                    Country = "Canada",
                    Position = Position.Guard
                    },
                new Profile{
                    PlayerID= players.Single(p => p.Firstname == "Ioannis" && p.Lastname == "Papapetrou").ID,
                    Country3Code = "GRE",
                    Country = "Greece",
                    Position = Position.Forward
                    },
                new Profile{
                    PlayerID= players.Single(p => p.Firstname == "Nikos" && p.Lastname == "Pappas").ID,
                    Country3Code = "GRE",
                    Country = "Greece",
                    Position = Position.Guard
                    },
                new Profile{
                    PlayerID= players.Single(p => p.Firstname == "Ian" && p.Lastname == "Vougioukas").ID,
                    Country3Code = "GRE",
                    Country = "Greece",
                    Position = Position.Center
                    },
                new Profile{
                    PlayerID= players.Single(p => p.Firstname == "Konstantinos" && p.Lastname == "Papadakis").ID,
                    Country3Code = "GRE",
                    Country = "Greece",
                    Position = Position.Guard
                    },
                new Profile{
                    PlayerID= players.Single(p => p.Firstname == "Wesley" && p.Lastname == "Johnson").ID,
                    Country3Code = "USA",
                    Country = "United States of America",
                    Position = Position.Forward
                    },
                new Profile{
                    PlayerID= players.Single(p => p.Firstname == "Jimmer" && p.Lastname == "Fredette").ID,
                    Country3Code = "USA",
                    Country = "United States of America",
                    Position = Position.Guard
                    },
                new Profile{
                    PlayerID= players.Single(p => p.Firstname == "Nick" && p.Lastname == "Calathes").ID,
                    Country3Code = "GRE",
                    Country = "Greece",
                    Position = Position.Guard
                    },
                new Profile{
                    PlayerID= players.Single(p => p.Firstname == "Jacob" && p.Lastname == "Wiley").ID,
                    Country3Code = "USA",
                    Country = "United States of America",
                    Position = Position.Forward
                    },
                new Profile{
                    PlayerID= players.Single(p => p.Firstname == "Konstantinos" && p.Lastname == "Mitoglou").ID,
                    Country3Code = "GRE",
                    Country = "Greece",
                    Position = Position.Forward
                    },
                new Profile{
                    PlayerID= players.Single(p => p.Firstname == "Benjamin" && p.Lastname == "Bentil").ID,
                    Country3Code = "GHA",
                    Country = "Ghana",
                    Position = Position.Forward
                    },
                new Profile{
                    PlayerID = players.Single(p => p.Firstname == "Rion" && p.Lastname == "Brown").ID,
                    Country3Code = "USA",
                    Country = "United States of America",
                    Position = Position.Forward
                    },

                //Crvena Zvezda Players Profiles
                new Profile{
                     PlayerID= players.Single(p => p.Firstname == "Ognjen" && p.Lastname == "Kuzmic").ID,
                     Country3Code = "SRB",
                     Country = "Serbia",
                     Position = Position.Center
                     },
                new Profile{
                    PlayerID= players.Single(p => p.Firstname == "Kevin" && p.Lastname == "Punter").ID,
                    Country3Code = "USA",
                    Country = "United States of America",
                    Position = Position.Guard
                    },
                new Profile{
                    PlayerID= players.Single(p => p.Firstname == "Filip" && p.Lastname == "Covic").ID,
                    Country3Code = "SRB",
                    Country = "Serbia",
                    Position = Position.Guard
                    },
                new Profile{
                    PlayerID= players.Single(p => p.Firstname == "Lorenzo" && p.Lastname == "Brown").ID,
                    Country3Code = "USA",
                    Country = "United States of America",
                    Position = Position.Guard
                    },
                new Profile{
                    PlayerID= players.Single(p => p.Firstname == "Stratos" && p.Lastname == "Perperoglou").ID,
                    Country3Code = "GRE",
                    Country = "Greece",
                    Position = Position.Forward
                    },
                new Profile{
                    PlayerID= players.Single(p => p.Firstname == "Dejan" && p.Lastname == "Davidovac").ID,
                    Country3Code = "SRB",
                    Country = "Serbia",
                    Position = Position.Forward
                    },
                new Profile{
                    PlayerID= players.Single(p => p.Firstname == "Branko" && p.Lastname == "Lazic").ID,
                    Country3Code = "SRB",
                    Country = "Serbia",
                    Position = Position.Guard
                    },
                new Profile{
                    PlayerID= players.Single(p => p.Firstname == "Billy" && p.Lastname == "Baron").ID,
                    Country3Code = "USA",
                    Country = "United States of America",
                    Position = Position.Guard
                    },
                new Profile{
                    PlayerID= players.Single(p => p.Firstname == "Ognjen" && p.Lastname == "Dobric").ID,
                    Country3Code = "SRB",
                    Country = "Serbia",
                    Position = Position.Guard
                    },
                new Profile{
                    PlayerID= players.Single(p => p.Firstname == "James" && p.Lastname == "Gist").ID,
                    Country3Code = "USA",
                    Country = "United States of America",
                    Position = Position.Forward
                    },
                new Profile{
                    PlayerID= players.Single(p => p.Firstname == "Marko" && p.Lastname == "Jagodic-Kuridza").ID,
                    Country3Code = "SRB",
                    Country = "Serbia",
                    Position = Position.Forward
                    },
                new Profile{
                    PlayerID= players.Single(p => p.Firstname == "Charles" && p.Lastname == "Jenkins").ID,
                    Country3Code = "SRB",
                    Country = "Serbia",
                    Position = Position.Guard
                    },
                new Profile{
                    PlayerID= players.Single(p => p.Firstname == "Borisa" && p.Lastname == "Simanic").ID,
                    Country3Code = "SRB",
                    Country = "Serbia",
                    Position = Position.Forward
                    },
                new Profile{
                    PlayerID= players.Single(p => p.Firstname == "Nikola" && p.Lastname == "Jovanovic").ID,
                    Country3Code = "SRB",
                    Country = "Serbia",
                    Position = Position.Center
                    },
                new Profile{
                    PlayerID = players.Single(p => p.Firstname == "Michael" && p.Lastname == "Ojo").ID,
                    Country3Code = "NGR",
                    Country = "Nigeria",
                    Position = Position.Center
                    },
                new Profile{
                    PlayerID = players.Single(p => p.Firstname == "Vladimir" && p.Lastname == "Stimac").ID,
                    Country3Code = "SRB",
                    Country = "Serbia",
                    Position = Position.Center
                    },
                new Profile{
                    PlayerID = players.Single(p => p.Firstname == "Mouhammad" && p.Lastname == "Faye").ID,
                    Country3Code = "SEN",
                    Country = "Senegal",
                    Position = Position.Forward
                    },
                new Profile{
                    PlayerID = players.Single(p => p.Firstname == "Derrick" && p.Lastname == "Brown").ID,
                    Country3Code = "USA",
                    Country = "United States of America",
                    Position = Position.Forward
                },

                // LDLC ASVEL Villeurbanne
                new Profile{
                     PlayerID= players.Single(p => p.Firstname == "Jordan" && p.Lastname == "Taylor").ID,
                     Country3Code = "USA",
                     Country = "United States of America",
                     Position = Position.Guard
                     },
                new Profile{
                    PlayerID= players.Single(p => p.Firstname == "Tonye" && p.Lastname == "Jekiri").ID,
                    Country3Code = "NGR",
                    Country = "Nigeria",
                    Position = Position.Center
                    },
                new Profile{
                    PlayerID= players.Single(p => p.Firstname == "Charles" && p.Lastname == "Kahudi").ID,
                    Country3Code = "FRA",
                    Country = "France",
                    Position = Position.Forward
                    },
                new Profile{
                    PlayerID= players.Single(p => p.Firstname == "Theo" && p.Lastname == "Maledon").ID,
                    Country3Code = "FRA",
                    Country = "France",
                    Position = Position.Guard
                    },
                new Profile{
                    PlayerID= players.Single(p => p.Firstname == "Davion" && p.Lastname == "Berry").ID,
                    Country3Code = "USA",
                    Country = "United States of America",
                    Position = Position.Guard
                    },
                new Profile{
                    PlayerID= players.Single(p => p.Firstname == "Rihards" && p.Lastname == "Lomazs").ID,
                    Country3Code = "LAT",
                    Country = "Latvia",
                    Position = Position.Forward
                    },
                new Profile{
                    PlayerID= players.Single(p => p.Firstname == "Charles" && p.Lastname == "Galliou").ID,
                    Country3Code = "FRA",
                    Country = "France",
                    Position = Position.Forward
                    },
                new Profile{
                    PlayerID= players.Single(p => p.Firstname == "Amine" && p.Lastname == "Noua").ID,
                    Country3Code = "FRA",
                    Country = "France",
                    Position = Position.Center
                    },
                new Profile{
                    PlayerID= players.Single(p => p.Firstname == "Livio" && p.Lastname == "Jean-Charles").ID,
                    Country3Code = "FRA",
                    Country = "France",
                    Position = Position.Forward
                    },
                new Profile{
                    PlayerID= players.Single(p => p.Firstname == "Antoine" && p.Lastname == "Diot").ID,
                    Country3Code = "FRA",
                    Country = "France",
                    Position = Position.Guard
                    },
                new Profile{
                    PlayerID= players.Single(p => p.Firstname == "Ismael" && p.Lastname == "Bako").ID,
                    Country3Code = "BEL",
                    Country = "Belgium",
                    Position = Position.Center
                    },
                new Profile{
                    PlayerID= players.Single(p => p.Firstname == "David" && p.Lastname == "Lighty").ID,
                    Country3Code = "USA",
                    Country = "United States of America",
                    Position = Position.Forward
                    },
                new Profile{
                    PlayerID= players.Single(p => p.Firstname == "Guerschon" && p.Lastname == "Yabusele").ID,
                    Country3Code = "FRA",
                    Country = "France",
                    Position = Position.Forward
                    },
                new Profile{
                    PlayerID= players.Single(p => p.Firstname == "Matthew" && p.Lastname == "Strazel").ID,
                    Country3Code = "FRA",
                    Country = "France",
                    Position = Position.Guard
                    },
                new Profile{
                    PlayerID = players.Single(p => p.Firstname == "Adreian" && p.Lastname == "Payne").ID,
                    Country3Code = "USA",
                    Country = "United States of America",
                    Position = Position.Center
                    },
                new Profile{
                    PlayerID= players.Single(p => p.Firstname == "Edwin" && p.Lastname == "Jackson").ID,
                    Country3Code = "FRA",
                    Country = "France",
                    Position = Position.Forward
                    }
            };
            profiles.ForEach(pr => context.Profiles.AddOrUpdate(p => p.PlayerID, pr));
            context.SaveChanges();

            var playerStats = new List<PlayerStat>
            {
                // Panathinaikos Players Statistics
                new PlayerStat{
                    GameID = games.Single(g => g.HomeTeamID == panathinaikosID && g.GuestTeamID == crvenaID).ID,
                    PlayerID = players.Single(p => p.Firstname == "Deshaun" && p.Lastname == "Thomas").ID,
                    TwoPointMade = 6, TwoPointAttempted = 13, ThreePointMade = 0, ThreePointAttempted = 1, FreeThrowMade = 6, FreeThrowAttempted = 7,
                    OffensiveRebounds = 4, DefensiveRebounds = 7, Assists = 2, Steals = 2, Turnovers = 1, BlocksMade = 0, BlocksReceived = 0, FoulsMade = 2,
                    FoulsReceived = 4},

                new PlayerStat{
                    GameID = games.Single(g => g.HomeTeamID == panathinaikosID && g.GuestTeamID == crvenaID).ID,
                    PlayerID = players.Single(p => p.Firstname == "Tyrese" && p.Lastname == "Rice").ID,
                    TwoPointMade = 2, TwoPointAttempted = 3, ThreePointMade = 1, ThreePointAttempted = 2, FreeThrowMade = 5, FreeThrowAttempted = 6,
                    OffensiveRebounds = 1, DefensiveRebounds = 1, Assists = 2, Steals = 1, Turnovers = 1, BlocksMade = 0, BlocksReceived = 0, FoulsMade = 1,
                    FoulsReceived = 4},

                new PlayerStat{
                    GameID = games.Single(g => g.HomeTeamID == panathinaikosID && g.GuestTeamID == crvenaID).ID,
                    PlayerID = players.Single(p => p.Firstname == "Georgios" && p.Lastname == "Papagiannis").ID,
                    TwoPointMade = 4, TwoPointAttempted = 6, ThreePointMade = 0, ThreePointAttempted = 0, FreeThrowMade = 0, FreeThrowAttempted = 2,
                    OffensiveRebounds = 0, DefensiveRebounds = 5, Assists = 0, Steals = 1, Turnovers = 0, BlocksMade = 2, BlocksReceived = 0, FoulsMade = 1,
                    FoulsReceived = 1},

                new PlayerStat{
                    GameID = games.Single(g => g.HomeTeamID == panathinaikosID && g.GuestTeamID == crvenaID).ID,
                    PlayerID = players.Single(p => p.Firstname == "Ioannis" &&  p.Lastname == "Papapetrou").ID,
                    TwoPointMade = 1, TwoPointAttempted = 2, ThreePointMade = 0, ThreePointAttempted = 1, FreeThrowMade = 0, FreeThrowAttempted = 0,
                    OffensiveRebounds = 0, DefensiveRebounds = 2, Assists = 0, Steals = 0, Turnovers = 0, BlocksMade = 1, BlocksReceived = 0, FoulsMade = 3,
                    FoulsReceived = 1},

                new PlayerStat{
                    GameID = games.Single(g => g.HomeTeamID == panathinaikosID && g.GuestTeamID == crvenaID).ID,
                    PlayerID = players.Single(p => p.Firstname == "Ian" &&  p.Lastname == "Vougioukas").ID,
                    TwoPointMade = 2, TwoPointAttempted = 2, ThreePointMade = 0, ThreePointAttempted = 0, FreeThrowMade = 0, FreeThrowAttempted = 0,
                    OffensiveRebounds = 0, DefensiveRebounds = 2, Assists = 0, Steals = 0, Turnovers = 4, BlocksMade = 0, BlocksReceived = 0, FoulsMade = 1,
                    FoulsReceived = 2},

                new PlayerStat{
                    GameID = games.Single(g => g.HomeTeamID == panathinaikosID && g.GuestTeamID == crvenaID).ID,
                    PlayerID = players.Single(p => p.Firstname == "Wesley" &&  p.Lastname == "Johnson").ID,
                    TwoPointMade = 1, TwoPointAttempted = 1, ThreePointMade = 0, ThreePointAttempted = 0, FreeThrowMade = 1, FreeThrowAttempted = 4,
                    OffensiveRebounds = 0, DefensiveRebounds = 3, Assists = 1, Steals = 2, Turnovers = 0, BlocksMade = 0, BlocksReceived = 0, FoulsMade = 2,
                    FoulsReceived = 2},

                // Its not Panathinaikos player any more. It should be fixed!
                new PlayerStat{
                    GameID = games.Single(g => g.HomeTeamID == panathinaikosID && g.GuestTeamID == crvenaID).ID,
                    PlayerID = players.Single(p => p.Firstname == "Rion" &&  p.Lastname == "Brown").ID,
                    TwoPointMade = 0, TwoPointAttempted = 0, ThreePointMade = 0, ThreePointAttempted = 0, FreeThrowMade = 0, FreeThrowAttempted = 0,
                    OffensiveRebounds = 0, DefensiveRebounds = 1, Assists = 0, Steals = 0, Turnovers = 0, BlocksMade = 0, BlocksReceived = 0, FoulsMade = 1,
                    FoulsReceived = 2},
                 // Its not Panathinaikos player any more. It should be fixed!

                new PlayerStat{
                    GameID = games.Single(g => g.HomeTeamID == panathinaikosID && g.GuestTeamID == crvenaID).ID,
                    PlayerID = players.Single(p => p.Firstname == "Jimmer" &&  p.Lastname == "Fredette").ID,
                    TwoPointMade = 2, TwoPointAttempted = 4, ThreePointMade = 1, ThreePointAttempted = 2, FreeThrowMade = 4, FreeThrowAttempted = 4,
                    OffensiveRebounds = 0, DefensiveRebounds = 1, Assists = 1, Steals = 0, Turnovers = 2, BlocksMade = 0, BlocksReceived = 0, FoulsMade = 2,
                    FoulsReceived = 3},

                new PlayerStat{
                    GameID = games.Single(g => g.HomeTeamID == panathinaikosID && g.GuestTeamID == crvenaID).ID,
                    PlayerID = players.Single(p => p.Firstname == "Nick" &&  p.Lastname == "Calathes").ID,
                    TwoPointMade = 5, TwoPointAttempted = 8, ThreePointMade = 3, ThreePointAttempted = 6, FreeThrowMade = 2, FreeThrowAttempted = 3,
                    OffensiveRebounds = 0, DefensiveRebounds = 3, Assists = 7, Steals = 1, Turnovers = 5, BlocksMade = 0, BlocksReceived = 2, FoulsMade = 1,
                    FoulsReceived = 6},

                new PlayerStat{
                    GameID = games.Single(g => g.HomeTeamID == panathinaikosID && g.GuestTeamID == crvenaID).ID,
                    PlayerID = players.Single(p => p.Firstname == "Jacob" &&  p.Lastname == "Wiley").ID,
                    TwoPointMade = 1, TwoPointAttempted = 2, ThreePointMade = 0, ThreePointAttempted = 1, FreeThrowMade = 0, FreeThrowAttempted = 0,
                    OffensiveRebounds = 1, DefensiveRebounds = 0, Assists = 1, Steals = 1, Turnovers = 0, BlocksMade = 1, BlocksReceived = 0, FoulsMade = 2,
                    FoulsReceived = 0},

                new PlayerStat{
                    GameID = games.Single(g => g.HomeTeamID == panathinaikosID && g.GuestTeamID == crvenaID).ID,
                    PlayerID = players.Single(p => p.Firstname == "Konstantinos" &&  p.Lastname == "Mitoglou").ID,
                    TwoPointMade = 2, TwoPointAttempted = 2, ThreePointMade = 0, ThreePointAttempted = 0, FreeThrowMade = 2, FreeThrowAttempted = 2,
                    OffensiveRebounds = 0, DefensiveRebounds = 0, Assists = 0, Steals = 0, Turnovers = 0, BlocksMade = 0, BlocksReceived = 0, FoulsMade = 1,
                    FoulsReceived = 2},

                //***************** DNP *****************//
                new PlayerStat{
                    GameID = games.Single(g => g.HomeTeamID == panathinaikosID && g.GuestTeamID == crvenaID).ID,
                    PlayerID = players.Single(p => p.Firstname == "Benjamin" && p.Lastname == "Bentil").ID,
                    TwoPointMade = 0, TwoPointAttempted = 0, ThreePointMade = 0, ThreePointAttempted = 0, FreeThrowMade = 0, FreeThrowAttempted = 0,
                    OffensiveRebounds = 0, DefensiveRebounds = 0, Assists = 0, Steals = 0, Turnovers = 0, BlocksMade = 0, BlocksReceived = 0, FoulsMade = 0,
                    FoulsReceived = 0},
                //***************** DNP *****************//

                // Crvena Zvezda Players Statistics
                new PlayerStat{
                    GameID = games.Single(g => g.HomeTeamID == panathinaikosID && g.GuestTeamID == crvenaID).ID,
                    PlayerID = players.Single(p => p.Firstname == "Derrick" && p.Lastname == "Brown").ID,
                    TwoPointMade = 0, TwoPointAttempted = 0, ThreePointMade = 1, ThreePointAttempted = 2, FreeThrowMade = 2, FreeThrowAttempted = 2,
                    OffensiveRebounds = 0, DefensiveRebounds = 1, Assists = 1, Steals = 0, Turnovers = 1, BlocksMade = 0, BlocksReceived = 0, FoulsMade = 1,
                    FoulsReceived = 1},

                new PlayerStat{
                    GameID = games.Single(g => g.HomeTeamID == panathinaikosID && g.GuestTeamID == crvenaID).ID,
                    PlayerID = players.Single(p => p.Firstname == "Filip" && p.Lastname == "Covic").ID,
                    TwoPointMade = 0, TwoPointAttempted = 0, ThreePointMade = 0, ThreePointAttempted = 0, FreeThrowMade = 0, FreeThrowAttempted = 0,
                    OffensiveRebounds = 0, DefensiveRebounds = 2, Assists = 0, Steals = 0, Turnovers = 3, BlocksMade = 0, BlocksReceived = 0, FoulsMade = 0,
                    FoulsReceived = 1},

                new PlayerStat{
                    GameID = games.Single(g => g.HomeTeamID == panathinaikosID && g.GuestTeamID == crvenaID).ID,
                    PlayerID = players.Single(p => p.Firstname == "Lorenzo" && p.Lastname == "Brown").ID,
                    TwoPointMade = 0, TwoPointAttempted = 3, ThreePointMade = 1, ThreePointAttempted = 1, FreeThrowMade = 0, FreeThrowAttempted = 0,
                    OffensiveRebounds = 1, DefensiveRebounds = 1, Assists = 0, Steals = 1, Turnovers = 2, BlocksMade = 0, BlocksReceived = 0, FoulsMade = 0,
                    FoulsReceived = 1},

                new PlayerStat{
                    GameID = games.Single(g => g.HomeTeamID == panathinaikosID && g.GuestTeamID == crvenaID).ID,
                    PlayerID = players.Single(p => p.Firstname == "Stratos" && p.Lastname == "Perperoglou").ID,
                    TwoPointMade = 3, TwoPointAttempted = 8, ThreePointMade = 2, ThreePointAttempted = 4, FreeThrowMade = 3, FreeThrowAttempted = 4,
                    OffensiveRebounds = 1, DefensiveRebounds = 2, Assists = 0, Steals = 3, Turnovers = 2, BlocksMade = 0, BlocksReceived = 0, FoulsMade = 4,
                    FoulsReceived = 4},

                new PlayerStat{
                    GameID = games.Single(g => g.HomeTeamID == panathinaikosID && g.GuestTeamID == crvenaID).ID,
                    PlayerID = players.Single(p => p.Firstname == "Dejan" && p.Lastname == "Davidovac").ID,
                    TwoPointMade = 0, TwoPointAttempted = 1, ThreePointMade = 1, ThreePointAttempted = 2, FreeThrowMade = 0, FreeThrowAttempted = 0,
                    OffensiveRebounds = 2, DefensiveRebounds = 1, Assists = 0, Steals = 1, Turnovers = 0, BlocksMade = 0, BlocksReceived = 0, FoulsMade = 2,
                    FoulsReceived = 2},

                new PlayerStat{
                    GameID = games.Single(g => g.HomeTeamID == panathinaikosID && g.GuestTeamID == crvenaID).ID,
                    PlayerID = players.Single(p => p.Firstname == "Branko" && p.Lastname == "Lazic").ID,
                    TwoPointMade = 0, TwoPointAttempted = 1, ThreePointMade = 0, ThreePointAttempted = 1, FreeThrowMade = 0, FreeThrowAttempted = 0,
                    OffensiveRebounds = 1, DefensiveRebounds = 0, Assists = 1, Steals = 0, Turnovers = 0, BlocksMade = 0, BlocksReceived = 0, FoulsMade = 3,
                    FoulsReceived = 1},

                new PlayerStat{
                    GameID = games.Single(g => g.HomeTeamID == panathinaikosID && g.GuestTeamID == crvenaID).ID,
                    PlayerID = players.Single(p => p.Firstname == "Mouhammad" && p.Lastname == "Faye").ID,
                    TwoPointMade = 0, TwoPointAttempted = 0, ThreePointMade = 1, ThreePointAttempted = 2, FreeThrowMade = 0, FreeThrowAttempted = 0,
                    OffensiveRebounds = 0, DefensiveRebounds = 2, Assists = 0, Steals = 0, Turnovers = 0, BlocksMade = 0, BlocksReceived = 0, FoulsMade = 2,
                    FoulsReceived = 0},

                new PlayerStat{
                    GameID = games.Single(g => g.HomeTeamID == panathinaikosID && g.GuestTeamID == crvenaID).ID,
                    PlayerID = players.Single(p => p.Firstname == "Billy" && p.Lastname == "Baron").ID,
                    TwoPointMade = 2, TwoPointAttempted = 7, ThreePointMade = 3, ThreePointAttempted = 6, FreeThrowMade = 2, FreeThrowAttempted = 2,
                    OffensiveRebounds = 0, DefensiveRebounds = 5, Assists = 6, Steals = 1, Turnovers = 2, BlocksMade = 1, BlocksReceived = 2, FoulsMade = 1,
                    FoulsReceived = 2},

                new PlayerStat{
                    GameID = games.Single(g => g.HomeTeamID == panathinaikosID && g.GuestTeamID == crvenaID).ID,
                    PlayerID = players.Single(p => p.Firstname == "Ognjen" && p.Lastname == "Dobric").ID,
                    TwoPointMade = 3, TwoPointAttempted = 4, ThreePointMade = 0, ThreePointAttempted = 1, FreeThrowMade = 0, FreeThrowAttempted = 0,
                    OffensiveRebounds = 0, DefensiveRebounds = 0, Assists = 1, Steals = 1, Turnovers = 1, BlocksMade = 0, BlocksReceived = 0, FoulsMade = 2,
                    FoulsReceived = 1},

                new PlayerStat{
                    GameID = games.Single(g => g.HomeTeamID == panathinaikosID && g.GuestTeamID == crvenaID).ID,
                    PlayerID = players.Single(p => p.Firstname == "James" && p.Lastname == "Gist").ID,
                    TwoPointMade = 9, TwoPointAttempted = 18, ThreePointMade = 0, ThreePointAttempted = 2, FreeThrowMade = 4, FreeThrowAttempted = 5,
                    OffensiveRebounds = 6, DefensiveRebounds = 1, Assists = 1, Steals = 0, Turnovers = 0, BlocksMade = 0, BlocksReceived = 1, FoulsMade = 4,
                    FoulsReceived = 4},

                new PlayerStat{
                    GameID = games.Single(g => g.HomeTeamID == panathinaikosID && g.GuestTeamID == crvenaID).ID,
                    PlayerID = players.Single(p => p.Firstname == "Charles" && p.Lastname == "Jenkins").ID,
                    TwoPointMade = 4, TwoPointAttempted = 6, ThreePointMade = 0, ThreePointAttempted = 1, FreeThrowMade = 0, FreeThrowAttempted = 0,
                    OffensiveRebounds = 0, DefensiveRebounds = 2, Assists = 0, Steals = 1, Turnovers = 0, BlocksMade = 0, BlocksReceived = 0, FoulsMade = 3,
                    FoulsReceived = 0},

                new PlayerStat{
                    GameID = games.Single(g => g.HomeTeamID == panathinaikosID && g.GuestTeamID == crvenaID).ID,
                    PlayerID = players.Single(p => p.Firstname == "Michael" && p.Lastname == "Ojo").ID,
                    TwoPointMade = 1, TwoPointAttempted = 2, ThreePointMade = 0, ThreePointAttempted = 0, FreeThrowMade = 0, FreeThrowAttempted = 0,
                    OffensiveRebounds = 0, DefensiveRebounds = 1, Assists = 0, Steals = 0, Turnovers = 2, BlocksMade = 1, BlocksReceived = 1, FoulsMade = 5,
                    FoulsReceived = 0},

                // Game2 //
               // Panathinaikos Players Statistics
                new PlayerStat{
                    GameID = games.Single(g => g.HomeTeamID == villeurbanneID  && g.GuestTeamID == panathinaikosID).ID,
                    PlayerID = players.Single(p => p.Firstname == "Deshaun" && p.Lastname == "Thomas").ID,
                    TwoPointMade = 7, TwoPointAttempted = 11, ThreePointMade = 2, ThreePointAttempted =2, FreeThrowMade = 2, FreeThrowAttempted = 2,
                    OffensiveRebounds = 4, DefensiveRebounds = 2, Assists = 2, Steals = 1, Turnovers = 1, BlocksMade = 1, BlocksReceived = 1, FoulsMade = 1,
                    FoulsReceived = 4},

                new PlayerStat{
                    GameID = games.Single(g => g.HomeTeamID == villeurbanneID  && g.GuestTeamID == panathinaikosID).ID,
                    PlayerID = players.Single(p => p.Firstname == "Tyrese" && p.Lastname == "Rice").ID,
                    TwoPointMade = 1, TwoPointAttempted = 2, ThreePointMade = 1, ThreePointAttempted = 3, FreeThrowMade = 1, FreeThrowAttempted = 2,
                    OffensiveRebounds = 1, DefensiveRebounds = 0, Assists = 0, Steals = 0, Turnovers = 2, BlocksMade = 0, BlocksReceived = 0, FoulsMade = 2,
                    FoulsReceived = 1},

                new PlayerStat{
                    GameID = games.Single(g => g.HomeTeamID == villeurbanneID  && g.GuestTeamID == panathinaikosID).ID,
                    PlayerID = players.Single(p => p.Firstname == "Georgios" && p.Lastname == "Papagiannis").ID,
                    TwoPointMade = 3, TwoPointAttempted = 6, ThreePointMade = 0, ThreePointAttempted = 0, FreeThrowMade = 0, FreeThrowAttempted = 0,
                    OffensiveRebounds = 2, DefensiveRebounds = 1, Assists = 0, Steals = 0, Turnovers = 1, BlocksMade = 0, BlocksReceived = 0, FoulsMade = 3,
                    FoulsReceived = 0},

                new PlayerStat{
                    GameID = games.Single(g => g.HomeTeamID == villeurbanneID  && g.GuestTeamID == panathinaikosID).ID,
                    PlayerID = players.Single(p => p.Firstname == "Ioannis" &&  p.Lastname == "Papapetrou").ID,
                    TwoPointMade = 2, TwoPointAttempted = 4, ThreePointMade = 0, ThreePointAttempted = 3, FreeThrowMade = 0, FreeThrowAttempted = 2,
                    OffensiveRebounds = 1, DefensiveRebounds = 3, Assists = 0, Steals = 0, Turnovers = 1, BlocksMade = 0, BlocksReceived = 1, FoulsMade = 3,
                    FoulsReceived = 1},

                //***************** DNP *****************//
                new PlayerStat{
                    GameID = games.Single(g => g.HomeTeamID == villeurbanneID  && g.GuestTeamID == panathinaikosID).ID,
                    PlayerID = players.Single(p => p.Firstname == "Ian" &&  p.Lastname == "Vougioukas").ID,
                    TwoPointMade = 0, TwoPointAttempted = 0, ThreePointMade = 0, ThreePointAttempted = 0, FreeThrowMade = 0, FreeThrowAttempted = 0,
                    OffensiveRebounds = 0, DefensiveRebounds = 0, Assists = 0, Steals = 0, Turnovers = 0, BlocksMade = 0, BlocksReceived = 0, FoulsMade = 0,
                    FoulsReceived = 0},
                //***************** DNP *****************//

                new PlayerStat{
                    GameID = games.Single(g => g.HomeTeamID == villeurbanneID  && g.GuestTeamID == panathinaikosID).ID,
                    PlayerID = players.Single(p => p.Firstname == "Wesley" &&  p.Lastname == "Johnson").ID,
                    TwoPointMade = 0, TwoPointAttempted = 0, ThreePointMade = 0, ThreePointAttempted = 1, FreeThrowMade = 0, FreeThrowAttempted = 0,
                    OffensiveRebounds = 0, DefensiveRebounds = 1, Assists = 1, Steals = 0, Turnovers = 1, BlocksMade = 1, BlocksReceived = 0, FoulsMade = 2,
                    FoulsReceived = 0},

                // Its not Panathinaikos player any more. It should be fixed!
                new PlayerStat{
                    GameID = games.Single(g => g.HomeTeamID == villeurbanneID  && g.GuestTeamID == panathinaikosID).ID,
                    PlayerID = players.Single(p => p.Firstname == "Rion" &&  p.Lastname == "Brown").ID,
                    TwoPointMade = 0, TwoPointAttempted = 0, ThreePointMade = 0, ThreePointAttempted = 0, FreeThrowMade = 0, FreeThrowAttempted = 2,
                    OffensiveRebounds = 0, DefensiveRebounds = 1, Assists = 0, Steals = 0, Turnovers = 0, BlocksMade = 0, BlocksReceived = 0, FoulsMade = 1,
                    FoulsReceived = 1},
                // Its not Panathinaikos player any more. It should be fixed!
                 
                new PlayerStat{
                    GameID = games.Single(g => g.HomeTeamID == villeurbanneID  && g.GuestTeamID == panathinaikosID).ID,
                    PlayerID = players.Single(p => p.Firstname == "Jimmer" &&  p.Lastname == "Fredette").ID,
                    TwoPointMade = 1, TwoPointAttempted = 4, ThreePointMade = 4, ThreePointAttempted = 6, FreeThrowMade = 4, FreeThrowAttempted = 5,
                    OffensiveRebounds = 0, DefensiveRebounds = 4, Assists = 3, Steals = 0, Turnovers = 2, BlocksMade = 0, BlocksReceived = 1, FoulsMade = 3,
                    FoulsReceived = 3},

                new PlayerStat{
                    GameID = games.Single(g => g.HomeTeamID == villeurbanneID  && g.GuestTeamID == panathinaikosID).ID,
                    PlayerID = players.Single(p => p.Firstname == "Nick" &&  p.Lastname == "Calathes").ID,
                    TwoPointMade = 3, TwoPointAttempted = 4, ThreePointMade = 1, ThreePointAttempted = 4, FreeThrowMade = 4, FreeThrowAttempted = 6,
                    OffensiveRebounds = 0, DefensiveRebounds = 3, Assists = 8, Steals = 3, Turnovers = 7, BlocksMade = 0, BlocksReceived = 0, FoulsMade = 2,
                    FoulsReceived = 7},

                new PlayerStat{
                    GameID = games.Single(g => g.HomeTeamID == villeurbanneID  && g.GuestTeamID == panathinaikosID).ID,
                    PlayerID = players.Single(p => p.Firstname == "Jacob" &&  p.Lastname == "Wiley").ID,
                    TwoPointMade = 3, TwoPointAttempted = 4, ThreePointMade = 0, ThreePointAttempted = 0, FreeThrowMade = 1, FreeThrowAttempted = 4,
                    OffensiveRebounds = 0, DefensiveRebounds = 3, Assists = 0, Steals = 2, Turnovers = 1, BlocksMade = 1, BlocksReceived = 0, FoulsMade = 2,
                    FoulsReceived = 2},

                new PlayerStat{
                    GameID = games.Single(g => g.HomeTeamID == villeurbanneID  && g.GuestTeamID == panathinaikosID).ID,
                    PlayerID = players.Single(p => p.Firstname == "Konstantinos" &&  p.Lastname == "Mitoglou").ID,
                    TwoPointMade = 0, TwoPointAttempted = 0, ThreePointMade = 0, ThreePointAttempted = 1, FreeThrowMade = 2, FreeThrowAttempted = 2,
                    OffensiveRebounds = 1, DefensiveRebounds = 0, Assists = 0, Steals = 0, Turnovers = 0, BlocksMade = 0, BlocksReceived = 0, FoulsMade = 0,
                    FoulsReceived = 1},

                new PlayerStat{
                    GameID = games.Single(g => g.HomeTeamID == villeurbanneID  && g.GuestTeamID == panathinaikosID).ID,
                    PlayerID = players.Single(p => p.Firstname == "Benjamin" && p.Lastname == "Bentil").ID,
                    TwoPointMade = 0, TwoPointAttempted = 0, ThreePointMade = 0, ThreePointAttempted = 0, FreeThrowMade = 0, FreeThrowAttempted = 2,
                    OffensiveRebounds = 1, DefensiveRebounds = 0, Assists = 0, Steals = 0, Turnovers = 0, BlocksMade = 0, BlocksReceived = 0, FoulsMade = 0,
                    FoulsReceived = 1},

                // Game2 //
               // LDLC ASVEL Villeurbanne Players Statistics
                new PlayerStat{
                    GameID = games.Single(g => g.HomeTeamID == villeurbanneID  && g.GuestTeamID == panathinaikosID).ID,
                    PlayerID = players.Single(p => p.Firstname == "Edwin" && p.Lastname == "Jackson").ID,
                    TwoPointMade = 2, TwoPointAttempted = 5, ThreePointMade = 0, ThreePointAttempted = 3, FreeThrowMade = 2, FreeThrowAttempted = 2,
                    OffensiveRebounds = 0, DefensiveRebounds = 2, Assists = 1, Steals = 2, Turnovers = 3, BlocksMade = 0, BlocksReceived = 0, FoulsMade = 2,
                    FoulsReceived = 4},

                new PlayerStat{
                    GameID = games.Single(g => g.HomeTeamID == villeurbanneID  && g.GuestTeamID == panathinaikosID).ID,
                    PlayerID = players.Single(p => p.Firstname == "Jordan" && p.Lastname == "Taylor").ID,
                    TwoPointMade = 2, TwoPointAttempted = 7, ThreePointMade = 1, ThreePointAttempted = 3, FreeThrowMade = 1, FreeThrowAttempted = 2,
                    OffensiveRebounds = 0, DefensiveRebounds = 2, Assists = 4, Steals = 2, Turnovers = 2, BlocksMade = 0, BlocksReceived = 1, FoulsMade = 3,
                    FoulsReceived = 3},

                new PlayerStat{
                    GameID = games.Single(g => g.HomeTeamID == villeurbanneID  && g.GuestTeamID == panathinaikosID).ID,
                    PlayerID = players.Single(p => p.Firstname == "Tonye" && p.Lastname == "Jekiri").ID,
                    TwoPointMade = 6, TwoPointAttempted = 10, ThreePointMade = 0, ThreePointAttempted = 0, FreeThrowMade = 3, FreeThrowAttempted = 4,
                    OffensiveRebounds = 7, DefensiveRebounds = 5, Assists = 1, Steals = 0, Turnovers = 0, BlocksMade = 0, BlocksReceived = 0, FoulsMade = 1,
                    FoulsReceived = 3},

                new PlayerStat{
                    GameID = games.Single(g => g.HomeTeamID == villeurbanneID  && g.GuestTeamID == panathinaikosID).ID,
                    PlayerID = players.Single(p => p.Firstname == "Charles" &&  p.Lastname == "Kahudi").ID,
                    TwoPointMade = 2, TwoPointAttempted = 5, ThreePointMade = 2, ThreePointAttempted = 2, FreeThrowMade = 0, FreeThrowAttempted = 0,
                    OffensiveRebounds = 1, DefensiveRebounds = 1, Assists = 0, Steals = 1, Turnovers = 1, BlocksMade = 0, BlocksReceived = 0, FoulsMade = 1,
                    FoulsReceived = 1},

                new PlayerStat{
                    GameID = games.Single(g => g.HomeTeamID == villeurbanneID  && g.GuestTeamID == panathinaikosID).ID,
                    PlayerID = players.Single(p => p.Firstname == "Rihards" &&  p.Lastname == "Lomazs").ID,
                    TwoPointMade = 0, TwoPointAttempted = 0, ThreePointMade = 1, ThreePointAttempted = 1, FreeThrowMade = 2, FreeThrowAttempted = 2,
                    OffensiveRebounds = 0, DefensiveRebounds = 0, Assists = 1, Steals = 0, Turnovers = 1, BlocksMade = 0, BlocksReceived = 0, FoulsMade = 4,
                    FoulsReceived = 1},

                new PlayerStat{
                    GameID = games.Single(g => g.HomeTeamID == villeurbanneID  && g.GuestTeamID == panathinaikosID).ID,
                    PlayerID = players.Single(p => p.Firstname == "Charles" &&  p.Lastname == "Galliou").ID,
                    TwoPointMade = 0, TwoPointAttempted = 0, ThreePointMade = 0, ThreePointAttempted = 0, FreeThrowMade = 0, FreeThrowAttempted = 0,
                    OffensiveRebounds = 1, DefensiveRebounds = 0, Assists = 0, Steals = 0, Turnovers = 0, BlocksMade = 0, BlocksReceived = 0, FoulsMade = 2,
                    FoulsReceived = 0},

                new PlayerStat{
                    GameID = games.Single(g => g.HomeTeamID == villeurbanneID  && g.GuestTeamID == panathinaikosID).ID,
                    PlayerID = players.Single(p => p.Firstname == "Amine" &&  p.Lastname == "Noua").ID,
                    TwoPointMade = 1, TwoPointAttempted = 1, ThreePointMade = 0, ThreePointAttempted = 2, FreeThrowMade = 0, FreeThrowAttempted = 0,
                    OffensiveRebounds = 0, DefensiveRebounds = 1, Assists = 0, Steals = 0, Turnovers = 0, BlocksMade = 1, BlocksReceived = 0, FoulsMade = 1,
                    FoulsReceived = 0},

                new PlayerStat{
                    GameID = games.Single(g => g.HomeTeamID == villeurbanneID  && g.GuestTeamID == panathinaikosID).ID,
                    PlayerID = players.Single(p => p.Firstname == "Livio" &&  p.Lastname == "Jean-Charles").ID,
                    TwoPointMade = 4, TwoPointAttempted = 6, ThreePointMade = 0, ThreePointAttempted = 2, FreeThrowMade = 0, FreeThrowAttempted = 0,
                    OffensiveRebounds = 3, DefensiveRebounds = 3, Assists = 1, Steals = 1, Turnovers = 1, BlocksMade = 1, BlocksReceived = 0, FoulsMade = 3,
                    FoulsReceived = 0},

                new PlayerStat{
                    GameID = games.Single(g => g.HomeTeamID == villeurbanneID  && g.GuestTeamID == panathinaikosID).ID,
                    PlayerID = players.Single(p => p.Firstname == "Antoine" &&  p.Lastname == "Diot").ID,
                    TwoPointMade = 2, TwoPointAttempted = 5, ThreePointMade = 0, ThreePointAttempted = 4, FreeThrowMade = 2, FreeThrowAttempted = 2,
                    OffensiveRebounds = 0, DefensiveRebounds = 0, Assists = 6, Steals = 2, Turnovers = 3, BlocksMade = 0, BlocksReceived = 1, FoulsMade = 2,
                    FoulsReceived = 4},

                new PlayerStat{
                    GameID = games.Single(g => g.HomeTeamID == villeurbanneID  && g.GuestTeamID == panathinaikosID).ID,
                    PlayerID = players.Single(p => p.Firstname == "Ismael" &&  p.Lastname == "Bako").ID,
                    TwoPointMade = 0, TwoPointAttempted = 0, ThreePointMade = 0, ThreePointAttempted = 0, FreeThrowMade = 1, FreeThrowAttempted = 2,
                    OffensiveRebounds = 0, DefensiveRebounds = 2, Assists = 0, Steals = 0, Turnovers = 0, BlocksMade = 1, BlocksReceived = 0, FoulsMade = 1,
                    FoulsReceived = 1},

                new PlayerStat{
                    GameID = games.Single(g => g.HomeTeamID == villeurbanneID  && g.GuestTeamID == panathinaikosID).ID,
                    PlayerID = players.Single(p => p.Firstname == "David" &&  p.Lastname == "Lighty").ID,
                    TwoPointMade = 4, TwoPointAttempted = 7, ThreePointMade = 3, ThreePointAttempted = 5, FreeThrowMade = 1, FreeThrowAttempted = 1,
                    OffensiveRebounds = 2, DefensiveRebounds = 2, Assists = 4, Steals = 0, Turnovers = 2, BlocksMade = 0, BlocksReceived = 1, FoulsMade = 1,
                    FoulsReceived = 2},

                //***************** DNP *****************//
                new PlayerStat{
                    GameID = games.Single(g => g.HomeTeamID == villeurbanneID  && g.GuestTeamID == panathinaikosID).ID,
                    PlayerID = players.Single(p => p.Firstname == "Matthew" && p.Lastname == "Strazel").ID,
                    TwoPointMade = 0, TwoPointAttempted = 0, ThreePointMade = 0, ThreePointAttempted = 0, FreeThrowMade = 0, FreeThrowAttempted = 0,
                    OffensiveRebounds = 0, DefensiveRebounds = 0, Assists = 0, Steals = 0, Turnovers = 0, BlocksMade = 0, BlocksReceived = 0, FoulsMade = 0,
                    FoulsReceived = 0}
                //***************** DNP *****************//
            };
            playerStats.ForEach(s => context.PlayerStats.AddOrUpdate(p => new { p.GameID, p.PlayerID }, s));
            context.SaveChanges();
        }
    }
}
