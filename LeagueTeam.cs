using System;

namespace League
{
    class LeagueTeam
    {
        public string Club { get; }
        public const int MaxNameLength = 24;
        public int Played { get; } = 0;
        public int Won { get; } = 0;
        public int Drawn { get; } = 0;
        public int Lost { get; } = 0;
        public int For { get; } = 0;
        public int Against { get; } = 0;
        private int PointsDeducted { get; set; } = 0;

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

        // A string for use as a table header corresponding to the layout of ToString
        public static readonly string TeamColumnLabels =
                    $"{" ",-MaxNameLength} {"MP",3} " +
                    $"{"W",3} {"D",3} {"L",3} " +
                    $"{"GF",3} {"GA",3} {"GD",3} " +
                    $"{"Pts",3}";

    }
}
