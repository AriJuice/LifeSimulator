using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LifeSimulator
{
    internal class ConsoleSupport
    {
        public static void SpareLine(int lines)
        {
            for (int i = 0; i <= lines; i++)
            {
                Console.WriteLine();
            }
        }

        public static void PrintError(string message)
        {
            ConsoleSupport.SpareLine(1);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
