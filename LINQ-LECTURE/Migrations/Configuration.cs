namespace GamerLinqDemoApp.Migrations
{
    using Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<GamerLinqDemoApp.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(GamerLinqDemoApp.Models.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            context.GameSystems.AddOrUpdate(
              gs => gs.Id,
              new GameSystem
              {
                  Id = 1,
                  SystemName = "Nintendo Entertainment System",
                  Games = new List<Game> {
                    new Game { GameId = 1, Name = "Legend of Zelda" },
                    new Game { GameId = 2, Name = "Super Mario Bros." },
                    new Game { GameId = 3, Name = "Metroid" },
                    new Game { GameId = 4, Name = "Super Mario Bros. 2" },
                    new Game { GameId = 5, Name = "Super Mario Bros. 3" },
                    new Game { GameId = 6, Name = "Bomberman" },
                    new Game { GameId = 7, Name = "Punch Out" },
                    new Game { GameId = 8, Name = "Castlevania" },
                    new Game { GameId = 9, Name = "Mega Man" },
                    new Game { GameId = 10, Name = "Mega Man 2" }
                  }
              }
            );

            context.GameSystems.AddOrUpdate(
             gs => gs.Id,
             new GameSystem
             {
                 Id = 2,
                 SystemName = "Atari 2600",
                 Games = new List<Game> {
                    new Game { GameId = 11, Name = "Pac Man" },
                    new Game { GameId = 12, Name = "Ms. Pac Man" },
                    new Game { GameId = 13, Name = "Frogger" },
                    new Game { GameId = 14, Name = "Q-Bert" },
                    new Game { GameId = 15, Name = "Joust" },
                    new Game { GameId = 16, Name = "Dig Dug" },
                    new Game { GameId = 17, Name = "Centipede" },
                    new Game { GameId = 18, Name = "Asteroids" },
                    new Game { GameId = 19, Name = "Galaga" },
                    new Game { GameId = 20, Name = "Pigs in Space" }
                 }
             }
           );
 context.GameSystems.AddOrUpdate(
  gs => gs.Id,
  new GameSystem
  {
      Id = 3,
      SystemName = "Sega Genesis",
      Games = new List<Game> {
                    new Game { GameId = 21, Name = "Sonic the Hedgehog" },
                    new Game { GameId = 22, Name = "Sonic the Hedgehog 2" },
                    new Game { GameId = 23, Name = "Altered Beast" },
                    new Game { GameId = 24, Name = "Dr. Robotnik's Mean Bean Machine" },
                    new Game { GameId = 25, Name = "Kid Chameleon" },
                    new Game { GameId = 26, Name = "Vectorman" },
                    new Game { GameId = 27, Name = "Jurassic Park" },
                    new Game { GameId = 28, Name = "Mortal Kombat" },
                    new Game { GameId = 29, Name = "Street Fighter 2" },
                    new Game { GameId = 30, Name = "NHL 94" }
      }
  }
);
            context.GameSystems.AddOrUpdate(
  gs => gs.Id,
  new GameSystem
  {
      Id = 4,
      SystemName = "Super Nintendo",
      Games = new List<Game> {
                    new Game { GameId = 31, Name = "Super Mario World" },
                    new Game { GameId = 32, Name = "Donkey Kong Country" },
                    new Game { GameId = 33, Name = "Kirby's Adventure" },
                    new Game { GameId = 34, Name = "Killer Instinct" },
                    new Game { GameId = 35, Name = "Legend of Zelda: A Link to the Past" },
                    new Game { GameId = 36, Name = "Contra III" },
                    new Game { GameId = 37, Name = "Secret of Mana" },
                    new Game { GameId = 38, Name = "Star Fox" },
                    new Game { GameId = 39, Name = "Mega Man X" },
                    new Game { GameId = 40, Name = "Mario Kart" }
      }
  }
);
            context.GameSystems.AddOrUpdate(
gs => gs.Id,
new GameSystem
{
Id = 5,
SystemName = "Sony Playstation",
Games = new List<Game> {
                    new Game { GameId = 41, Name = "Tomb Raider" },
                    new Game { GameId = 42, Name = "Parappa the Rapper" },
                    new Game { GameId = 43, Name = "Rayman" },
                    new Game { GameId = 44, Name = "Crash Bandicoot" },
                    new Game { GameId = 45, Name = "Resident Evil" }
}
}
);
            context.GameSystems.AddOrUpdate(
gs => gs.Id,
new GameSystem
{
Id = 6,
SystemName = "Playstation 2",
Games = new List<Game> {
                    new Game { GameId = 46, Name = "Tony Hawk's Pro Skater" },
                    new Game { GameId = 47, Name = "Metal Gear Solid 3" },
                    new Game { GameId = 48, Name = "Grand Theft Auto 3" },
                    new Game { GameId = 49, Name = "Sly Cooper and the Thievius Raccoonus" },
                    new Game { GameId = 50, Name = "Shadow of the Colossus" }
}
}
);
            context.GameSystems.AddOrUpdate(
gs => gs.Id,
new GameSystem
{
Id = 7,
SystemName = "PS3",
Games = new List<Game> {
                    new Game { GameId = 51, Name = "God of War" },
                    new Game { GameId = 52, Name = "Destiny: The Taken King" },
                    new Game { GameId = 53, Name = "Uncharted" },
                    new Game { GameId = 54, Name = "Assassin's Creed 2" },
                    new Game { GameId = 55, Name = "LittleBigPlanet" }
}
}
);
            context.GameSystems.AddOrUpdate(
gs => gs.Id,
new GameSystem
{
Id = 8,
SystemName = "Nintendo 64",
Games = new List<Game> {
                    new Game { GameId = 56, Name = "Mario Kart 64" },
                    new Game { GameId = 57, Name = "Legend of Zelda: Majora's Mask" },
                    new Game { GameId = 58, Name = "Goldeneye 64" },
                    new Game { GameId = 59, Name = "Super Smash Bros." },
                    new Game { GameId = 60, Name = "Pokemon Stadium" }
}
}
);
            context.GameSystems.AddOrUpdate(
gs => gs.Id,
new GameSystem
{
Id = 9,
SystemName = "Xbox 360",
Games = new List<Game> {
                    new Game { GameId = 61, Name = "Fallout 3" },
                    new Game { GameId = 62, Name = "Halo 2" },
                    new Game { GameId = 63, Name = "Minecraft" },
                    new Game { GameId = 64, Name = "BioShock" },
                    new Game { GameId = 65, Name = "Borderlands 2" }
}
}
);
            context.GameSystems.AddOrUpdate(
gs => gs.Id,
new GameSystem
{
Id = 10,
SystemName = "PC",
Games = new List<Game> {
                    new Game { GameId = 66, Name = "Doom" },
                    new Game { GameId = 67, Name = "Duke Nukem 3D" },
                    new Game { GameId = 68, Name = "World of Warcraft" },
                    new Game { GameId = 69, Name = "Half Life" },
                    new Game { GameId = 70, Name = "Star Wars Battlefront" }
}
}
);
            context.SaveChanges();

        }
    }
}
