using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad_2b_ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your points 1 - 9:");
            int points = int.Parse(Console.ReadLine());

            switch (points)
            {
                case 1:
                case 2:
                case 3:
                    Console.Write("Result is: ");
                    Console.WriteLine(points * 5);
                    break;
                case 4:
                case 5:
                case 6:
                    Console.Write("Result is: ");
                    Console.WriteLine(points * 10);
                    break;
                case 7:
                case 8:
                case 9:
                    Console.Write("Result is: ");
                    Console.WriteLine(points * 50);
                    break;
                default:
                    Console.WriteLine("Incorect number of points!");
                    break;

            }
        }
    }
}
