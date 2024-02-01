using System;
using System.ComponentModel.DataAnnotations;

class Program
{   
    static void Main(string[] args)
    {   int numberAnswer;
        Journal journal = new Journal();
        Console.WriteLine("Welcome to the Journal!");
        do
        {  
            
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.WriteLine("What would you like to do? ");
            string answer = Console.ReadLine();
            numberAnswer = int.Parse(answer);
            

            if (numberAnswer == 1)
                {   PromptGenerator prompt = new PromptGenerator();
                    string randomPrompt = prompt.GetRandomPrompt();
                    Console.WriteLine($"{randomPrompt}");
                    string response = Console.ReadLine();
                     Entry newEntry = new Entry
                    {
                        _promptText = randomPrompt,
                        _entryText = response,
                        _date = DateTime.Now
                    };
                    journal.AddEntry(newEntry);
                }
            else if (numberAnswer == 2)
                {   
                    journal.DisplayAll();
                }
            else if (numberAnswer == 3)
                {   try
                    {
                        Console.Write("What is the file name? ");
                        string fileName = Console.ReadLine();
                        journal.LoadFromFile(fileName);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Error loading the journal from file: {ex.Message}");
                    }
                }
            else if (numberAnswer == 4)
                {   
                    try
                    {
                        Console.Write("What is the file name? ");
                        string fileName = Console.ReadLine();
                        journal.SaveToFile(fileName);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Error loading the journal from file: {ex.Message}");
                    }
                }

        }while (numberAnswer != 5);
    }
    
}