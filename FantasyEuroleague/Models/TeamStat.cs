using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FantasyEuroleague.Interfaces;

namespace FantasyEuroleague.Models
{
    public class TeamStat:IStat
    {
        public int GameID { get; set; }
        public int TeamID { get; set; }
        public Game Game { get; set; }
        public Team Team { get; set; }
        public int TwoPointMade { get; set; }
        public int TwoPointAttempted { get; set; }
        public decimal TwoPointPercentage { get { return (TwoPointMade / TwoPointAttempted) * 100; } }
        public int ThreePointMade { get; set; }
        public int ThreePointAttempted { get; set; }
        public decimal ThreePointPercentage { get { return (ThreePointMade / ThreePointAttempted) * 100; } }
        public int FreeThrowMade { get; set; }
        public int FreeThrowAttempted { get; set; }
        public decimal FreeThrowPercentage { get { return (FreeThrowMade / FreeThrowAttempted) * 100; } }
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