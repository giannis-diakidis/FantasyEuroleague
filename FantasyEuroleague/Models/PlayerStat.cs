using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using FantasyEuroleague.Interfaces;

namespace FantasyEuroleague.Models
{
    public class PlayerStat:IStat
    {
        public int GameID { get; set; }
        public int PlayerID { get; set; }
        public Game Game { get; set; }
        public Player Player { get; set; }
        public int TwoPointMade { get; set; }
        public int TwoPointAttempted { get; set; }

        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:N2}")]
        public decimal TwoPointPercentage { get { return (TwoPointAttempted == 0 ? 0 : (decimal)TwoPointMade / TwoPointAttempted * 100); } }
        public int ThreePointMade { get; set; }
        public int ThreePointAttempted { get; set; }

        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:N2}")]
        public decimal ThreePointPercentage { get { return (ThreePointAttempted == 0 ? 0 : (decimal)ThreePointMade / ThreePointAttempted * 100); } }
        public int FreeThrowMade { get; set; }
        public int FreeThrowAttempted { get; set; }

        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:N2}")]
        public decimal FreeThrowPercentage { get { return (FreeThrowAttempted == 0 ? 0 : (decimal)FreeThrowMade / FreeThrowAttempted * 100); } }
        public int Points { get { return TwoPointMade * 2 + ThreePointMade * 3 + FreeThrowMade; } }
        public int Assists { get; set; }
        public int DefensiveRebounds { get; set; }
        public int OffensiveRebounds { get; set; }
        public int Rebounds { get { return DefensiveRebounds + OffensiveRebounds; } }
        public int Steals { get; set; }
        public int Turnovers { get; set; }
        public int BlocksMade { get; set; }
        public int BlocksReceived { get; set; }
        public int FoulsMade { get; set; }
        public int FoulsReceived { get; set; }
        public int ShotsMissed { get { return TwoPointAttempted - TwoPointMade + ThreePointAttempted - ThreePointMade + FreeThrowAttempted - FreeThrowMade; } }
        public int PIR { get { return Points + Rebounds + Assists + BlocksMade + Steals + FoulsReceived - (Turnovers + FoulsMade + BlocksReceived + ShotsMissed); } }
    }
}