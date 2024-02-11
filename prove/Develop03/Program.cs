using System;

class Program
{
    static void Main(string[] args)
    {   
        Reference reference = new Reference("John", 3, 16);
        Scripture scripture = new Scripture(reference, "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.");
        
        Console.WriteLine(scripture.GetDisplayText());
        
        Console.WriteLine("Press enter to continue or type 'quit' to finish.");

        while (!scripture.IsCompletelyHidden()) {
            
            string input = Console.ReadLine();
            if (input == "quit") {
                break;
                
            }
            
           
            scripture.HideRandomWords(1);
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("Press enter to continue or type 'quit' to finish.");
            
        }

        Console.WriteLine("Program ended.");
    
    }
}