using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PremierLeague
{
    /// <summary>
    /// Player class that implements the IPlayer interface. This class should have properties for the player's name, position, and team, as well as a constructor that takes these values as arguments. It should also implement the methods defined in the IPlayer interface.
    /// </summary>
    public class Player : IPlayer
    {
        public string Name { get; set; }
        public string Position { get; set; }
        public FootballTeam Team { get; set; }

        public Player(string name, string position, FootballTeam team)
        {
            Name = name;
            Position = position;
            Team = team;
        }

        public string GetName()
        {
            return Name;
        }

        public string GetPosition()
        {
            return Position;
        }

        FootballTeam IPlayer.GetTeam()
        {
            return Team;
        }
    }
}
