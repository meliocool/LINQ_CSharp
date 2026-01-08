namespace LinqEnjoyer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Game> games = new List<Game>
            {
                new Game { Title = "Elden Ring", Genre = "RPG", ReleaseYear = 2022, Rating = 9.8, Price = 60 },
                new Game { Title = "The Witcher 3", Genre = "RPG", ReleaseYear = 2015, Rating = 9.9, Price = 40 },
                new Game { Title = "Hollow Knight", Genre = "Metroidvania", ReleaseYear = 2017, Rating = 9.6, Price = 15 },
                new Game { Title = "FIFA 24", Genre = "Sports", ReleaseYear = 2023, Rating = 6.0, Price = 70 },
                new Game { Title = "Cyberpunk 2077", Genre = "RPG", ReleaseYear = 2020, Rating = 8.5, Price = 60 },
                new Game { Title = "Minecraft", Genre = "Sandbox", ReleaseYear = 2011, Rating = 9.3, Price = 30 },
                new Game { Title = "Stardew Valley", Genre = "Simulation", ReleaseYear = 2016, Rating = 9.8, Price = 15 },
                new Game { Title = "Gollum", Genre = "Action", ReleaseYear = 2023, Rating = 3.5, Price = 50 },
                new Game { Title = "Overwatch 2", Genre = "Shooter", ReleaseYear = 2022, Rating = 7.5, Price = 0 },
                new Game { Title = "Hades", Genre = "Roguelike", ReleaseYear = 2020, Rating = 9.7, Price = 25 },
                new Game { Title = "Dota 2", Genre = "MOBA", ReleaseYear = 2013, Rating = 8.8, Price = 0 },
                new Game { Title = "Red Dead Redemption 2", Genre = "Action", ReleaseYear = 2018, Rating = 9.9, Price = 60 },
                new Game { Title = "Terraria", Genre = "Sandbox", ReleaseYear = 2011, Rating = 9.6, Price = 10 },
                new Game { Title = "Vampire Survivors", Genre = "Roguelike", ReleaseYear = 2022, Rating = 9.8, Price = 5 },
                new Game { Title = "Anthem", Genre = "Shooter", ReleaseYear = 2019, Rating = 5.5, Price = 20 }
            };

            // LINQ - Select
            var gameTitles = games.Select(g => g.Title);
            //foreach (var title in gameTitles)
            //{
            //    Console.WriteLine(title);
            //}

            // LINQ - Where
            var rpgGames = games.Where(g => g.Genre == "RPG");
            // Helper.ForEachLoop(rpgGames);

            // LINQ - Any
            var gamesAfterCovid = games.Any(g => g.ReleaseYear > 2020);
            var freeGame = games.Any(g => g.Price == 0);
            // Console.WriteLine($"Are there any games releasing after Covid? {gamesAfterCovid}");
            // Console.WriteLine($"Are there any free games? {freeGame}");

            // LINQ - OrderBy
            var oldestGameToNewest = games.OrderBy(g => g.ReleaseYear);
            foreach(var g in oldestGameToNewest)
            {
                // Console.WriteLine($"{g.Title} - {g.ReleaseYear}");
            }

            // LINQ - Count
            var gamesBelowSeven = games.Count(g => g.Rating < 7.0);
            // Console.WriteLine($"Number of games below 7.0 rating: {gamesBelowSeven}");

            // LINQ - Average
            var averagePrice = games.Average(g => g.Price);
            var averageRating = games.Average(g => g.Rating);
            // Console.WriteLine($"Average price of games: {averagePrice}");
            // Console.WriteLine($"Average rating of games: {averageRating}");

            // LINQ - Max
            var highestPrice = games.Max(g => g.Price);
            var mostExpensiveGame = games.First(g => g.Price == highestPrice);
            // Console.WriteLine($"The Most Expensive Game: {mostExpensiveGame.Title} - {mostExpensiveGame.Price}");

            // LINQ - Grouping (GroupBy)
            var gamesByGenre = games.GroupBy(g => g.Genre);
            foreach(var group in gamesByGenre)
            {
                // Console.WriteLine($"Genre -- {group.Key} --");
                foreach(var game in group)
                {
                    // Console.WriteLine($"{game.Title} - {game.ReleaseYear}");
                }
                // Console.WriteLine();
            }

            // LINQ - FirstOrDefault
            var hadesGame = games.FirstOrDefault(g => g.Title == "Hades");
            if(hadesGame == null)
            {
                // Console.WriteLine("Hades does not exist!");
            }
            //Console.WriteLine(hadesGame?.Title);

            // LINQ - Chaining
            var actionGames = games.Where(g => g.Genre == "Action").OrderByDescending(g => g.Rating);
            foreach(var g in actionGames)
            {
                // Console.WriteLine($"{g.Title} - {g.Rating}");
            }
            var steamSaleQuery = games.Where(g => g.Rating > 9.0 && g.Price < 30);
            // Console.WriteLine("-- STEAM SALE --");
            foreach(var g in steamSaleQuery)
            {
                // Console.WriteLine($"{g.Title} - {g.Rating} - {g.Price}");
            }
        }
    }
}
