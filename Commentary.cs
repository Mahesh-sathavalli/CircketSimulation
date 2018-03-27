using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CricketSimulation
{
    public class Commentary
    {
        private const int _OversMatch = 4;
        public string printMessage;
        public void commentarybyBall(Ball ball,Over over)
        {
            int overNumber = over.overNumber;
            int ballNumber = over.Balls.Count;
            string player = ball.Playedby;
            int runScored = ball.RunsScored;
            string runsScoredPlural = runScored == 1 || runScored == 0 ? runScored.ToString() + " run" : runScored.ToString() + " runs";
            if(ball.IsWicket)
            {
                printMessage = string.Format("{0}.{1} Its a Wicket !!! {2} got out ", overNumber, ballNumber, player);
                Console.WriteLine(printMessage);
            }
            else
            {
                printMessage = string.Format("{0}.{1} {2} scores {3}", overNumber, ballNumber, player, runsScoredPlural);
               Console.WriteLine(printMessage);
            }
                
        }
        public void CommentaryBymatchifWon(ScoreCard score,List<Over> overs)
        {
            int remainingBalls = (_OversMatch * 6) - GetNumberofBallsRemaining(overs);
            printMessage = string.Format("Lengaburu won by {0} and {1} remaining", TakecareofPlurals(score.WicketsLeft, "wickets"), TakecareofPlurals(remainingBalls, "balls"));
            Console.WriteLine(printMessage);
            if(score.Teams != null)
                  DisplayPlayerScores(score.Teams[0].Players);
        }

        private int GetNumberofBallsRemaining(List<Over> overs)
        {
            int count = overs.Sum(x => x.Balls.Count());
            return count;
        }

        private void DisplayPlayerScores(List<Player> players)
        {
            foreach (Player player in players)
            {
                string Name = player.Name;
                int runsScored = player.RunScored;
                int ballsplayed = player.BallsPlayed;
                Console.WriteLine("{0} - {1}({2})", Name, runsScored, TakecareofPlurals(ballsplayed, "balls"));
            }
        }

        private string TakecareofPlurals(int number,string byWhat)
        {
            if(byWhat == "run")
            {
                return number == 1 || number == 0 ? number.ToString() + " run" : number.ToString() + " runs";
            }
            else if(byWhat == "wickets")
            {
                return number == 1 || number == 0 ? number.ToString() + " wicket" : number.ToString() + " wickets";
            }
            else
            {
                return number == 1 || number == 0 ? number.ToString() + " ball" : number.ToString() + " balls";
            }
            
        }
        
        public void CommentaryBymatchifLost(ScoreCard score,List<Over> overs)
        {
            printMessage = string.Format("Lengburu lost by {0}", TakecareofPlurals(score.RequiredRuns - 1, "run"));
            Console.WriteLine(printMessage);
            if(score.Teams != null)
            {
                DisplayPlayerScores(score.Teams[0].Players);
            }
            
        }
        public void CommentaryBymatchIfTied(ScoreCard score,List<Over> overs)
        {
            printMessage = string.Format("Match is Tied.Score is {0}", TakecareofPlurals(score.RunsScored, "run"));
            Console.WriteLine(printMessage);
            if (score.Teams != null)
            {
                DisplayPlayerScores(score.Teams[0].Players);
            }
        }
        public void CommentaryAfterWicket(Player player)
        {
            string Name = player.Name;
            int runsScored = player.RunScored;
            int ballsPlayed = player.BallsPlayed;
            printMessage = string.Format("{0} {1}({2})", Name, runsScored, ballsPlayed);
            Console.WriteLine(printMessage);
        }
        public void CommentarybyOver(ScoreCard scoreCard, List<Over> over)
        {
            Console.WriteLine("After completion of over {0}. The score is {1}",over.Count,scoreCard.RunsScored);
            Console.WriteLine("Tagert {0}, Runs Required {1}, Remaining balls {2}",scoreCard.Target,scoreCard.RequiredRuns, (_OversMatch * 6) - GetNumberofBallsRemaining(over));
            Console.WriteLine("------------------------------------");
        }
    }
}
