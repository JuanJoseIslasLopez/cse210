using System;

class Program
{
    static void Main(string[] args)
    
    {   Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next(1, 101);

        int guess = -1;


         while (guess != magicNumber)
        {   Console.Write("What is the magic number? ");
            string inputTwo = Console.ReadLine();
            guess = int.Parse(inputTwo);
        
            if (magicNumber == guess)
                {
                    Console.WriteLine("You guessed it!");
                }
            else if(magicNumber > guess)
                {
                    Console.WriteLine("Higher");
                }
            else
                {
                    Console.WriteLine("Lower");
                }
        }
    }
}