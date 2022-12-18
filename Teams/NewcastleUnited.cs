using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PremierLeague.Teams
{
    class NewcastleUnited : FootballTeam, ITeamInformation, IStandings
    {
        public int Points { get; set; }

        public NewcastleUnited() : base("Newcastle United", "St. James' Park")
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
