using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PremierLeague
{
    /// <summary>
    /// Represents a soccer match between two teams. This class should have properties for the home team, away team, and the score of the match. It should also have a method for determining the winner of the match. Instead of directly depending on the Team class, the Match class should depend on an abstract ITeam interface.
    /// This Match class has properties for the home team, away team, and the score of the match. It also has a constructor that takes these values as arguments, and a GetWinner() method that determines the winning team based on the score of the match. By depending on the ITeam interface rather than the Team class itself, the Match class is more flexible and can work with any class that implements the ITeam interface.
    /// </summary>
    public class Match
    {
        public ITeamInformation HomeTeam { get; set; }
        public ITeamInformation AwayTeam { get; set; }
        public int HomeTeamScore { get; set; }
        public int AwayTeamScore { get; set; }

        public Match(ITeamInformation homeTeam, ITeamInformation awayTeam, int homeTeamScore, int awayTeamScore)
        {
            HomeTeam = homeTeam;
            AwayTeam = awayTeam;
            HomeTeamScore = homeTeamScore;
            AwayTeamScore = awayTeamScore;
        }

        public ITeamInformation GetWinner()
        {
            if (HomeTeamScore > AwayTeamScore)
            {
                return HomeTeam;
            }
            else if (AwayTeamScore > HomeTeamScore)
            {
                return AwayTeam;
            }
            else
            {
                return null; // match was a draw
            }
        }
    }
}
