using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectionStatements
{
    internal class Program
    {
     
        static void Main(string[] args)
        {
            int favorite = 22;
            int userGuess = int.Parse(Console.ReadLine());

            if (userGuess < favorite)
            {
                Console.WriteLine("Too low.");
            }
            else if (userGuess > favorite)
            {
                Console.WriteLine("Too high.");
            }
            else
            {
                Console.WriteLine("Nevermind");
            }

        }
    }
}
