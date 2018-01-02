using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CricketSimulation
{
    public class Ball
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

        public void updateScore(int runs,bool isWicket = false)
        {
            if(isWicket == false)
                _RunsScored = runs;
            else
            {
                _RunsScored = runs;
                _IsWicket = true;
            }

        }
        
    }
}
