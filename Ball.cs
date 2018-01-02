using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CricketSimulation
{
    class Ball
    {
        private int _RunsScored;
        public int RunsScored
        {
            get { return _RunsScored; }
        }
        private bool _IsWicket;
        public bool IsWicket
        {
            get { return _IsWicket; }
        }
       
        public string Playedby { get; set; }

        public Ball(string playedBy)
        {
            _RunsScored = 0;
            _IsWicket = false;
            Playedby = playedBy;
        }

        public void Bowl()
        {
            Random rand = new Random();
            double score = rand.NextDouble();
            List<double> playerBattionProbality = ProbabilityTable.table[Playedby];
            List<double> cumulativeProbalityList = new List<double>();
            for (int i = 0; i < playerBattionProbality.Count; i++)
            {
                double Cumulative = 0;
                for (int j = 0; j <= i; j++)
                {
                    Cumulative = Cumulative + playerBattionProbality[j];
                }
                cumulativeProbalityList.Add(Cumulative);
            }
            if(score < cumulativeProbalityList[0])
            {
                this._RunsScored =0;
            }else if(score >= cumulativeProbalityList[0] && score < cumulativeProbalityList[1])
            {
                this._RunsScored = 1;
            }else if(score >= cumulativeProbalityList[1] && score < cumulativeProbalityList[2])
            {
                this._RunsScored = 2;
            }else if(score >= cumulativeProbalityList[2] && score < cumulativeProbalityList[3])
            {
                this._RunsScored = 3;
            }else if(score >= cumulativeProbalityList[3] && score < cumulativeProbalityList[4])
            {
                this._RunsScored = 4;
            }else if (score >= cumulativeProbalityList[4] && score < cumulativeProbalityList[5])
            {
                this._RunsScored = 5;
            }else if (score >= cumulativeProbalityList[5] && score < cumulativeProbalityList[6])
            {
                this._RunsScored = 6;
            }
            else
            {
                this._IsWicket = true;
                this._RunsScored = 0;
                return;
            }
           
        }
        
    }
}
