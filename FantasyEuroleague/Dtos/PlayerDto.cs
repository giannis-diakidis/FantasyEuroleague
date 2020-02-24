using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
// Using Enumerations
using FantasyEuroleague.Enumerations;
// Using Enumerations

namespace FantasyEuroleague.Dtos
{
    public class PlayerDto
    {
        public int ID { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public ProfileDto Profile { get; set; }
        public int TeamID { get; set; }
    }
}