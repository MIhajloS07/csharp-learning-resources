using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 
using linqGame;

namespace linq_vezbanje_c_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var games = new List<Game>
            {
                new Game {Title = "Elden Ring", Genre = "RPG", Year = 2022, Rating = 9.8, Price = 45},
                new Game {Title = "Super Mario", Genre = "Adventure", Year = 1970, Rating = 9.5, Price = 12},
                new Game {Title = "Witcher 3", Genre = "RPG", Year = 2015, Rating = 9.7, Price = 35},
                new Game {Title = "Roblox", Genre = "Adventure", Year = 2006, Rating = 9.2, Price = 0},
                new Game {Title = "Red Dead Redemption 2", Genre = "Adventure RPG", Year = 2018, Rating = 9.9, Price = 48},
                new Game {Title = "God of War", Genre = "Adventure", Year = 2018, Rating = 9.3, Price = 38}
            };

            var RpgGames = games.Where(g => g.Genre == "RPG");
            Console.WriteLine("RPG games :");
            foreach (var rpgGame in RpgGames)           
                Console.WriteLine($"{rpgGame.Title} | {rpgGame.Rating}");
        
            Console.WriteLine();

            var AdventureGames = games.Where(g => g.Genre == "Adventure");
            Console.WriteLine("Adventure games: ");
            foreach(var adventureGame in AdventureGames)   
                Console.WriteLine($"{adventureGame.Title} | {adventureGame.Rating}");

            Console.WriteLine();

            var ModernGames = games.Where(g => g.Year > 2017);
            Console.WriteLine("Modern Games: ");
            foreach(var modernGame in ModernGames)
                Console.WriteLine($"{modernGame.Title} | {modernGame.Rating}");

            Console.WriteLine();

            var HighestRatingGame = games.OrderByDescending(g => g.Rating).First();
            Console.WriteLine($"Game with highest rating is {HighestRatingGame.Title} with rating: {HighestRatingGame.Rating}");

            var gamesWithRatingAbove10 = games.Where(g => g.Rating > 10).ToList();
            foreach (var ratings in gamesWithRatingAbove10)
                Console.WriteLine($"{ratings.Title} | {ratings.Rating}");

            var LowestRatingGame = games.OrderBy(g => g.Rating).First();
            Console.WriteLine($"Game with lowest rating is {LowestRatingGame.Title} with rating: {LowestRatingGame.Rating}");

            var AveragePrice = games.Average(g => g.Price);
            Console.WriteLine($"Average price of all games is {Math.Round(AveragePrice,1)}");

            Console.WriteLine();

            Console.WriteLine("Sorted games: ");
            var SortGames = games
                .OrderBy(g => g.Year)
                .Distinct();
            foreach(var game in SortGames) 
                Console.WriteLine($"{game.Title} | {game.Year} | {game.Price}");      
        }
    }
}
