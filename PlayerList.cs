using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CricketSimulation;

namespace CircketSimulation
{
    static class PlayerList
    {
        public static Dictionary<string,List<Player>> ListOfPlayers = new Dictionary<string, List<Player>>();
        static PlayerList()
        {
            List<Player> players = new List<Player>();
            players.Add(new Player("Kirat Boli"));
            players.Add(new Player("N.S  Nodhi"));
            players.Add(new Player("R Rumarah"));
            players.Add(new Player("Shashi Henra"));
            ListOfPlayers.Add("Lengaburu", players);
        }
    }
}
