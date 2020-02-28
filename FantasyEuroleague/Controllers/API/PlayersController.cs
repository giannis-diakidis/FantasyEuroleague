using FantasyEuroleague.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using FantasyEuroleague.Dtos;
using AutoMapper;

namespace FantasyEuroleague.Controllers.API
{
    public class PlayersController : ApiController
    {
        private ApplicationDbContext context;

        public PlayersController()
        {
            context = new ApplicationDbContext();
        }

        // GET: /api/players
        public IEnumerable<PlayerDto> GetPlayers()
        {
            return context.Players
                .Include(p => p.Profile)
                .Select(Mapper.Map<Player, PlayerDto>);
        }

        // GET: /api/player/id
        public IHttpActionResult GetPlayer(int id)
        {
            var player = context.Players
                .Include(p => p.Profile)
                .SingleOrDefault(p => p.ID == id);

            if (player == null)
                return NotFound();

            return Ok(Mapper.Map<Player, PlayerDto>(player));
        }

        // POST: /api/players
        [HttpPost]
        public IHttpActionResult CreatePlayer(PlayerDto playerDto)
        {
            if (!ModelState.IsValid)
                return NotFound();

            var player = Mapper.Map<PlayerDto, Player>(playerDto);
            context.Players.Add(player);
            context.SaveChanges();
            return Created(new Uri(Request.RequestUri + "/" + player.ID), playerDto);
        }

        // PUT: /api/players/id
        [HttpPut]
        public void UpdatePlayer(int id, PlayerDto playerDto)
        {
            if (!ModelState.IsValid)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            var playerDb = context.Players
                .Include(p => p.Profile)
                .SingleOrDefault(p => p.ID == id);

            if (playerDb == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            Mapper.Map(playerDto, playerDb);
            context.SaveChanges();
        }

        // DELETE: /api/players/id
        [HttpDelete]
        public void DeletePlayer(int id)
        {
            var playerDb = context.Players.
                Include(p => p.Profile)
                .SingleOrDefault(p => p.ID == id);

            if (playerDb == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            context.Players.Remove(playerDb);
            context.SaveChanges();
        }
    }
}
