using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CricketSimulation;

namespace CircketSimulation
{
    public class Bowler
    {
        public string Name { get; set; }
        private Ball ball { get; set; }
        public Bowler(string Name = "")
        {
            this.Name = Name;
        }

        public void Bowl(ref Player playedby,Ball ball)
        { 
            playedby.PlayBall(ball);  
        }
    }
}
