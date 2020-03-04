using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FantasyEuroleague.Dtos;
using FantasyEuroleague.Models;

namespace FantasyEuroleague.App_Start
{
    public class OrganizationProfile : AutoMapper.Profile
    {
        // Profile is class of AutoMapper and Models as well.
        public OrganizationProfile()
        {
            CreateMap<Player, PlayerDto>();
            CreateMap<PlayerDto, Player>();

            CreateMap<Profile, ProfileDto>();
            CreateMap<ProfileDto, Profile>();

            CreateMap<Team, TeamDto>();
            CreateMap<TeamDto, Team>();
        }
    }
}