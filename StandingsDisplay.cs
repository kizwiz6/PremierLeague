using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PremierLeague
{
    /// <summary>
    /// This class works in a similar way to the TeamDisplay class, but it uses the GetStandings method to display the standings for each team.
    /// </summary>
    class StandingsDisplay
    {
        private List<IStandings> _teams;

        public StandingsDisplay(List<IStandings> teams)
        {
            _teams = teams;
        }

        public void ShowStandings()
        {
            foreach (var team in _teams)
            {
                Console.WriteLine(team.GetStandings());
            }
        }
    }
}
