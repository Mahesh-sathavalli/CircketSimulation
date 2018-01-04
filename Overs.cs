using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CircketSimulation;

namespace CricketSimulation
{
    public class Over : ScoreUpdate
    {
        private const int OddNumberScored = 1;
        public Bowler Bowler { get; set; }
        public List<Ball> Balls { get; set; }
        public int RunScored { get; set; }
        public int overNumber { get; set; }
        public Over()
        {
            this.Bowler = new Bowler();
            Balls = new List<Ball>();
            RunScored = 0;
            overNumber = 0;
        }
        public bool ControlPlayerBetweenWickets(Ball newball)
        {
            Ball latestBall = newball;
            if(latestBall.RunsScored % 2 == OddNumberScored)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public void updateScore(Ball currentBall)
        {
            Balls.Add(currentBall);
            RunScored = RunScored + currentBall.RunsScored;
        }
    }
}
