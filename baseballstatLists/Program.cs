using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baseballstatLists
{
    class Program
    {
        static void Main(string[] args)
        {
            ListTools myList = new ListTools();
            myList.askStats();
            Console.Clear();
            myList.PrintStats();
            Console.ReadLine();
        }
    }
}
