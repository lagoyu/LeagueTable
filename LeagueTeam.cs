using System;

namespace League
{
    class LeagueTeam
    {
        public string Club {get; private set;}
        public const int MaxNameLength = 24;
        public int Played {get; private set;} = 0;
        public int Won {get; private set;} = 0;
        public int Drawn {get; private set;} = 0;
        public int Lost {get; private set;} = 0;
        public int For {get; private set;} = 0;
        public int Against {get; private set;} = 0;
        public int PointsDeducted { get; private set; } = 0;

        // GoalDifference is a calculated property
        public int GoalDifference
        {
            get
            {
                return For - Against;
            }
        }
        // A more compact way of writing a calculated property
        public int Points { get { return 3 * Won + Drawn - PointsDeducted; } }

        // Constructor
        public LeagueTeam(string name)
        {
            // Limit to no more than MaxNameLength
            Club = name.Substring(0, Math.Min(name.Length, MaxNameLength));
        }

        //Overriding ToString() changes its result from just "League.LeagueTeam"
        public override string ToString()
        {
            // separate the fields using an interpolated string
            // numbers indicate required width for right justified numbers
            // Club name is left justified.
            // https://learn.microsoft.com/en-us/dotnet/csharp/tutorials/string-interpolation
            return $"{Club,-MaxNameLength} {Played,3} " +
                    $"{Won,3} {Drawn,3} {Lost,3} " +
                    $"{For,3} {Against,3} {GoalDifference,3} " +
                    $"{Points,3}";
        }

        public void AddMatchResult(int OurGoals, int TheirGoals)
        {
            if (OurGoals==TheirGoals)
            {
                Drawn++;
            }
            else if ( OurGoals>TheirGoals)
            {
                Won++;
            }
            else
            {
                Lost++;
            }
            For = For + OurGoals;
            Against = Against + TheirGoals;
        }

        // A string for use as a table header corresponding to the layout of ToString
        public static readonly string TeamColumnLabels =
                    $"{" ",-MaxNameLength} {"MP",3} " +
                    $"{"W",3} {"D",3} {"L",3} " +
                    $"{"GF",3} {"GA",3} {"GD",3} " +
                    $"{"Pts",3}";

    }
}
