using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PremierLeague
{
    /// <summary>
    /// Single Responsibility Principle: This class has only one responsibility, which is to represent a Premier League football team.
    /// </summary>
    abstract class FootballTeam
    {
        public string Name { get; set; }
        public string Stadium { get; set; }
        public string Manager { get; set; }
        public int Wins { get; set; }
        public int Losses { get; set; }
        public int Draws { get; set; }

        public FootballTeam(string name, string stadium)
        {
            Name = name;
            Stadium = stadium;
        }

        //public FootballTeam(string name, int wins, int losses, int draws)
        //{
        //    Name = name;
        //    Wins = wins;
        //    Losses = losses;
        //    Draws = draws;
        //}

        // Calculate the team's points based on their wins, losses, and draws
        public int CalculatePoints()
        {
            return (Wins * 3) + Draws;
        }
    }
}
