using System;
using System.Text;

namespace League
{
    class LeagueTable
    {
        LeagueTeam[] leagueTable;

        // Constructor
        public LeagueTable(string leagueName, string[] clubNames)
        {
            leagueTable = new LeagueTeam[clubNames.Length];

            for (int i = 0; i < clubNames.Length; i++)
            {
                leagueTable[i] = new LeagueTeam(clubNames[i]);
            }

        }

        public override string ToString()
        {
            // Use a stringbuilder to avoid creating many separate strings on the heap
            // Initialise it to show the table column labels
            StringBuilder fullTable = new StringBuilder("Pos " + LeagueTeam.TeamColumnLabels + "\n");

            int position = 1;
            foreach (LeagueTeam team in leagueTable )
            {
                fullTable.Append($"{position,3} {team}\n");
                position++;
            }

            return fullTable.ToString();
        }

        public LeagueTeam GetTeam(string teamName)
        {
            LeagueTeam found = null;
            int count = 0;
            foreach (LeagueTeam team in leagueTable)
            {
                if (team.Club.StartsWith(teamName))
                {
                    found = team;
                    count++;
                }
            }
            if (count == 1)
                return found;
            else
                return null;
        }

        public bool AddMatchResult(LeagueTeam homeTeam, int homeGoals, LeagueTeam awayTeam, int awayGoals)
        {
            bool resultAdded = false;

            if (homeTeam != awayTeam && homeGoals >= 0  && awayGoals >= 0)
            {
                homeTeam.AddTeamResult(homeGoals, awayGoals);
                awayTeam.AddTeamResult(awayGoals, homeGoals);
                resultAdded = true;
            }
            return resultAdded;
            
        }   
    }
}
