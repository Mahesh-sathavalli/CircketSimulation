using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CricketSimulation
{
    class Over
    {
        public List<Ball> Balls { get; set; }
        public int RunScored { get; set; }
        public int overNumber { get; set; }
        public Over()
        {
            Balls = new List<Ball>();
            RunScored = 0;
            overNumber = 0;
        }
        public bool ControlPlayerBetweenWickets(Ball newball)
        {
            Ball latestBall = newball;
            if(latestBall.RunsScored == 1 || latestBall.RunsScored == 3 || latestBall.RunsScored == 5)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        public void UpdateOverScoreAddBall(Ball currentBall)
        {
            Balls.Add(currentBall);
            RunScored = RunScored + currentBall.RunsScored;   
        }
    }
}
