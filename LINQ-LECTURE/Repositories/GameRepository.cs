using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using GamerLinqDemoApp.Models;
using System.Data.Entity.Infrastructure;

namespace GamerLinqDemoApp.Repositories
{
    public class GameRepository
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        //Group Characters by Game Name
        public void GroupCharacters()
        {
            var characters = db.Characters.Include(g => g.Game);
            var groupedCharacters = characters.GroupBy(c => c.GameId, c => c.Name, (key, val) => new
            {
                GameId = key,
                Characters = val.ToList()
            });

            foreach (var game in groupedCharacters)
            {
                Console.WriteLine(game.Characters);
            }

        }
    }
}