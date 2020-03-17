using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using FantasyEuroleague.Enumerations;

namespace FantasyEuroleague.Models
{
    public class Profile
    {
        public int PlayerID { get; set; }
        public Player Player { get; set; }
        public string Country { get; set; }
        public string Country3Code { get; set; }
        public Position Position { get; set; }
    }
}