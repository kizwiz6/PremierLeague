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
    class Everton : FootballTeam, ITeamInformation, IStandings
    {
        public int Points { get; set; }
        List<IPlayer> ITeamInformation.Players { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        /// <summary>
        /// Constructor that sets the 'Name' and 'Stadium' properties inherited from the base class, and it implements the 'GetInformation' method from the interface.
        /// </summary>
        public Everton() : base("Everton", "Goodison Park")
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

        public void AddPlayer(IPlayer player)
        {
            throw new NotImplementedException();
        }

        public void RemovePlayer(IPlayer player)
        {
            throw new NotImplementedException();
        }
    }
}
