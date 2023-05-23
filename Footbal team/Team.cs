using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Footbal_team
{
    public class Team
    {
        public Coach Coach { get; set; }
        public List<Football_Player> Players { get; set; }

        public double AverageAge
        {
            get
            {
                int totalAge = 0;

                foreach (Football_Player player in Players)
                {
                    totalAge += player.Age;
                }

                return (double)totalAge / Players.Count;
            }
        }

        public Team(Coach coach, List<Football_Player> players)
        {
            Coach = coach;
            Players = players;
        }
    }
}

