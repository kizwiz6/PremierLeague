using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PremierLeague.Teams
{
    class TottenhamHotspur : FootballTeam, ITeamInformation, IStandings
    {
        public int Points { get; set; }

        public TottenhamHotspur() : base("Tottenham Hotspur", "Tottenham Hotspur Stadium")
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
