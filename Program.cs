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
            LeagueTeam testTeam = new LeagueTeam("QPR");

            // We can get access individual properties
            Console.WriteLine($"{testTeam.Club} have {testTeam.Points} points");

            // But we can't set any of these properties - uncomment to try
            // testTeam.Points += 10;

            Console.WriteLine(LeagueTeam.TeamColumnLabels);
            // Make use of the ToString() override
            Console.WriteLine(testTeam);

            //Console.WriteLine();

            // Create a shortened Top 5 Premiership testTable
            string[] clubNames = { "Liverpool", "Manchester City", "Arsenal", "Aston Villa", "Tottenham Hotspur" };
            LeagueTable testTable = new LeagueTable("Premiership", clubNames);

            // Display it using its overridden ToString()
            Console.WriteLine(table.ToString());

            // Enter a match result
            bool success = table.AddMatchResult(table.GetTeam("Liverpool"), 3, table.GetTeam("Manchester City"), 2);

            // Display updated Table
            Console.WriteLine(table.ToString());

            Console.ReadKey();
        }
    }
}
