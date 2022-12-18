using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PremierLeague
{
    /// <summary>
    /// Class to display team information.
    /// </summary>
    class TeamDisplay
    {
        private List<ITeamInformation> _teams;

        /// <summary>
        /// Takes a list of ITeamInformation objects as a constructor parameter.
        /// </summary>
        /// <param name="teams"></param>
        public TeamDisplay(List<ITeamInformation> teams)
        {
            _teams = teams;
        }

        /// <summary>
        /// Displays the information for each team.
        /// </summary>
        public void ShowInformation()
        {
            foreach (var team in _teams)
            {
                Console.WriteLine(team.GetInformation());
            }
        }
    }
}
