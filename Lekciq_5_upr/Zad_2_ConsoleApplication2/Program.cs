using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad_2_ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your points 1 - 9:");
            int points = int.Parse(Console.ReadLine());

            if (points >= 1 && points <= 3)
            {
                Console.Write("Result is: ");
                Console.WriteLine(points * 5);
            }
            else if (points >= 4 && points <=6)
            {
                Console.Write("Result is: ");
                Console.WriteLine(points * 10);
            }
            else if (points >= 7 && points <=9)
            {
                Console.Write("Result is: ");
                Console.WriteLine(points * 50);
            }
            else
            {
                Console.WriteLine("Incorect number of points!");
            }
        }
    }
}
