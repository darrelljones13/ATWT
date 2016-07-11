<Query Kind="Statements">
  <Connection>
    <ID>bf09fbfe-3c16-4b1b-b0e3-4720eda83a24</ID>
    <Persist>true</Persist>
    <Server>(LocalDb)\MSSQLLocalDB</Server>
    <Database>GamerLinqDemoApp</Database>
    <ShowServer>true</ShowServer>
  </Connection>
</Query>

//Select
	//GameSystems.Select(gs => gs.SystemName == "Sega Genesis").Dump();

//Where (Single)

//FirstOrDefault
	//Games.FirstOrDefault( g => g.Name.Contains("Mario")).Dump();

//Where (Collection)

	//Games that have Mario in the Title
		//Games.Where(g => g.Name.Contains("Mario")).Dump();
		
	//Characters that aren't human	
		//Characters.Where(c => !c.IsHuman).Dump();
	
//Any

	//Games.Any(g => g.Name.Equals("Goldeneye 64")).Dump();
	
	//Games.Any(g => g.Name.Equals("Cheese Time")).Dump();

//SelectMany

	//Games.SelectMany(g => g.Characters).Where(g => g.GameId == 2).Dump();
	
	//Games.SelectMany(g => g.Characters).Where(g => g.Name.Contains("Pac")).Dump();


//OrderBy

	//Characters.OrderBy (c => c.Name)

	//GameSystems.OrderBy (gs => gs.SystemName)

//GroupBy
//	 var groupedCharacters = Characters.GroupBy(c => c.GameId, c => c.Name, (key, val) => new
//            {
//                GameId = key,
//                Characters = val.ToList()
//            });
//
//            foreach (var game in groupedCharacters)
//            {
//                Console.WriteLine(game.Characters);
//            }

// Method Chaining

	//Multi-Ordering
		//Characters.OrderBy(c => c.Birthday).ThenBy(c => c.Game.Name).Dump();

	//Get Related Games
		//GameSystems.Where (gs => gs.Id == 3).SelectMany(gs => gs.GameSystemGames).Dump();

	//Get Human Characters over 30, Order by birthday
		//	DateTime thirtyYearsAgo = DateTime.Today.AddYears(-30);
		//	Characters.Where(c => c.IsHuman && c.Birthday < thirtyYearsAgo ).OrderBy(c => c.Birthday).Dump();
	

//Join
	//Retrieve all characters from a game system
	
//	var query = from system in GameSystems
//                      join game in Games
//                      on system.Id equals game.GameSystem_Id
//						join character in Characters
//						on game.GameId equals character.GameId
//                        select new
//                        {
//							character.Id,
//							character.Name,
//                            system.SystemName
//                        };
//						
//						
//	query.OrderBy(c => c.SystemName).Dump();
	