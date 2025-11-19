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
            Console.WriteLine(testTable);

            // Enter a match result
            LeagueTeam homeTeam = testTable.GetTeam("Liverpool");
            LeagueTeam awayTeam = testTable.GetTeam("Manchester City");
            if (null != homeTeam && null != awayTeam)
            {
                bool success = testTable.AddMatchResult(homeTeam, 3, awayTeam, 2);
            }

            // Display updated Table
            Console.WriteLine(testTable);

            Console.ReadKey();
        }
    }
}
