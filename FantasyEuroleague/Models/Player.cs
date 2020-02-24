using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FantasyEuroleague.Models
{
    public class Player
    {
        public int ID { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Fullname { get { return Firstname + " " + Lastname; } }
        public Profile Profile { get; set; }
        public int TeamID { get; set; }
        public Team Team { get; set; }
        public ICollection<PlayerStat> PlayerStats { get; set; }
    }
}