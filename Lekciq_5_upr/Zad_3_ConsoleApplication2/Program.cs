using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad_3_ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please select a card from the deck: ");
            string card = (Console.ReadLine());


            switch (card)
            {
                case "2":
                    Console.WriteLine("Your card is TWO!");
                    break;
                case "3":
                    Console.WriteLine("Your card is THREE!");
                    break;
                case "4":
                    Console.WriteLine("Your card is FOUR!");
                    break;
                case "5":
                    Console.WriteLine("Your card is FIVE!");
                    break;
                case "6":
                    Console.WriteLine("Your card is SIX!");
                    break;
                case "7":
                    Console.WriteLine("Your card is SEVEN!");
                    break;
                case "8":
                    Console.WriteLine("Your card is EIGHT!");
                    break;
                case "9":
                    Console.WriteLine("Your card is NINE!");
                    break;
                case "10":
                    Console.WriteLine("Your card is TEN!");
                    break;
                case "J":
                case "j":
                    Console.WriteLine("Your card is JACK!");
                    break;
                case "Q":
                case "q":
                    Console.WriteLine("Your card is QUEEN!");
                    break;
                case "K":
                case "k":
                    Console.WriteLine("Your card is KING!");
                    break;
                case "A":
                case "a":
                    Console.WriteLine("Your card is ACE!");
                    break;
                default:
                    Console.WriteLine("Your card is incorect!!!");
                    break;

            }
        }
    }
}
