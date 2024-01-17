using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What's your grade percentage? ");
        string input = Console.ReadLine();
        int percentage = int.Parse(input);
        string letter = "0";
        if (percentage >= 90)
            {
                letter="A";
            }
        else if(percentage >= 80)
            {
                letter="B";
            }
        else if(percentage >= 70)
            {
                letter="C";
            }
        else if(percentage >= 60)
            {
                letter="D";
            }
        else
            {
                letter="F";
            }
            Console.WriteLine(letter);
        if (percentage >= 70)
            {
                Console.WriteLine("Let's gooooo");
            }
        else
            {
                Console.WriteLine("Don't give up, try again!");
            }
    }
}