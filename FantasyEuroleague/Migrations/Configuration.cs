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
            var teams = new List<Team>
            {
                new Team{Name = "Panathinaikos OPAP Athens"},
                new Team{Name = "Crvena Zvezda mts Belgrade"},
                new Team{Name = "LDLC ASVEL Villeurbanne" }
            };
            teams.ForEach(t => context.Teams.AddOrUpdate(t));
            context.SaveChanges();

            var games = new List<Game>
            {
                new Game
                {
                    HomeTeamID = teams.Single(t => t.Name == "Panathinaikos OPAP Athens").ID,
                    GuestTeamID = teams.Single(t => t.Name == "Crvena Zvezda mts Belgrade").ID
                },
                new Game
                {
                    HomeTeamID = teams.Single(t => t.Name == "LDLC ASVEL Villeurbanne").ID,
                    GuestTeamID = teams.Single(t => t.Name == "Panathinaikos OPAP Athens").ID
                }
            };
            games.ForEach(g => context.Games.AddOrUpdate(g));
            context.SaveChanges();

            var players = new List<Player>
            {
                // Panathinaikos Players
                new Player{
                    Firstname = "Deshaun", Lastname = "Thomas",
                    TeamID = teams.Single(t => t.Name == "Panathinaikos OPAP Athens").ID},
                new Player{
                    Firstname = "Tyrese", Lastname = "Rice",
                    TeamID = teams.Single(t => t.Name == "Panathinaikos OPAP Athens").ID},
                new Player{
                    Firstname = "Georgios", Lastname = "Papagiannis",
                    TeamID = teams.Single(t => t.Name == "Panathinaikos OPAP Athens").ID},
                new Player{
                    Firstname = "Andy", Lastname = "Rautins",
                    TeamID = teams.Single(t => t.Name == "Panathinaikos OPAP Athens").ID},
                new Player{
                    Firstname = "Ioannis", Lastname = "Papapetrou",
                    TeamID = teams.Single(t => t.Name == "Panathinaikos OPAP Athens").ID},
                new Player{
                    Firstname = "Nikos", Lastname = "Pappas",
                    TeamID = teams.Single(t => t.Name == "Panathinaikos OPAP Athens").ID},
                new Player{
                    Firstname = "Ian", Lastname = "Vougioukas",
                    TeamID = teams.Single(t => t.Name == "Panathinaikos OPAP Athens").ID},
                new Player{
                    Firstname = "Konstantinos", Lastname = "Papadakis",
                    TeamID = teams.Single(t => t.Name == "Panathinaikos OPAP Athens").ID},
                new Player{
                    Firstname = "Wesley", Lastname = "Johnson",
                    TeamID = teams.Single(t => t.Name == "Panathinaikos OPAP Athens").ID},
                new Player{
                    Firstname = "Jimmer", Lastname = "Fredette",
                    TeamID = teams.Single(t => t.Name == "Panathinaikos OPAP Athens").ID},
                new Player{
                    Firstname = "Nick", Lastname = "Calathes",
                    TeamID = teams.Single(t => t.Name == "Panathinaikos OPAP Athens").ID},
                new Player{
                    Firstname = "Jacob", Lastname = "Wiley",
                    TeamID = teams.Single(t => t.Name == "Panathinaikos OPAP Athens").ID},
                new Player{
                    Firstname = "Konstantinos", Lastname = "Mitoglou",
                    TeamID = teams.Single(t => t.Name == "Panathinaikos OPAP Athens").ID},
                new Player{
                    Firstname = "Benjamin", Lastname = "Bentil",
                    TeamID = teams.Single(t => t.Name == "Panathinaikos OPAP Athens").ID},

                // Former team Player (Brown)
                new Player{
                    Firstname = "Rion", Lastname = "Brown",
                    TeamID = teams.Single(t => t.Name == "Panathinaikos OPAP Athens").ID},
                // Former team Player (Brown)

                //Crvena Zvezda Players
                new Player{
                    Firstname = "Ognjen", Lastname = "Kuzmic",
                    TeamID = teams.Single(t => t.Name == "Crvena Zvezda mts Belgrade").ID},
                new Player{
                    Firstname = "Kevin", Lastname = "Punter",
                    TeamID = teams.Single(t => t.Name == "Crvena Zvezda mts Belgrade").ID},
                new Player{
                    Firstname = "Filip", Lastname = "Covic",
                    TeamID = teams.Single(t => t.Name == "Crvena Zvezda mts Belgrade").ID},
                new Player{
                    Firstname = "Lorenzo", Lastname = "Brown",
                    TeamID = teams.Single(t => t.Name == "Crvena Zvezda mts Belgrade").ID},
                new Player{
                    Firstname = "Stratos", Lastname = "Perperoglou",
                    TeamID = teams.Single(t => t.Name == "Crvena Zvezda mts Belgrade").ID},
                new Player{
                    Firstname = "Dejan", Lastname = "Davidovac",
                    TeamID = teams.Single(t => t.Name == "Crvena Zvezda mts Belgrade").ID},
                new Player{
                    Firstname = "Branko", Lastname = "Lazic",
                    TeamID = teams.Single(t => t.Name == "Crvena Zvezda mts Belgrade").ID},
                new Player{
                    Firstname = "Billy", Lastname = "Baron",
                    TeamID = teams.Single(t => t.Name == "Crvena Zvezda mts Belgrade").ID},
                new Player{
                    Firstname = "Ognjen", Lastname = "Dobric",
                    TeamID = teams.Single(t => t.Name == "Crvena Zvezda mts Belgrade").ID},
                new Player{
                    Firstname = "James", Lastname = "Gist",
                    TeamID = teams.Single(t => t.Name == "Crvena Zvezda mts Belgrade").ID},
                new Player{
                    Firstname = "Marko", Lastname = "Jagodic-Kuridza",
                    TeamID = teams.Single(t => t.Name == "Crvena Zvezda mts Belgrade").ID},
                new Player{
                    Firstname = "Charles", Lastname = "Jenkins",
                    TeamID = teams.Single(t => t.Name == "Crvena Zvezda mts Belgrade").ID},
                new Player{
                    Firstname = "Borisa", Lastname = "Simanic",
                    TeamID = teams.Single(t => t.Name == "Crvena Zvezda mts Belgrade").ID},
                new Player{
                    Firstname = "Nikola", Lastname = "Jovanovic",
                    TeamID = teams.Single(t => t.Name == "Crvena Zvezda mts Belgrade").ID},
                new Player{
                    Firstname = "Michael", Lastname = "Ojo",
                    TeamID = teams.Single(t => t.Name == "Crvena Zvezda mts Belgrade").ID},
                new Player{
                    Firstname = "Vladimir", Lastname = "Stimac",
                    TeamID = teams.Single(t => t.Name == "Crvena Zvezda mts Belgrade").ID},
                // Former team Players (Faye & Brown)
                new Player{
                    Firstname = "Mouhammad", Lastname = "Faye",
                    TeamID = teams.Single(t => t.Name == "Crvena Zvezda mts Belgrade").ID},
                new Player{
                    Firstname = "Derrick", Lastname = "Brown",
                    TeamID = teams.Single(t => t.Name == "Crvena Zvezda mts Belgrade").ID},
                // Former team Players (Faye & Brown)

                // LDLC ASVEL Villeurbanne Players
                new Player{
                     Firstname = "Jordan", Lastname = "Taylor",
                     TeamID = teams.Single(t => t.Name == "LDLC ASVEL Villeurbanne").ID},
                new Player{
                    Firstname = "Tonye", Lastname = "Jekiri",
                    TeamID = teams.Single(t => t.Name == "LDLC ASVEL Villeurbanne").ID},
                new Player{
                    Firstname = "Charles", Lastname = "Kahudi",
                    TeamID = teams.Single(t => t.Name == "LDLC ASVEL Villeurbanne").ID},
                new Player{
                    Firstname = "Theo", Lastname = "Maledon",
                    TeamID = teams.Single(t => t.Name == "LDLC ASVEL Villeurbanne").ID},
                new Player{
                    Firstname = "Davion", Lastname = "Berry",
                    TeamID = teams.Single(t => t.Name == "LDLC ASVEL Villeurbanne").ID},
                new Player{
                    Firstname = "Rihards", Lastname = "Lomazs",
                    TeamID = teams.Single(t => t.Name == "LDLC ASVEL Villeurbanne").ID},
                new Player{
                    Firstname = "Charles", Lastname = "Galliou",
                    TeamID = teams.Single(t => t.Name == "LDLC ASVEL Villeurbanne").ID},
                new Player{
                    Firstname = "Amine", Lastname = "Noua",
                    TeamID = teams.Single(t => t.Name == "LDLC ASVEL Villeurbanne").ID},
                new Player{
                    Firstname = "Livio", Lastname = "Jean-Charles",
                    TeamID = teams.Single(t => t.Name == "LDLC ASVEL Villeurbanne").ID},
                new Player{
                    Firstname = "Antoine", Lastname = "Diot",
                    TeamID = teams.Single(t => t.Name == "LDLC ASVEL Villeurbanne").ID},
                new Player{
                    Firstname = "Ismael", Lastname = "Bako",
                    TeamID = teams.Single(t => t.Name == "LDLC ASVEL Villeurbanne").ID},
                new Player{
                    Firstname = "David", Lastname = "Lighty",
                    TeamID = teams.Single(t => t.Name == "LDLC ASVEL Villeurbanne").ID},
                new Player{
                    Firstname = "Guerschon", Lastname = "Yabusele",
                    TeamID = teams.Single(t => t.Name == "LDLC ASVEL Villeurbanne").ID},
                new Player{
                    Firstname = "Matthew", Lastname = "Strazel",
                    TeamID = teams.Single(t => t.Name == "LDLC ASVEL Villeurbanne").ID},
                new Player{
                    Firstname = "Adreian", Lastname = "Payne",
                    TeamID = teams.Single(t => t.Name == "LDLC ASVEL Villeurbanne").ID},
                new Player{
                    Firstname = "Edwin", Lastname = "Jackson",
                    TeamID = teams.Single(t => t.Name == "LDLC ASVEL Villeurbanne").ID}
            };
            players.ForEach(pl => context.Players.AddOrUpdate(pl));
            context.SaveChanges();

            var profiles = new List<Profile>
            { 
                // Panathinaikos Players Profiles
                new Profile{
                     PlayerID= players.Single(p => p.Firstname == "Deshaun" && p.Lastname == "Thomas").ID,
                     Country = "USA",
                     Position = Position.Forward
                     },
                new Profile{
                    PlayerID= players.Single(p => p.Firstname == "Tyrese" && p.Lastname == "Rice").ID,
                    Country = "USA",
                    Position = Position.Guard
                    },
                new Profile{
                    PlayerID= players.Single(p => p.Firstname == "Georgios" && p.Lastname == "Papagiannis").ID,
                    Country = "GRE",
                    Position = Position.Center
                    },
                new Profile{
                    PlayerID= players.Single(p => p.Firstname == "Andy" && p.Lastname == "Rautins").ID,
                    Country = "CAN",
                    Position = Position.Guard
                    },
                new Profile{
                    PlayerID= players.Single(p => p.Firstname == "Ioannis" && p.Lastname == "Papapetrou").ID,
                    Country = "GRE",
                    Position = Position.Forward
                    },
                new Profile{
                    PlayerID= players.Single(p => p.Firstname == "Nikos" && p.Lastname == "Pappas").ID,
                    Country = "GRE",
                    Position = Position.Guard
                    },
                new Profile{
                    PlayerID= players.Single(p => p.Firstname == "Ian" && p.Lastname == "Vougioukas").ID,
                    Country = "GRE",
                    Position = Position.Center
                    },
                new Profile{
                    PlayerID= players.Single(p => p.Firstname == "Konstantinos" && p.Lastname == "Papadakis").ID,
                    Country = "GRE",
                    Position = Position.Guard
                    },
                new Profile{
                    PlayerID= players.Single(p => p.Firstname == "Wesley" && p.Lastname == "Johnson").ID,
                    Country = "USA",
                    Position = Position.Forward
                    },
                new Profile{
                    PlayerID= players.Single(p => p.Firstname == "Jimmer" && p.Lastname == "Fredette").ID,
                    Country = "USA",
                    Position = Position.Guard
                    },
                new Profile{
                    PlayerID= players.Single(p => p.Firstname == "Nick" && p.Lastname == "Calathes").ID,
                    Country = "GRE",
                    Position = Position.Guard
                    },
                new Profile{
                    PlayerID= players.Single(p => p.Firstname == "Jacob" && p.Lastname == "Wiley").ID,
                    Country = "USA",
                    Position = Position.Forward
                    },
                new Profile{
                    PlayerID= players.Single(p => p.Firstname == "Konstantinos" && p.Lastname == "Mitoglou").ID,
                    Country = "GRE",
                    Position = Position.Forward
                    },
                new Profile{
                    PlayerID= players.Single(p => p.Firstname == "Benjamin" && p.Lastname == "Bentil").ID,
                    Country = "GHA",
                    Position = Position.Forward
                    },
                new Profile{
                    PlayerID = players.Single(p => p.Firstname == "Rion" && p.Lastname == "Brown").ID,
                    Country = "USA",
                    Position = Position.Forward
                    },

                //Crvena Zvezda Players Profiles
                new Profile{
                     PlayerID= players.Single(p => p.Firstname == "Ognjen" && p.Lastname == "Kuzmic").ID,
                     Country = "SRB",
                     Position = Position.Center
                     },
                new Profile{
                    PlayerID= players.Single(p => p.Firstname == "Kevin" && p.Lastname == "Punter").ID,
                    Country = "USA",
                    Position = Position.Guard
                    },
                new Profile{
                    PlayerID= players.Single(p => p.Firstname == "Filip" && p.Lastname == "Covic").ID,
                    Country = "SRB",
                    Position = Position.Guard
                    },
                new Profile{
                    PlayerID= players.Single(p => p.Firstname == "Lorenzo" && p.Lastname == "Brown").ID,
                    Country = "USA",
                    Position = Position.Guard
                    },
                new Profile{
                    PlayerID= players.Single(p => p.Firstname == "Stratos" && p.Lastname == "Perperoglou").ID,
                    Country = "GRE",
                    Position = Position.Forward
                    },
                new Profile{
                    PlayerID= players.Single(p => p.Firstname == "Dejan" && p.Lastname == "Davidovac").ID,
                    Country = "SRB",
                    Position = Position.Forward
                    },
                new Profile{
                    PlayerID= players.Single(p => p.Firstname == "Branko" && p.Lastname == "Lazic").ID,
                    Country = "SRB",
                    Position = Position.Guard
                    },
                new Profile{
                    PlayerID= players.Single(p => p.Firstname == "Billy" && p.Lastname == "Baron").ID,
                    Country = "USA",
                    Position = Position.Guard
                    },
                new Profile{
                    PlayerID= players.Single(p => p.Firstname == "Ognjen" && p.Lastname == "Dobric").ID,
                    Country = "SRB",
                    Position = Position.Guard
                    },
                new Profile{
                    PlayerID= players.Single(p => p.Firstname == "James" && p.Lastname == "Gist").ID,
                    Country = "USA",
                    Position = Position.Forward
                    },
                new Profile{
                    PlayerID= players.Single(p => p.Firstname == "Marko" && p.Lastname == "Jagodic-Kuridza").ID,
                    Country = "SRB",
                    Position = Position.Forward
                    },
                new Profile{
                    PlayerID= players.Single(p => p.Firstname == "Charles" && p.Lastname == "Jenkins").ID,
                    Country = "SRB",
                    Position = Position.Guard
                    },
                new Profile{
                    PlayerID= players.Single(p => p.Firstname == "Borisa" && p.Lastname == "Simanic").ID,
                    Country = "SRB",
                    Position = Position.Forward
                    },
                new Profile{
                    PlayerID= players.Single(p => p.Firstname == "Nikola" && p.Lastname == "Jovanovic").ID,
                    Country = "SRB",
                    Position = Position.Center
                    },
                new Profile{
                    PlayerID = players.Single(p => p.Firstname == "Michael" && p.Lastname == "Ojo").ID,
                    Country = "NGR",
                    Position = Position.Center
                    },
                new Profile{
                    PlayerID = players.Single(p => p.Firstname == "Vladimir" && p.Lastname == "Stimac").ID,
                    Country = "SRB",
                    Position = Position.Center
                    },
                new Profile{
                    PlayerID = players.Single(p => p.Firstname == "Mouhammad" && p.Lastname == "Faye").ID,
                    Country = "SEN",
                    Position = Position.Forward
                    },
                new Profile{
                    PlayerID = players.Single(p => p.Firstname == "Derrick" && p.Lastname == "Brown").ID,
                    Country = "USA",
                    Position = Position.Forward
                },

                // LDLC ASVEL Villeurbanne
                new Profile{
                     PlayerID= players.Single(p => p.Firstname == "Jordan" && p.Lastname == "Taylor").ID,
                     Country = "USA",
                     Position = Position.Guard
                     },
                new Profile{
                    PlayerID= players.Single(p => p.Firstname == "Tonye" && p.Lastname == "Jekiri").ID,
                    Country = "NGR",
                    Position = Position.Center
                    },
                new Profile{
                    PlayerID= players.Single(p => p.Firstname == "Charles" && p.Lastname == "Kahudi").ID,
                    Country = "FRA",
                    Position = Position.Forward
                    },
                new Profile{
                    PlayerID= players.Single(p => p.Firstname == "Theo" && p.Lastname == "Maledon").ID,
                    Country = "FRA",
                    Position = Position.Guard
                    },
                new Profile{
                    PlayerID= players.Single(p => p.Firstname == "Davion" && p.Lastname == "Berry").ID,
                    Country = "USA",
                    Position = Position.Guard
                    },
                new Profile{
                    PlayerID= players.Single(p => p.Firstname == "Rihards" && p.Lastname == "Lomazs").ID,
                    Country = "LAT",
                    Position = Position.Forward
                    },
                new Profile{
                    PlayerID= players.Single(p => p.Firstname == "Charles" && p.Lastname == "Galliou").ID,
                    Country = "FRA",
                    Position = Position.Forward
                    },
                new Profile{
                    PlayerID= players.Single(p => p.Firstname == "Amine" && p.Lastname == "Noua").ID,
                    Country = "FRA",
                    Position = Position.Center
                    },
                new Profile{
                    PlayerID= players.Single(p => p.Firstname == "Livio" && p.Lastname == "Jean-Charles").ID,
                    Country = "FRA",
                    Position = Position.Forward
                    },
                new Profile{
                    PlayerID= players.Single(p => p.Firstname == "Antoine" && p.Lastname == "Diot").ID,
                    Country = "FRA",
                    Position = Position.Guard
                    },
                new Profile{
                    PlayerID= players.Single(p => p.Firstname == "Ismael" && p.Lastname == "Bako").ID,
                    Country = "BEL",
                    Position = Position.Center
                    },
                new Profile{
                    PlayerID= players.Single(p => p.Firstname == "David" && p.Lastname == "Lighty").ID,
                    Country = "USA",
                    Position = Position.Forward
                    },
                new Profile{
                    PlayerID= players.Single(p => p.Firstname == "Guerschon" && p.Lastname == "Yabusele").ID,
                    Country = "FRA",
                    Position = Position.Forward
                    },
                new Profile{
                    PlayerID= players.Single(p => p.Firstname == "Matthew" && p.Lastname == "Strazel").ID,
                    Country = "FRA",
                    Position = Position.Guard
                    },
                new Profile{
                    PlayerID = players.Single(p => p.Firstname == "Adreian" && p.Lastname == "Payne").ID,
                    Country = "USA",
                    Position = Position.Center
                    },
                new Profile{
                    PlayerID= players.Single(p => p.Firstname == "Edwin" && p.Lastname == "Jackson").ID,
                    Country = "FRA",
                    Position = Position.Forward
                    }
            };
            profiles.ForEach(pr => context.Profiles.AddOrUpdate(pr));
            context.SaveChanges();

            var playerStats = new List<PlayerStat>
            {
                // Panathinaikos Players Statistics
                new PlayerStat{
                    GameID = games.Single(g => g.HomeTeam.Name == "Panathinaikos OPAP Athens" && g.GuestTeam.Name == "Crvena Zvezda mts Belgrade").ID,
                    PlayerID = players.Single(p => p.Team.Name == "Panathinaikos OPAP Athens" && p.Firstname == "Deshaun" && p.Lastname == "Thomas").ID,
                    TwoPointMade = 6, TwoPointAttempted = 13, ThreePointMade = 0, ThreePointAttempted = 1, FreeThrowMade = 6, FreeThrowAttempted = 7,
                    OffensiveRebounds = 4, DefensiveRebounds = 7, Assists = 2, Steals = 2, Turnovers = 1, BlocksMade = 0, BlocksReceived = 0, FoulsMade = 2,
                    FoulsReceived = 4},

                new PlayerStat{
                    GameID = games.Single(g => g.HomeTeam.Name == "Panathinaikos OPAP Athens" && g.GuestTeam.Name == "Crvena Zvezda mts Belgrade").ID,
                    PlayerID = players.Single(p => p.Team.Name == "Panathinaikos OPAP Athens" && p.Firstname == "Tyrese" && p.Lastname == "Rice").ID,
                    TwoPointMade = 2, TwoPointAttempted = 3, ThreePointMade = 1, ThreePointAttempted = 2, FreeThrowMade = 5, FreeThrowAttempted = 6,
                    OffensiveRebounds = 1, DefensiveRebounds = 1, Assists = 2, Steals = 1, Turnovers = 1, BlocksMade = 0, BlocksReceived = 0, FoulsMade = 1,
                    FoulsReceived = 4},

                new PlayerStat{
                    GameID = games.Single(g => g.HomeTeam.Name == "Panathinaikos OPAP Athens" && g.GuestTeam.Name == "Crvena Zvezda mts Belgrade").ID,
                    PlayerID = players.Single(p => p.Team.Name == "Panathinaikos OPAP Athens" && p.Firstname == "Georgios" && p.Lastname == "Papagiannis").ID,
                    TwoPointMade = 4, TwoPointAttempted = 6, ThreePointMade = 0, ThreePointAttempted = 0, FreeThrowMade = 0, FreeThrowAttempted = 2,
                    OffensiveRebounds = 0, DefensiveRebounds = 5, Assists = 0, Steals = 1, Turnovers = 0, BlocksMade = 2, BlocksReceived = 0, FoulsMade = 1,
                    FoulsReceived = 1},

                new PlayerStat{
                    GameID = games.Single(g => g.HomeTeam.Name == "Panathinaikos OPAP Athens" && g.GuestTeam.Name == "Crvena Zvezda mts Belgrade").ID,
                    PlayerID = players.Single(p => p.Team.Name == "Panathinaikos OPAP Athens" && p.Firstname == "Ioannis" &&  p.Lastname == "Papapetrou").ID,
                    TwoPointMade = 1, TwoPointAttempted = 2, ThreePointMade = 0, ThreePointAttempted = 1, FreeThrowMade = 0, FreeThrowAttempted = 0,
                    OffensiveRebounds = 0, DefensiveRebounds = 2, Assists = 0, Steals = 0, Turnovers = 0, BlocksMade = 1, BlocksReceived = 0, FoulsMade = 3,
                    FoulsReceived = 1},

                new PlayerStat{
                    GameID = games.Single(g => g.HomeTeam.Name == "Panathinaikos OPAP Athens" && g.GuestTeam.Name == "Crvena Zvezda mts Belgrade").ID,
                    PlayerID = players.Single(p => p.Team.Name == "Panathinaikos OPAP Athens" && p.Firstname == "Ian" &&  p.Lastname == "Vougioukas").ID,
                    TwoPointMade = 2, TwoPointAttempted = 2, ThreePointMade = 0, ThreePointAttempted = 0, FreeThrowMade = 0, FreeThrowAttempted = 0,
                    OffensiveRebounds = 0, DefensiveRebounds = 2, Assists = 0, Steals = 0, Turnovers = 4, BlocksMade = 0, BlocksReceived = 0, FoulsMade = 1,
                    FoulsReceived = 2},

                new PlayerStat{
                    GameID = games.Single(g => g.HomeTeam.Name == "Panathinaikos OPAP Athens" && g.GuestTeam.Name == "Crvena Zvezda mts Belgrade").ID,
                    PlayerID = players.Single(p => p.Team.Name == "Panathinaikos OPAP Athens" && p.Firstname == "Wesley" &&  p.Lastname == "Johnson").ID,
                    TwoPointMade = 1, TwoPointAttempted = 1, ThreePointMade = 0, ThreePointAttempted = 0, FreeThrowMade = 1, FreeThrowAttempted = 4,
                    OffensiveRebounds = 0, DefensiveRebounds = 3, Assists = 1, Steals = 2, Turnovers = 0, BlocksMade = 0, BlocksReceived = 0, FoulsMade = 2,
                    FoulsReceived = 2},

                // Its not Panathinaikos player any more. It should be fixed!
                new PlayerStat{
                    GameID = games.Single(g => g.HomeTeam.Name == "Panathinaikos OPAP Athens" && g.GuestTeam.Name == "Crvena Zvezda mts Belgrade").ID,
                    PlayerID = players.Single(p => p.Team.Name == "Panathinaikos OPAP Athens" && p.Firstname == "Rion" &&  p.Lastname == "Brown").ID,
                    TwoPointMade = 0, TwoPointAttempted = 0, ThreePointMade = 0, ThreePointAttempted = 0, FreeThrowMade = 0, FreeThrowAttempted = 0,
                    OffensiveRebounds = 0, DefensiveRebounds = 1, Assists = 0, Steals = 0, Turnovers = 0, BlocksMade = 0, BlocksReceived = 0, FoulsMade = 1,
                    FoulsReceived = 2},
                 // Its not Panathinaikos player any more. It should be fixed!

                new PlayerStat{
                    GameID = games.Single(g => g.HomeTeam.Name == "Panathinaikos OPAP Athens" && g.GuestTeam.Name == "Crvena Zvezda mts Belgrade").ID,
                    PlayerID = players.Single(p => p.Team.Name == "Panathinaikos OPAP Athens" && p.Firstname == "Jimmer" &&  p.Lastname == "Fredette").ID,
                    TwoPointMade = 2, TwoPointAttempted = 4, ThreePointMade = 1, ThreePointAttempted = 2, FreeThrowMade = 4, FreeThrowAttempted = 4,
                    OffensiveRebounds = 0, DefensiveRebounds = 1, Assists = 1, Steals = 0, Turnovers = 2, BlocksMade = 0, BlocksReceived = 0, FoulsMade = 2,
                    FoulsReceived = 3},

                new PlayerStat{
                    GameID = games.Single(g => g.HomeTeam.Name == "Panathinaikos OPAP Athens" && g.GuestTeam.Name == "Crvena Zvezda mts Belgrade").ID,
                    PlayerID = players.Single(p => p.Team.Name == "Panathinaikos OPAP Athens" && p.Firstname == "Nick" &&  p.Lastname == "Calathes").ID,
                    TwoPointMade = 5, TwoPointAttempted = 8, ThreePointMade = 3, ThreePointAttempted = 6, FreeThrowMade = 2, FreeThrowAttempted = 3,
                    OffensiveRebounds = 0, DefensiveRebounds = 3, Assists = 7, Steals = 1, Turnovers = 5, BlocksMade = 0, BlocksReceived = 2, FoulsMade = 1,
                    FoulsReceived = 6},

                new PlayerStat{
                    GameID = games.Single(g => g.HomeTeam.Name == "Panathinaikos OPAP Athens" && g.GuestTeam.Name == "Crvena Zvezda mts Belgrade").ID,
                    PlayerID = players.Single(p => p.Team.Name == "Panathinaikos OPAP Athens" && p.Firstname == "Jacob" &&  p.Lastname == "Wiley").ID,
                    TwoPointMade = 1, TwoPointAttempted = 2, ThreePointMade = 0, ThreePointAttempted = 1, FreeThrowMade = 0, FreeThrowAttempted = 0,
                    OffensiveRebounds = 1, DefensiveRebounds = 0, Assists = 1, Steals = 1, Turnovers = 0, BlocksMade = 1, BlocksReceived = 0, FoulsMade = 2,
                    FoulsReceived = 0},

                new PlayerStat{
                    GameID = games.Single(g => g.HomeTeam.Name == "Panathinaikos OPAP Athens" && g.GuestTeam.Name == "Crvena Zvezda mts Belgrade").ID,
                    PlayerID = players.Single(p => p.Team.Name == "Panathinaikos OPAP Athens" && p.Firstname == "Konstantinos" &&  p.Lastname == "Mitoglou").ID,
                    TwoPointMade = 2, TwoPointAttempted = 2, ThreePointMade = 0, ThreePointAttempted = 0, FreeThrowMade = 2, FreeThrowAttempted = 2,
                    OffensiveRebounds = 0, DefensiveRebounds = 0, Assists = 0, Steals = 0, Turnovers = 0, BlocksMade = 0, BlocksReceived = 0, FoulsMade = 1,
                    FoulsReceived = 2},

                //***************** DNP *****************//
                new PlayerStat{
                    GameID = games.Single(g => g.HomeTeam.Name == "Panathinaikos OPAP Athens" && g.GuestTeam.Name == "Crvena Zvezda mts Belgrade").ID,
                    PlayerID = players.Single(p => p.Team.Name == "Panathinaikos OPAP Athens" && p.Firstname == "Benjamin" && p.Lastname == "Bentil").ID,
                    TwoPointMade = 0, TwoPointAttempted = 0, ThreePointMade = 0, ThreePointAttempted = 0, FreeThrowMade = 0, FreeThrowAttempted = 0,
                    OffensiveRebounds = 0, DefensiveRebounds = 0, Assists = 0, Steals = 0, Turnovers = 0, BlocksMade = 0, BlocksReceived = 0, FoulsMade = 0,
                    FoulsReceived = 0},
                //***************** DNP *****************//

                // Crvena Zvezda Players Statistics
                new PlayerStat{
                    GameID = games.Single(g => g.HomeTeam.Name == "Panathinaikos OPAP Athens" && g.GuestTeam.Name == "Crvena Zvezda mts Belgrade").ID,
                    PlayerID = players.Single(p => p.Team.Name == "Crvena Zvezda mts Belgrade" && p.Firstname == "Derrick" && p.Lastname == "Brown").ID,
                    TwoPointMade = 0, TwoPointAttempted = 0, ThreePointMade = 1, ThreePointAttempted = 2, FreeThrowMade = 2, FreeThrowAttempted = 2,
                    OffensiveRebounds = 0, DefensiveRebounds = 1, Assists = 1, Steals = 0, Turnovers = 1, BlocksMade = 0, BlocksReceived = 0, FoulsMade = 1,
                    FoulsReceived = 1},

                new PlayerStat{
                    GameID = games.Single(g => g.HomeTeam.Name == "Panathinaikos OPAP Athens" && g.GuestTeam.Name == "Crvena Zvezda mts Belgrade").ID,
                    PlayerID = players.Single(p => p.Team.Name == "Crvena Zvezda mts Belgrade" && p.Firstname == "Filip" && p.Lastname == "Covic").ID,
                    TwoPointMade = 0, TwoPointAttempted = 0, ThreePointMade = 0, ThreePointAttempted = 0, FreeThrowMade = 0, FreeThrowAttempted = 0,
                    OffensiveRebounds = 0, DefensiveRebounds = 2, Assists = 0, Steals = 0, Turnovers = 3, BlocksMade = 0, BlocksReceived = 0, FoulsMade = 0,
                    FoulsReceived = 1},

                new PlayerStat{
                    GameID = games.Single(g => g.HomeTeam.Name == "Panathinaikos OPAP Athens" && g.GuestTeam.Name == "Crvena Zvezda mts Belgrade").ID,
                    PlayerID = players.Single(p => p.Team.Name == "Crvena Zvezda mts Belgrade" && p.Firstname == "Lorenzo" && p.Lastname == "Brown").ID,
                    TwoPointMade = 0, TwoPointAttempted = 3, ThreePointMade = 1, ThreePointAttempted = 1, FreeThrowMade = 0, FreeThrowAttempted = 0,
                    OffensiveRebounds = 1, DefensiveRebounds = 1, Assists = 0, Steals = 1, Turnovers = 2, BlocksMade = 0, BlocksReceived = 0, FoulsMade = 0,
                    FoulsReceived = 1},

                new PlayerStat{
                    GameID = games.Single(g => g.HomeTeam.Name == "Panathinaikos OPAP Athens" && g.GuestTeam.Name == "Crvena Zvezda mts Belgrade").ID,
                    PlayerID = players.Single(p => p.Team.Name == "Crvena Zvezda mts Belgrade" && p.Firstname == "Stratos" && p.Lastname == "Perperoglou").ID,
                    TwoPointMade = 3, TwoPointAttempted = 8, ThreePointMade = 2, ThreePointAttempted = 4, FreeThrowMade = 3, FreeThrowAttempted = 4,
                    OffensiveRebounds = 1, DefensiveRebounds = 2, Assists = 0, Steals = 3, Turnovers = 2, BlocksMade = 0, BlocksReceived = 0, FoulsMade = 4,
                    FoulsReceived = 4},

                new PlayerStat{
                    GameID = games.Single(g => g.HomeTeam.Name == "Panathinaikos OPAP Athens" && g.GuestTeam.Name == "Crvena Zvezda mts Belgrade").ID,
                    PlayerID = players.Single(p => p.Team.Name == "Crvena Zvezda mts Belgrade" && p.Firstname == "Dejan" && p.Lastname == "Davidovac").ID,
                    TwoPointMade = 0, TwoPointAttempted = 1, ThreePointMade = 1, ThreePointAttempted = 2, FreeThrowMade = 0, FreeThrowAttempted = 0,
                    OffensiveRebounds = 2, DefensiveRebounds = 1, Assists = 0, Steals = 1, Turnovers = 0, BlocksMade = 0, BlocksReceived = 0, FoulsMade = 2,
                    FoulsReceived = 2},

                new PlayerStat{
                    GameID = games.Single(g => g.HomeTeam.Name == "Panathinaikos OPAP Athens" && g.GuestTeam.Name == "Crvena Zvezda mts Belgrade").ID,
                    PlayerID = players.Single(p => p.Team.Name == "Crvena Zvezda mts Belgrade" && p.Firstname == "Branko" && p.Lastname == "Lazic").ID,
                    TwoPointMade = 0, TwoPointAttempted = 1, ThreePointMade = 0, ThreePointAttempted = 1, FreeThrowMade = 0, FreeThrowAttempted = 0,
                    OffensiveRebounds = 1, DefensiveRebounds = 0, Assists = 1, Steals = 0, Turnovers = 0, BlocksMade = 0, BlocksReceived = 0, FoulsMade = 3,
                    FoulsReceived = 1},

                new PlayerStat{
                    GameID = games.Single(g => g.HomeTeam.Name == "Panathinaikos OPAP Athens" && g.GuestTeam.Name == "Crvena Zvezda mts Belgrade").ID,
                    PlayerID = players.Single(p => p.Team.Name == "Crvena Zvezda mts Belgrade" && p.Firstname == "Mouhammad" && p.Lastname == "Faye").ID,
                    TwoPointMade = 0, TwoPointAttempted = 0, ThreePointMade = 1, ThreePointAttempted = 2, FreeThrowMade = 0, FreeThrowAttempted = 0,
                    OffensiveRebounds = 0, DefensiveRebounds = 2, Assists = 0, Steals = 0, Turnovers = 0, BlocksMade = 0, BlocksReceived = 0, FoulsMade = 2,
                    FoulsReceived = 0},

                new PlayerStat{
                    GameID = games.Single(g => g.HomeTeam.Name == "Panathinaikos OPAP Athens" && g.GuestTeam.Name == "Crvena Zvezda mts Belgrade").ID,
                    PlayerID = players.Single(p => p.Team.Name == "Crvena Zvezda mts Belgrade" && p.Firstname == "Billy" && p.Lastname == "Baron").ID,
                    TwoPointMade = 2, TwoPointAttempted = 7, ThreePointMade = 3, ThreePointAttempted = 6, FreeThrowMade = 2, FreeThrowAttempted = 2,
                    OffensiveRebounds = 0, DefensiveRebounds = 5, Assists = 6, Steals = 1, Turnovers = 2, BlocksMade = 1, BlocksReceived = 2, FoulsMade = 1,
                    FoulsReceived = 2},

                new PlayerStat{
                    GameID = games.Single(g => g.HomeTeam.Name == "Panathinaikos OPAP Athens" && g.GuestTeam.Name == "Crvena Zvezda mts Belgrade").ID,
                    PlayerID = players.Single(p => p.Team.Name == "Crvena Zvezda mts Belgrade" && p.Firstname == "Ognjen" && p.Lastname == "Dobric").ID,
                    TwoPointMade = 3, TwoPointAttempted = 4, ThreePointMade = 0, ThreePointAttempted = 1, FreeThrowMade = 0, FreeThrowAttempted = 0,
                    OffensiveRebounds = 0, DefensiveRebounds = 0, Assists = 1, Steals = 1, Turnovers = 1, BlocksMade = 0, BlocksReceived = 0, FoulsMade = 2,
                    FoulsReceived = 1},

                new PlayerStat{
                    GameID = games.Single(g => g.HomeTeam.Name == "Panathinaikos OPAP Athens" && g.GuestTeam.Name == "Crvena Zvezda mts Belgrade").ID,
                    PlayerID = players.Single(p => p.Team.Name == "Crvena Zvezda mts Belgrade" && p.Firstname == "James" && p.Lastname == "Gist").ID,
                    TwoPointMade = 9, TwoPointAttempted = 18, ThreePointMade = 0, ThreePointAttempted = 2, FreeThrowMade = 4, FreeThrowAttempted = 5,
                    OffensiveRebounds = 6, DefensiveRebounds = 1, Assists = 1, Steals = 0, Turnovers = 0, BlocksMade = 0, BlocksReceived = 1, FoulsMade = 4,
                    FoulsReceived = 4},

                new PlayerStat{
                    GameID = games.Single(g => g.HomeTeam.Name == "Panathinaikos OPAP Athens" && g.GuestTeam.Name == "Crvena Zvezda mts Belgrade").ID,
                    PlayerID = players.Single(p => p.Team.Name == "Crvena Zvezda mts Belgrade" && p.Firstname == "Charles" && p.Lastname == "Jenkins").ID,
                    TwoPointMade = 4, TwoPointAttempted = 6, ThreePointMade = 0, ThreePointAttempted = 1, FreeThrowMade = 0, FreeThrowAttempted = 0,
                    OffensiveRebounds = 0, DefensiveRebounds = 2, Assists = 0, Steals = 1, Turnovers = 0, BlocksMade = 0, BlocksReceived = 0, FoulsMade = 3,
                    FoulsReceived = 0},

                new PlayerStat{
                    GameID = games.Single(g => g.HomeTeam.Name == "Panathinaikos OPAP Athens" && g.GuestTeam.Name == "Crvena Zvezda mts Belgrade").ID,
                    PlayerID = players.Single(p => p.Team.Name == "Crvena Zvezda mts Belgrade" && p.Firstname == "Michael" && p.Lastname == "Ojo").ID,
                    TwoPointMade = 1, TwoPointAttempted = 2, ThreePointMade = 0, ThreePointAttempted = 0, FreeThrowMade = 0, FreeThrowAttempted = 0,
                    OffensiveRebounds = 0, DefensiveRebounds = 1, Assists = 0, Steals = 0, Turnovers = 2, BlocksMade = 1, BlocksReceived = 1, FoulsMade = 5,
                    FoulsReceived = 0},

                // Game2 //
               // Panathinaikos Players Statistics
                new PlayerStat{
                    GameID = games.Single(g => g.HomeTeam.Name == "LDLC ASVEL Villeurbanne"  && g.GuestTeam.Name == "Panathinaikos OPAP Athens").ID,
                    PlayerID = players.Single(p => p.Team.Name == "Panathinaikos OPAP Athens" && p.Firstname == "Deshaun" && p.Lastname == "Thomas").ID,
                    TwoPointMade = 7, TwoPointAttempted = 11, ThreePointMade = 2, ThreePointAttempted =2, FreeThrowMade = 2, FreeThrowAttempted = 2,
                    OffensiveRebounds = 4, DefensiveRebounds = 2, Assists = 2, Steals = 1, Turnovers = 1, BlocksMade = 1, BlocksReceived = 1, FoulsMade = 1,
                    FoulsReceived = 4},

                new PlayerStat{
                    GameID = games.Single(g => g.HomeTeam.Name == "LDLC ASVEL Villeurbanne" && g.GuestTeam.Name == "Panathinaikos OPAP Athens").ID,
                    PlayerID = players.Single(p => p.Team.Name == "Panathinaikos OPAP Athens" && p.Firstname == "Tyrese" && p.Lastname == "Rice").ID,
                    TwoPointMade = 1, TwoPointAttempted = 2, ThreePointMade = 1, ThreePointAttempted = 3, FreeThrowMade = 1, FreeThrowAttempted = 2,
                    OffensiveRebounds = 1, DefensiveRebounds = 0, Assists = 0, Steals = 0, Turnovers = 2, BlocksMade = 0, BlocksReceived = 0, FoulsMade = 2,
                    FoulsReceived = 1},

                new PlayerStat{
                    GameID = games.Single(g => g.HomeTeam.Name == "LDLC ASVEL Villeurbanne" && g.GuestTeam.Name == "Panathinaikos OPAP Athens").ID,
                    PlayerID = players.Single(p => p.Team.Name == "Panathinaikos OPAP Athens" && p.Firstname == "Georgios" && p.Lastname == "Papagiannis").ID,
                    TwoPointMade = 3, TwoPointAttempted = 6, ThreePointMade = 0, ThreePointAttempted = 0, FreeThrowMade = 0, FreeThrowAttempted = 0,
                    OffensiveRebounds = 2, DefensiveRebounds = 1, Assists = 0, Steals = 0, Turnovers = 1, BlocksMade = 0, BlocksReceived = 0, FoulsMade = 3,
                    FoulsReceived = 0},

                new PlayerStat{
                    GameID = games.Single(g => g.HomeTeam.Name == "LDLC ASVEL Villeurbanne" && g.GuestTeam.Name == "Panathinaikos OPAP Athens").ID,
                    PlayerID = players.Single(p => p.Team.Name == "Panathinaikos OPAP Athens" && p.Firstname == "Ioannis" &&  p.Lastname == "Papapetrou").ID,
                    TwoPointMade = 2, TwoPointAttempted = 4, ThreePointMade = 0, ThreePointAttempted = 3, FreeThrowMade = 0, FreeThrowAttempted = 2,
                    OffensiveRebounds = 1, DefensiveRebounds = 3, Assists = 0, Steals = 0, Turnovers = 1, BlocksMade = 0, BlocksReceived = 1, FoulsMade = 3,
                    FoulsReceived = 1},
                //***************** DNP *****************//
                new PlayerStat{
                    GameID = games.Single(g => g.HomeTeam.Name == "LDLC ASVEL Villeurbanne" && g.GuestTeam.Name == "Panathinaikos OPAP Athens").ID,
                    PlayerID = players.Single(p => p.Team.Name == "Panathinaikos OPAP Athens" && p.Firstname == "Ian" &&  p.Lastname == "Vougioukas").ID,
                    TwoPointMade = 0, TwoPointAttempted = 0, ThreePointMade = 0, ThreePointAttempted = 0, FreeThrowMade = 0, FreeThrowAttempted = 0,
                    OffensiveRebounds = 0, DefensiveRebounds = 0, Assists = 0, Steals = 0, Turnovers = 0, BlocksMade = 0, BlocksReceived = 0, FoulsMade = 0,
                    FoulsReceived = 0},
                //***************** DNP *****************//

                new PlayerStat{
                    GameID = games.Single(g => g.HomeTeam.Name == "LDLC ASVEL Villeurbanne" && g.GuestTeam.Name == "Panathinaikos OPAP Athens").ID,
                    PlayerID = players.Single(p => p.Team.Name == "Panathinaikos OPAP Athens" && p.Firstname == "Wesley" &&  p.Lastname == "Johnson").ID,
                    TwoPointMade = 0, TwoPointAttempted = 0, ThreePointMade = 0, ThreePointAttempted = 1, FreeThrowMade = 0, FreeThrowAttempted = 0,
                    OffensiveRebounds = 0, DefensiveRebounds = 1, Assists = 1, Steals = 0, Turnovers = 1, BlocksMade = 1, BlocksReceived = 0, FoulsMade = 2,
                    FoulsReceived = 0},

                // Its not Panathinaikos player any more. It should be fixed!
                new PlayerStat{
                    GameID = games.Single(g => g.HomeTeam.Name == "LDLC ASVEL Villeurbanne" && g.GuestTeam.Name == "Panathinaikos OPAP Athens").ID,
                    PlayerID = players.Single(p => p.Team.Name == "Panathinaikos OPAP Athens" && p.Firstname == "Rion" &&  p.Lastname == "Brown").ID,
                    TwoPointMade = 0, TwoPointAttempted = 0, ThreePointMade = 0, ThreePointAttempted = 0, FreeThrowMade = 0, FreeThrowAttempted = 2,
                    OffensiveRebounds = 0, DefensiveRebounds = 1, Assists = 0, Steals = 0, Turnovers = 0, BlocksMade = 0, BlocksReceived = 0, FoulsMade = 1,
                    FoulsReceived = 1},
                 // Its not Panathinaikos player any more. It should be fixed!
                 
                new PlayerStat{
                    GameID = games.Single(g => g.HomeTeam.Name == "LDLC ASVEL Villeurbanne" && g.GuestTeam.Name == "Panathinaikos OPAP Athens").ID,
                    PlayerID = players.Single(p => p.Team.Name == "Panathinaikos OPAP Athens" && p.Firstname == "Jimmer" &&  p.Lastname == "Fredette").ID,
                    TwoPointMade = 1, TwoPointAttempted = 4, ThreePointMade = 4, ThreePointAttempted = 6, FreeThrowMade = 4, FreeThrowAttempted = 5,
                    OffensiveRebounds = 0, DefensiveRebounds = 4, Assists = 3, Steals = 0, Turnovers = 2, BlocksMade = 0, BlocksReceived = 1, FoulsMade = 3,
                    FoulsReceived = 3},

                new PlayerStat{
                    GameID = games.Single(g => g.HomeTeam.Name == "LDLC ASVEL Villeurbanne" && g.GuestTeam.Name == "Panathinaikos OPAP Athens").ID,
                    PlayerID = players.Single(p => p.Team.Name == "Panathinaikos OPAP Athens" && p.Firstname == "Nick" &&  p.Lastname == "Calathes").ID,
                    TwoPointMade = 3, TwoPointAttempted = 4, ThreePointMade = 1, ThreePointAttempted = 4, FreeThrowMade = 4, FreeThrowAttempted = 6,
                    OffensiveRebounds = 0, DefensiveRebounds = 3, Assists = 8, Steals = 3, Turnovers = 7, BlocksMade = 0, BlocksReceived = 0, FoulsMade = 2,
                    FoulsReceived = 7},

                new PlayerStat{
                    GameID = games.Single(g => g.HomeTeam.Name == "LDLC ASVEL Villeurbanne" && g.GuestTeam.Name == "Panathinaikos OPAP Athens").ID,
                    PlayerID = players.Single(p => p.Team.Name == "Panathinaikos OPAP Athens" && p.Firstname == "Jacob" &&  p.Lastname == "Wiley").ID,
                    TwoPointMade = 3, TwoPointAttempted = 4, ThreePointMade = 0, ThreePointAttempted = 0, FreeThrowMade = 1, FreeThrowAttempted = 4,
                    OffensiveRebounds = 0, DefensiveRebounds = 3, Assists = 0, Steals = 2, Turnovers = 1, BlocksMade = 1, BlocksReceived = 0, FoulsMade = 2,
                    FoulsReceived = 2},

                new PlayerStat{
                    GameID = games.Single(g => g.HomeTeam.Name == "LDLC ASVEL Villeurbanne" && g.GuestTeam.Name == "Panathinaikos OPAP Athens").ID,
                    PlayerID = players.Single(p => p.Team.Name == "Panathinaikos OPAP Athens" && p.Firstname == "Konstantinos" &&  p.Lastname == "Mitoglou").ID,
                    TwoPointMade = 0, TwoPointAttempted = 0, ThreePointMade = 0, ThreePointAttempted = 1, FreeThrowMade = 2, FreeThrowAttempted = 2,
                    OffensiveRebounds = 1, DefensiveRebounds = 0, Assists = 0, Steals = 0, Turnovers = 0, BlocksMade = 0, BlocksReceived = 0, FoulsMade = 0,
                    FoulsReceived = 1},

                new PlayerStat{
                    GameID = games.Single(g => g.HomeTeam.Name == "LDLC ASVEL Villeurbanne" && g.GuestTeam.Name == "Panathinaikos OPAP Athens").ID,
                    PlayerID = players.Single(p => p.Team.Name == "Panathinaikos OPAP Athens" && p.Firstname == "Benjamin" && p.Lastname == "Bentil").ID,
                    TwoPointMade = 0, TwoPointAttempted = 0, ThreePointMade = 0, ThreePointAttempted = 0, FreeThrowMade = 0, FreeThrowAttempted = 2,
                    OffensiveRebounds = 1, DefensiveRebounds = 0, Assists = 0, Steals = 0, Turnovers = 0, BlocksMade = 0, BlocksReceived = 0, FoulsMade = 0,
                    FoulsReceived = 1},

                // Game2 //
               // LDLC ASVEL Villeurbanne Players Statistics
                new PlayerStat{
                    GameID = games.Single(g => g.HomeTeam.Name == "LDLC ASVEL Villeurbanne"  && g.GuestTeam.Name == "Panathinaikos OPAP Athens").ID,
                    PlayerID = players.Single(p => p.Team.Name == "LDLC ASVEL Villeurbanne" && p.Firstname == "Edwin" && p.Lastname == "Jackson").ID,
                    TwoPointMade = 2, TwoPointAttempted = 5, ThreePointMade = 0, ThreePointAttempted = 3, FreeThrowMade = 2, FreeThrowAttempted = 2,
                    OffensiveRebounds = 0, DefensiveRebounds = 2, Assists = 1, Steals = 2, Turnovers = 3, BlocksMade = 0, BlocksReceived = 0, FoulsMade = 2,
                    FoulsReceived = 4},

                new PlayerStat{
                    GameID = games.Single(g => g.HomeTeam.Name == "LDLC ASVEL Villeurbanne" && g.GuestTeam.Name == "Panathinaikos OPAP Athens").ID,
                    PlayerID = players.Single(p => p.Team.Name == "LDLC ASVEL Villeurbanne" && p.Firstname == "Jordan" && p.Lastname == "Taylor").ID,
                    TwoPointMade = 2, TwoPointAttempted = 7, ThreePointMade = 1, ThreePointAttempted = 3, FreeThrowMade = 1, FreeThrowAttempted = 2,
                    OffensiveRebounds = 0, DefensiveRebounds = 2, Assists = 4, Steals = 2, Turnovers = 2, BlocksMade = 0, BlocksReceived = 1, FoulsMade = 3,
                    FoulsReceived = 3},

                new PlayerStat{
                    GameID = games.Single(g => g.HomeTeam.Name == "LDLC ASVEL Villeurbanne" && g.GuestTeam.Name == "Panathinaikos OPAP Athens").ID,
                    PlayerID = players.Single(p => p.Team.Name == "LDLC ASVEL Villeurbanne" && p.Firstname == "Tonye" && p.Lastname == "Jekiri").ID,
                    TwoPointMade = 6, TwoPointAttempted = 10, ThreePointMade = 0, ThreePointAttempted = 0, FreeThrowMade = 3, FreeThrowAttempted = 4,
                    OffensiveRebounds = 7, DefensiveRebounds = 5, Assists = 1, Steals = 0, Turnovers = 0, BlocksMade = 0, BlocksReceived = 0, FoulsMade = 1,
                    FoulsReceived = 3},

                new PlayerStat{
                    GameID = games.Single(g => g.HomeTeam.Name == "LDLC ASVEL Villeurbanne" && g.GuestTeam.Name == "Panathinaikos OPAP Athens").ID,
                    PlayerID = players.Single(p => p.Team.Name == "LDLC ASVEL Villeurbanne" && p.Firstname == "Charles" &&  p.Lastname == "Kahudi").ID,
                    TwoPointMade = 2, TwoPointAttempted = 5, ThreePointMade = 2, ThreePointAttempted = 2, FreeThrowMade = 0, FreeThrowAttempted = 0,
                    OffensiveRebounds = 1, DefensiveRebounds = 1, Assists = 0, Steals = 1, Turnovers = 1, BlocksMade = 0, BlocksReceived = 0, FoulsMade = 1,
                    FoulsReceived = 1},

                new PlayerStat{
                    GameID = games.Single(g => g.HomeTeam.Name == "LDLC ASVEL Villeurbanne" && g.GuestTeam.Name == "Panathinaikos OPAP Athens").ID,
                    PlayerID = players.Single(p => p.Team.Name == "LDLC ASVEL Villeurbanne" && p.Firstname == "Rihards" &&  p.Lastname == "Lomazs").ID,
                    TwoPointMade = 0, TwoPointAttempted = 0, ThreePointMade = 1, ThreePointAttempted = 1, FreeThrowMade = 2, FreeThrowAttempted = 2,
                    OffensiveRebounds = 0, DefensiveRebounds = 0, Assists = 1, Steals = 0, Turnovers = 1, BlocksMade = 0, BlocksReceived = 0, FoulsMade = 4,
                    FoulsReceived = 1},

                new PlayerStat{
                    GameID = games.Single(g => g.HomeTeam.Name == "LDLC ASVEL Villeurbanne" && g.GuestTeam.Name == "Panathinaikos OPAP Athens").ID,
                    PlayerID = players.Single(p => p.Team.Name == "LDLC ASVEL Villeurbanne" && p.Firstname == "Charles" &&  p.Lastname == "Galliou").ID,
                    TwoPointMade = 0, TwoPointAttempted = 0, ThreePointMade = 0, ThreePointAttempted = 0, FreeThrowMade = 0, FreeThrowAttempted = 0,
                    OffensiveRebounds = 1, DefensiveRebounds = 0, Assists = 0, Steals = 0, Turnovers = 0, BlocksMade = 0, BlocksReceived = 0, FoulsMade = 2,
                    FoulsReceived = 0},

                new PlayerStat{
                    GameID = games.Single(g => g.HomeTeam.Name == "LDLC ASVEL Villeurbanne" && g.GuestTeam.Name == "Panathinaikos OPAP Athens").ID,
                    PlayerID = players.Single(p => p.Team.Name == "LDLC ASVEL Villeurbanne" && p.Firstname == "Amine" &&  p.Lastname == "Noua").ID,
                    TwoPointMade = 1, TwoPointAttempted = 1, ThreePointMade = 0, ThreePointAttempted = 2, FreeThrowMade = 0, FreeThrowAttempted = 0,
                    OffensiveRebounds = 0, DefensiveRebounds = 1, Assists = 0, Steals = 0, Turnovers = 0, BlocksMade = 1, BlocksReceived = 0, FoulsMade = 1,
                    FoulsReceived = 0},
              
                new PlayerStat{
                    GameID = games.Single(g => g.HomeTeam.Name == "LDLC ASVEL Villeurbanne" && g.GuestTeam.Name == "Panathinaikos OPAP Athens").ID,
                    PlayerID = players.Single(p => p.Team.Name == "LDLC ASVEL Villeurbanne" && p.Firstname == "Livio" &&  p.Lastname == "Jean-Charles").ID,
                    TwoPointMade = 4, TwoPointAttempted = 6, ThreePointMade = 0, ThreePointAttempted = 2, FreeThrowMade = 0, FreeThrowAttempted = 0,
                    OffensiveRebounds = 3, DefensiveRebounds = 3, Assists = 1, Steals = 1, Turnovers = 1, BlocksMade = 1, BlocksReceived = 0, FoulsMade = 3,
                    FoulsReceived = 0},

                new PlayerStat{
                    GameID = games.Single(g => g.HomeTeam.Name == "LDLC ASVEL Villeurbanne" && g.GuestTeam.Name == "Panathinaikos OPAP Athens").ID,
                    PlayerID = players.Single(p => p.Team.Name == "LDLC ASVEL Villeurbanne" && p.Firstname == "Antoine" &&  p.Lastname == "Diot").ID,
                    TwoPointMade = 2, TwoPointAttempted = 5, ThreePointMade = 0, ThreePointAttempted = 4, FreeThrowMade = 2, FreeThrowAttempted = 2,
                    OffensiveRebounds = 0, DefensiveRebounds = 0, Assists = 6, Steals = 2, Turnovers = 3, BlocksMade = 0, BlocksReceived = 1, FoulsMade = 2,
                    FoulsReceived = 4},

                new PlayerStat{
                    GameID = games.Single(g => g.HomeTeam.Name == "LDLC ASVEL Villeurbanne" && g.GuestTeam.Name == "Panathinaikos OPAP Athens").ID,
                    PlayerID = players.Single(p => p.Team.Name == "LDLC ASVEL Villeurbanne" && p.Firstname == "Ismael" &&  p.Lastname == "Bako").ID,
                    TwoPointMade = 0, TwoPointAttempted = 0, ThreePointMade = 0, ThreePointAttempted = 0, FreeThrowMade = 1, FreeThrowAttempted = 2,
                    OffensiveRebounds = 0, DefensiveRebounds = 2, Assists = 0, Steals = 0, Turnovers = 0, BlocksMade = 1, BlocksReceived = 0, FoulsMade = 1,
                    FoulsReceived = 1},

                new PlayerStat{
                    GameID = games.Single(g => g.HomeTeam.Name == "LDLC ASVEL Villeurbanne" && g.GuestTeam.Name == "Panathinaikos OPAP Athens").ID,
                    PlayerID = players.Single(p => p.Team.Name == "LDLC ASVEL Villeurbanne" && p.Firstname == "David" &&  p.Lastname == "Lighty").ID,
                    TwoPointMade = 4, TwoPointAttempted = 7, ThreePointMade = 3, ThreePointAttempted = 5, FreeThrowMade = 1, FreeThrowAttempted = 1,
                    OffensiveRebounds = 2, DefensiveRebounds = 2, Assists = 4, Steals = 0, Turnovers = 2, BlocksMade = 0, BlocksReceived = 1, FoulsMade = 1,
                    FoulsReceived = 2},

                //***************** DNP *****************//
                new PlayerStat{
                    GameID = games.Single(g => g.HomeTeam.Name == "LDLC ASVEL Villeurbanne" && g.GuestTeam.Name == "Panathinaikos OPAP Athens").ID,
                    PlayerID = players.Single(p => p.Team.Name == "LDLC ASVEL Villeurbanne" && p.Firstname == "Matthew" && p.Lastname == "Strazel").ID,
                    TwoPointMade = 0, TwoPointAttempted = 0, ThreePointMade = 0, ThreePointAttempted = 0, FreeThrowMade = 0, FreeThrowAttempted = 0,
                    OffensiveRebounds = 0, DefensiveRebounds = 0, Assists = 0, Steals = 0, Turnovers = 0, BlocksMade = 0, BlocksReceived = 0, FoulsMade = 0,
                    FoulsReceived = 0}
                //***************** DNP *****************//
            };
            playerStats.ForEach(pl => context.PlayerStats.AddOrUpdate(pl));
            context.SaveChanges();
        }
    }
}
