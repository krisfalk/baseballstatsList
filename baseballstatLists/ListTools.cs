using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baseballstatLists
{
    class ListTools
    {
        List<string> names;
        List<double> stats;

        public ListTools()
        {
            names = new List<string>();
            names.Add("At Bats");
            names.Add("Home Runs");
            names.Add("RBI");
            names.Add("Walks");
            names.Add("Batting Average");
            stats = new List<double>();
        }
        public void PrintStats()
        {
            for (int i = 0; i < names.Count; i++)
            {
                Console.WriteLine(names[i] + " " + stats[i]);
            }
        }
        public void askStats()
        {
            for (int i = 0; i < names.Count; i++)
            {
                Console.WriteLine("Enter number of " + names[i] + ":");
                stats.Add(Convert.ToDouble(Console.ReadLine()));
            }
        }
    }
}
