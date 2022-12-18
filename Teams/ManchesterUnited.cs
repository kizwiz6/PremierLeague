using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PremierLeague.Teams
{
    class ManchesterUnited : FootballTeam, ITeamInformation, IStandings
    {
        public int Points { get; set; }
        public ManchesterUnited() : base("Manchester United", "Old Trafford")
        {
        }

        public string GetInformation()
        {
            return $"{Name} play at {Stadium}";
        }

        public string GetStandings()
        {
            return $"{Name} have {Points} points in the Premiership.";
        }
    }
}
