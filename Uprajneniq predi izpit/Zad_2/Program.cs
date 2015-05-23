using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter indexes for array:");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter indexes for array2:");
            int m = int.Parse(Console.ReadLine());
            int [] array = new int [n];
            int [] array2 = new int [m];
            Console.WriteLine("Enter a number for array: ");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Enter a number for array2: ");
            for (int i = 0; i < array2.Length; i++)
            {
                array2[i]=int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Same indexes for the arrays: ");
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array2.Length; j++)
                {
                    if (array[i] == array2[j])
                    {
                        Console.WriteLine(array2[j]);
                    }
                }
                
            }
           
         }
     }
  }

