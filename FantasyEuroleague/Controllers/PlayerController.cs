using FantasyEuroleague.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using FantasyEuroleague.ViewModels;

namespace FantasyEuroleague.Controllers
{
    public class PlayerController : Controller
    {
        private ApplicationDbContext context;

        public PlayerController()
        {
            context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            context.Dispose();
        }

        // GET: Player
        public ActionResult Index()
        {
            //var players = context.Players
            //.Include(p => p.Profile)
            //.Include(p => p.Team).ToList();

            //return View(players);

            return View("PlayersList");
        }

        //[Authorize(Roles = RoleName.AppManager)]
        // GET: Player/New
        public ViewResult New()
        {
            var teams = context.Teams.ToList();
            var viewModel = new PlayerFormViewModel()
            { 
                Teams = teams
            };
            return View("PlayerForm", viewModel);
        }

        // POST: Player/Save
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Save(Player player)
        {
            if (!ModelState.IsValid)
            {
                var viewModel = new PlayerFormViewModel(player)
                {
                    Teams = context.Teams.ToList()
                };
                return View("PlayerForm", viewModel);
            }

            // Create Player & Profile
            if (player.ID == 0)
            {
                context.Players.Add(player);
            }
            // Update Player & Profile
            else
            {
                var playerInDb = context.Players
                    .Include(p => p.Profile).Single(pl => pl.ID == player.ID);

                playerInDb.Firstname = player.Firstname;
                playerInDb.Lastname = player.Lastname;
                playerInDb.Profile.Country = player.Profile.Country;
                playerInDb.Profile.Position = player.Profile.Position;
                playerInDb.TeamID = player.TeamID;
            }

            context.SaveChanges();
            return RedirectToAction("Index", "Player");
        }

        //[Authorize(Roles = RoleName.AppManager)]
        // GET: Player/Edit/id
        public ActionResult Edit(int id)
        {
            var player = context.Players
                .Include(p => p.Profile).SingleOrDefault(p => p.ID == id);

            if (player == null)
                return HttpNotFound();

            var viewModel = new PlayerFormViewModel(player)
            {
                Teams = context.Teams.ToList(),
                Profile = player.Profile
            };

            return View("PlayerForm", viewModel);
        }

        //[Authorize(Roles = RoleName.AppManager)]
        // GET: Player/Delete/id
        public ActionResult Delete(int id)
        {
            var playerInDb = context.Players.
                 Include(p => p.Profile)
                .SingleOrDefault(p => p.ID == id);

            if (playerInDb == null)
                return HttpNotFound();

            context.Players.Remove(playerInDb);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}