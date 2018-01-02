using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CircketSimulation;

namespace CricketSimulation
{
    public class ScoreCard : ScoreUpdate
    {
        private int myVar;

        public int MyProperty
        {
            get { return myVar; }
            set { myVar = value; }
        }

        public int OversLeft { get; set; }
        public int Target { get; set; }
        public int WicketsLeft { get; set; }
        public int RunsScored { get; set; }
        public List<Player> Players { get; set; }
        public int RequiredRuns { get; set; }
        public ScoreCard(int oversLeft,int target,int wicketsleft,int runsScored, List<Player> players)
        {
            OversLeft = oversLeft;
            Target = target;
            WicketsLeft = wicketsleft;
            RunsScored = runsScored;
            Players = players;
            RequiredRuns = Target - RunsScored;
        }

        public void updateScore(Ball currentBall)
        {
            RunsScored = RunsScored + currentBall.RunsScored;
            RequiredRuns = RequiredRuns - currentBall.RunsScored;
            if(RequiredRuns < 0)
            {
                RequiredRuns = 0;
            }
            if(currentBall.IsWicket)
            {
                WicketsLeft = WicketsLeft - 1;
            }
        }
        public void updateOver()
        {
            OversLeft = OversLeft - 1;
        }

    }
}
