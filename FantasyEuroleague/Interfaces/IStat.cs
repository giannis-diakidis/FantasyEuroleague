using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyEuroleague.Interfaces
{
    interface IStat
    {
        int TwoPointMade { get; set; }
        int TwoPointAttempted { get; set; }
        decimal TwoPointPercentage { get; }
        int ThreePointMade { get; set; }
        int ThreePointAttempted { get; set; }
        decimal ThreePointPercentage { get; }
        int FreeThrowMade { get; set; }
        int FreeThrowAttempted { get; set; }
        decimal FreeThrowPercentage { get; }
        int Points { get; }
        int Assists { get; set; }
        int DefensiveRebounds { get; set; }
        int OffensiveRebounds { get; set; }
        int Rebounds { get; }
        int Steals { get; set; }
        int Turnovers { get; set; }
        int BlocksMade { get; set; }
        int BlocksReceived { get; set; }
        int FoulsMade { get; set; }
        int FoulsReceived { get; set; }
        int ShotsMissed { get; }
        int PIR { get; }
    }
}
