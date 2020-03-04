using FantasyEuroleague.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FantasyEuroleague.ViewModels
{
    public class PlayerDetailsViewModel
    {
        // Total Stats
        public int TotalTwoPointsMade { get; set; } = 0;
        public int TotalTwoPointsAttempted { get; set; } = 0;
        public int TotalThreePointsMade { get; set; } = 0;
        public int TotalThreePointsAttempted { get; set; } = 0;
        public int TotalFreeThrowsMade { get; set; } = 0;
        public int TotalFreeThrowsAttempted { get; set; } = 0;
        public int TotalPoints { get { return TotalTwoPointsMade * 2 + TotalThreePointsMade * 3 + TotalFreeThrowsMade; } }
        public int TotalAssists { get; set; } = 0;
        public int TotalDefensiveRebounds { get; set; } = 0;
        public int TotalOffensiveRebounds { get; set; } = 0;
        public int TotalRebounds { get { return TotalDefensiveRebounds + TotalOffensiveRebounds; } }
        public int TotalSteals { get; set; } = 0;
        public int TotalTurnovers { get; set; } = 0;
        public int TotalBlocksMade { get; set; } = 0;
        public int TotalBlocksReceived { get; set; } = 0;
        public int TotalFoulsMade { get; set; } = 0;
        public int TotalFoulsReceived { get; set; } = 0;
        public int TotalPIR { get; set; } = 0;

        // Stats as Percentages
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:N2}")]
        public decimal AveragePoints { get; set; } = 0;

        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:N2}")]
        public decimal AverageTwoPoints { get { return (TotalTwoPointsAttempted == 0 ? 0 : (decimal)TotalTwoPointsMade / TotalTwoPointsAttempted * 100); } }

        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:N2}")]
        public decimal AverageThreePoints { get { return (TotalThreePointsAttempted == 0 ? 0 : (decimal)TotalThreePointsMade / TotalThreePointsAttempted * 100); } }

        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:N2}")]
        public decimal AverageFreeThrows { get { return (TotalFreeThrowsAttempted == 0 ? 0 : (decimal)TotalFreeThrowsMade / TotalFreeThrowsAttempted * 100); } }

        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:N1}")]
        public decimal AverageOffensiveRebounds { get; set; } = 0;

        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:N1}")]
        public decimal AverageDefensiveRebounds { get; set; } = 0;

        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:N1}")]
        public decimal AverageRebounds { get { return AverageDefensiveRebounds + AverageOffensiveRebounds; } }

        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:N1}")]
        public decimal AverageAssists { get; set; } = 0;

        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:N1}")]
        public decimal AverageSteals { get; set; } = 0;

        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:N1}")]
        public decimal AverageTurnovers { get; set; } = 0;

        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:N1}")]
        public decimal AverageBlocksMade { get; set; } = 0;

        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:N1}")]
        public decimal AverageBlocksReceived { get; set; } = 0;

        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:N1}")]
        public decimal AverageFoulsMade { get; set; } = 0;

        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:N1}")]
        public decimal AverageFoulsReceived { get; set; } = 0;

        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:N1}")]
        public decimal AveragePIR { get; set; } = 0;

        public int NumberOfGames { get; set; } = 0;

        public PlayerDetailsViewModel(){}

        public void AddStat(List<PlayerStat> stats)
        {
            int numberOfGames = stats.Count();
            NumberOfGames = numberOfGames;

            foreach (var stat in stats)
            {
                TotalTwoPointsMade += stat.TwoPointMade;
                TotalTwoPointsAttempted += stat.TwoPointAttempted;
                TotalThreePointsMade += stat.ThreePointMade;
                TotalThreePointsAttempted += stat.ThreePointAttempted;
                TotalFreeThrowsMade += stat.FreeThrowMade;
                TotalFreeThrowsAttempted += stat.FreeThrowAttempted;
                TotalAssists += stat.Assists;
                TotalDefensiveRebounds += stat.DefensiveRebounds;
                TotalOffensiveRebounds += stat.OffensiveRebounds;
                TotalSteals += stat.Steals;
                TotalTurnovers += stat.Turnovers;
                TotalBlocksMade += stat.BlocksMade;
                TotalBlocksReceived += stat.BlocksReceived;
                TotalFoulsMade += stat.FoulsMade;
                TotalFoulsReceived += stat.FoulsReceived;
                TotalPIR += stat.PIR;
            }

            if (numberOfGames != 0)
            {

                AveragePoints = (TotalPoints / (decimal)numberOfGames);
                AverageOffensiveRebounds = (TotalOffensiveRebounds / (decimal)numberOfGames);
                AverageDefensiveRebounds = (TotalDefensiveRebounds / (decimal)numberOfGames);
                AverageAssists = (TotalAssists / (decimal)numberOfGames);
                AverageSteals = (TotalSteals / (decimal)numberOfGames);
                AverageTurnovers = (TotalTurnovers / (decimal)numberOfGames);
                AverageBlocksMade = (TotalBlocksMade / (decimal)numberOfGames);
                AverageBlocksReceived = (TotalBlocksReceived / (decimal)numberOfGames);
                AverageFoulsMade = (TotalFoulsMade / (decimal)numberOfGames);
                AverageFoulsReceived = (TotalFoulsReceived / (decimal)numberOfGames);
                AveragePIR = (TotalPIR / (decimal)numberOfGames);
            }
        }

    }
}