using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Footbal_team
{
    public class Goal
    {
        public int Minute { get; set; }
        public Football_Player Scorer { get; set; }

        public Goal(int minute, Football_Player scorer)
        {
            Minute = minute;
            Scorer = scorer;
        }
    }
}
