using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a integer");
            int numInt = int.Parse(Console.ReadLine());

            if (numInt >= 1 && numInt <= 5)
            {
               if (numInt % 2  == 0)
               {
                   Console.WriteLine("Number is even");
               }
               else
               {
                   Console.WriteLine("Number is odd"); 
               }
             }
            else if (numInt >= 6 && numInt <= 15)
            {
                if (numInt % 3 ==0)
                {
                    Console.WriteLine("Divided without residue");
                }
                else
                {
                    Console.WriteLine("Divided with residue");
                }

            }
            else 
            {
                if (numInt >0)
                {
                    Console.WriteLine("The number is positive");  
                }
                else if (numInt ==0)
                {
                    Console.WriteLine("The number is null");
                }
                else
                {
                    Console.WriteLine("The number is negative");
                }

            }
        }
    }
}
