using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FantasyEuroleague.Models
{
    public class Game
    {
        public int ID { get; set; }
        public int HomeTeamID { get; set; }
        public Team HomeTeam { get; set; }
        public int GuestTeamID { get; set; }
        public Team GuestTeam { get; set; }
        public ICollection<PlayerStat> PlayerStats { get; set; }
        public ICollection<TeamStat> TeamStats { get; set; }
    }
}