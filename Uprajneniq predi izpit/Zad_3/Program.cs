using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            int y = 100;
            int[,] array = new int[6, 5];
            Console.WriteLine("Enter 30 numbers from 0-100: ");
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length; j++)
                {
                    array[i,j] = int.Parse(Console.ReadLine());
                    if (array[i,j] > x)
                    {
                        x = array[i, j];
                    }
                    if (array[i,j] <y)
                    {
                        y = array[i, j];
                    }
                }
            }
            Console.WriteLine("The highest number is: {0}: ", x);
            Console.WriteLine("The lowest number is: {0}: ", y);
        }
    }
}
