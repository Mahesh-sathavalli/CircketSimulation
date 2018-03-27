using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CricketSimulation;

namespace CircketSimulation
{
    public class Team
    {
        private string _TeamName;

        public string TeamName
        {
            get { return _TeamName; }
            set { _TeamName = value; }
        }

        private List<Player> _players;
        public List<Player> Players
        {
            get { return _players; }
            set { _players = value; }
        }
        
        
        public Team(string Name)
        {
            Players = new List<Player>();
            Players.AddRange(PlayerList.ListOfPlayers["Lengaburu"]);
            TeamName = Name;
        }


    }
}
