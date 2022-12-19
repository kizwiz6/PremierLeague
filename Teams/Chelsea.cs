using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PremierLeague.Teams
{
    internal class Chelsea : FootballTeam, ITeamInformation, IStandings
    {
        public int Points { get; set; }
        List<IPlayer> ITeamInformation.Players { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public Chelsea() : base("Chelsea", "Stamford Bridge")
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
