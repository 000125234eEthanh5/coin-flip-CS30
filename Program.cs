using System;

namespace coinFlip
{
    class Program
    {
        static void Main(string[] args)
        {
            int coin;
            string userGuess;
            string coinDescription = "Tails";
            Random rng = new Random();

            // query the user
            Console.Write("Enter your guess Heads or Tails (H or T) ");
            userGuess = Console.ReadLine();

            // Get a random number for the coin flip
            coin = rng.Next(0, 2);
            if (coin == 1)
            {
                coinDescription = "Heads";
            }
            
            if ((coin == 0 && userGuess == "T") || (coin == 1 && userGuess == "H"))
            {
                Console.WriteLine("The coin flip was {0}, you win!", coinDescription);
            }

            else if ((coin == 0 && userGuess == "t") || (coin == 1 && userGuess == "h"))
            {
                Console.WriteLine("The coin flip was {0}, you win!", coinDescription);
            }
                             
            else
            {
                Console.WriteLine("The coin flip was {0}, you lose!", coinDescription);
            }
                Console.ReadLine();
        }
    }
}
