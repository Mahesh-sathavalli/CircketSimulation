using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CricketSimulation
{
    public static class ProbabilityTable
    {
        public static Dictionary<string, List<double>> table;
        
        static ProbabilityTable()
        {
            table = new Dictionary<string, List<double>>();
            table.Add("Kirat Boli", new List<double>(new double[] { 0.05, 0.3, 0.25, 0.10, 0.15, 0.01, 0.09, 0.05 }));
            table.Add("N.S  Nodhi", new List<double>(new double[] { 0.10, 0.4, 0.2, 0.05, 0.10, 0.01, 0.04, 0.10 }));
            table.Add("R Rumarah", new List<double>(new double[] { 0.20, 0.3, 0.15, 0.05, 0.05, 0.01, 0.04, 0.20 }));
            table.Add("Shashi Henra", new List<double>(new double[] { 0.30, 0.25, 0.05, 0.0, 0.05, 0.01, 0.04, 0.30 }));
        }
    }
}
