using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FantasyEuroleague.Enumerations;

namespace FantasyEuroleague.Dtos
{
    public class ProfileDto
    {
        public string Country { get; set; }
        public string Country3Code { get; set; }
        public Position Position { get; set; }
    }
}