using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CricketSimulation
{
    class Player
    {
        private string _Name;

        public string Name
        {
            get { return _Name; }
        }

        public int RunScored { get; set; }
        public bool isOutorNot { get; set; }
        public int BallsPlayed { get; set; }
        public bool IsplayingCurrently { get; set; }
        public bool IsBattingNow { get; set; }
        public Player(string name)
        {
            _Name = name;
            RunScored = 0;
            isOutorNot = false;
            BallsPlayed = 0;
        }

        public void UpdatePlayerScore(Ball currentBall)
        {
            RunScored = RunScored + currentBall.RunsScored;
            isOutorNot = currentBall.IsWicket;
            BallsPlayed++;
        }
    }
}
