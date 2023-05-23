using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Footbal_team
{
    public class Football_Player : Person
    {
        public int Number { get; set; }
        public double Height { get; set; }

        public Football_Player(int number, double height, string name, int age) : base(name, age)
        {
            this.Number = number;
            this.Height = height;
        }

        
    }
}
