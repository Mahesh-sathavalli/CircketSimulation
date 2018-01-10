using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CircketSimulation;

namespace CricketSimulation
{
    public class Player : ScoreUpdate
    {
        private string _Name;
        public string Name
        {
            get { return _Name; }
        }

        private int _RunScored;
        public int RunScored
        {
            get { return _RunScored; }   
        }

        private bool _isOutorNot;
        public bool isOutorNot
        {
            get { return _isOutorNot; }
        }

        private int _BallsPlayed;
        public int BallsPlayed
        {
            get { return _BallsPlayed; }
        }
       
        public bool IsplayingCurrently { get; set; }
        public bool IsBattingNow { get; set; }
        public Player(string name)
        {
            _Name = name;
            _RunScored = 0;
            _isOutorNot = false;
            _BallsPlayed = 0;
        }

        public void updateScore(Ball currentBall)
        {
            _RunScored = _RunScored + currentBall.RunsScored;
            _isOutorNot = currentBall.IsWicket;
            _BallsPlayed++;
        }

        public void PlayBall(Ball ball)
        {
            Random rand = new Random();
            double score = rand.NextDouble();
            List<double> playerBattingProbality = ProbabilityTable.table[this.Name];
            List<double> cumulativeProbalityList = new List<double>();
            for (int i = 0; i < playerBattingProbality.Count; i++)
            {
                double Cumulative = 0;
                for (int j = 0; j <= i; j++)
                {
                    Cumulative = Cumulative + playerBattingProbality[j];
                }
                cumulativeProbalityList.Add(Cumulative);
            }
            if (score < cumulativeProbalityList[0])
            {
                ball.updateScore(0);
            }
            else if (score >= cumulativeProbalityList[0] && score < cumulativeProbalityList[1])
            {
                ball.updateScore(1);
            }
            else if (score >= cumulativeProbalityList[1] && score < cumulativeProbalityList[2])
            {
                ball.updateScore(2);
            }
            else if (score >= cumulativeProbalityList[2] && score < cumulativeProbalityList[3])
            {
                ball.updateScore(3);
            }
            else if (score >= cumulativeProbalityList[3] && score < cumulativeProbalityList[4])
            {
                ball.updateScore(4);
            }
            else if (score >= cumulativeProbalityList[4] && score < cumulativeProbalityList[5])
            {
                ball.updateScore(5);
            }
            else if (score >= cumulativeProbalityList[5] && score < cumulativeProbalityList[6])
            {
                ball.updateScore(6);
            }
            else
            {
                ball.updateScore(0, true);
                return;
            }
        }
    }
}
