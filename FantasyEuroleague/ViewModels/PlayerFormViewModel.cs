using FantasyEuroleague.Enumerations;
using FantasyEuroleague.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FantasyEuroleague.ViewModels
{
    public class PlayerFormViewModel
    {
        public int Id { get; set; }

        [Display(Name = "FirstName")]
        [Required]
        public string Firstname { get; set; }

        [Display(Name = "LastName")]
        [Required]
        public string Lastname { get; set; }

        public Profile Profile { get; set; }

        [Display (Name = "Players Club")]
        public int TeamID{ get; set; }
        public IEnumerable<Team> Teams { get; set; }

        public string OptionLabel { get; set; }

        public PlayerFormViewModel()
        {
            Id = 0;
            OptionLabel = "--Choose Nationality--";
        }

        public PlayerFormViewModel(Player player)
        {
            Id = player.ID;
            Firstname = player.Firstname;
            Lastname = player.Lastname;
            TeamID = player.TeamID;
        }

    }
}