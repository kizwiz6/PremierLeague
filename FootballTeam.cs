using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PremierLeague
{
    abstract class FootballTeam
    {
        public string Name { get; set; }
        public string Stadium { get; set; }

        public FootballTeam(string name, string stadium)
        {
            Name = name;
            Stadium = stadium;
        }
    }
}
