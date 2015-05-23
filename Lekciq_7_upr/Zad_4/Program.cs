using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Console.WriteLine("Every element will be multiplied by 10:");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = 10 * array[i];
                Console.WriteLine(array[i] + " ");
            }
        }
    }
}
