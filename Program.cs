using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace League
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Use constructor to make a single object
            LeagueTeam favouriteTeam = new LeagueTeam("QPR");

            // We can get access individual properties
            Console.WriteLine($"{favouriteTeam.Club} have {favouriteTeam.Points} points");

            // But we can't set any of these properties - uncomment to try
            // favouriteTeam.Points += 10;

            Console.WriteLine(LeagueTeam.TeamColumnLabels);
            // Make use of the ToString() override
            Console.WriteLine(favouriteTeam);

            Console.WriteLine();

            // Create a shortened Top 5 Premiership table
            string[] clubNames = { "Liverpool", "Manchester City", "Arsenal", "Aston Villa", "Tottenham Hotspur"};
            LeagueTable table = new LeagueTable("Premiership", clubNames);

            // Display it using its overridden ToString()
            Console.WriteLine(table.ToString());
            Console.ReadKey();
        }
    }
}
