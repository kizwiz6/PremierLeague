using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PremierLeague.Teams
{
    /// <summary>
    /// This class derives from the FootballTeam base class and implements the ITeamInformation interface to make the Permiership football team Arsenal.
    /// </summary>
    class Southampton : FootballTeam, ITeamInformation, IStandings
    {
        public int Points { get; set; }

        /// <summary>
        /// Constructor that sets the 'Name' and 'Stadium' properties inherited from the base class, and it implements the 'GetInformation' method from the interface.
        /// </summary>
        public Southampton() : base("Southampton", "Saint Mary's Stadium")
        {

        }

        /// <summary>
        /// Returns a string with the team's name and stadium.
        /// </summary>
        /// <returns></returns>
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
