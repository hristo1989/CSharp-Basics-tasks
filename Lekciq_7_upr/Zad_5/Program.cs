using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[5] { 1, 2, 3, 4, 5, };
            Console.WriteLine("Enter a number from the array (1-5) to check it's index:");
            int n = int.Parse(Console.ReadLine());
            switch (n)
            {
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                    break;
                default:
                    Console.WriteLine("The arrey doesn't contend such number!");
                    break;
            }
            int index = Array.IndexOf(array, n);
            Console.WriteLine("Position of the index is: {0}", index);
        }
    }
}
