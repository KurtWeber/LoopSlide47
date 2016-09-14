using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopSlide47
{
    class Program
    {
        static void Main(string[] args)
        {
            // Initialize variables
            int number;

            // Loop to test user input
            do
            {
                Console.Write("Please enter a integer to see if you've won: ");
                number = int.Parse(Console.ReadLine());

                // To print you lost only if number isn't divisible by 3
                if (number % 3 != 0)
                {
                    Console.WriteLine("\nYou Lost");
                    Console.WriteLine("\nPlease try again\n");
                }
            } while (number % 3 != 0);
            Console.WriteLine("\nYou Won!");
        }
    }
}
