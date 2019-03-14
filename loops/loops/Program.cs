using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loops
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("N\t\tN*10\t\tN*100\t\tN*1000");
            for (int multiplier = 1; multiplier <= 5; multiplier++)
            {
                Console.WriteLine("For Loop:");
                Console.WriteLine($"{multiplier}\t\t{multiplier * 10}\t\t{multiplier * 100}\t\t{multiplier * 1000}");

            }

            Console.ReadLine();
            int counter = 1;
        }
    }
}
