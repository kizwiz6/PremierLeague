using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PremierLeague
{
    /// <summary>
    /// Defines methods for retrieving player data. This interface should include a GetName() method, a GetPosition() method, and a GetTeam() method.
    /// </summary>
    public interface IPlayer
    {
        string GetName();
        string GetPosition();
        FootballTeam GetTeam();
    }
}
