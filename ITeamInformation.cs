using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PremierLeague
{
    /// <summary>
    /// Interface for team information.
    /// </summary>
    public interface ITeamInformation
    {
        string Name { get; set; }
        string Stadium { get; set; }
        List<IPlayer> Players { get; set; }

        void AddPlayer(IPlayer player);
        void RemovePlayer(IPlayer player);
        string GetInformation();
    }
}
