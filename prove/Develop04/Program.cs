using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Start breathing activity");
            Console.WriteLine("2. Start reflection activity");
            Console.WriteLine("3. Start listing activity");
            Console.WriteLine("4. Quit");
            Console.WriteLine("Select a choice from the menu:");


            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.Write("Welcome to the Bleathing Activity.");
                    Console.Write("This activity Will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");
                    Console.Write("How long, in seconds, would you like for your session?");
                    int durationBreathing = int.Parse(Console.ReadLine());
                    BreathingActivity breathingActivity = new BreathingActivity(durationBreathing);
                    breathingActivity.Run();
                    break;
                case "2":
                    Console.Write("Enter the duration of the activity in seconds: ");
                    int durationReflecting = int.Parse(Console.ReadLine());
                    ReflectingActivity reflectingActivity = new ReflectingActivity(durationReflecting);
                    reflectingActivity.Run();
                    break;
                case "3":
                    Console.Write("Enter the duration of the activity in seconds: ");
                    int durationListing = int.Parse(Console.ReadLine());
                    ListingActivity listingActivity = new ListingActivity(durationListing);
                    listingActivity.Run();
                    break;
                case "4":
                    Console.WriteLine("Exiting the program...");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please enter a valid option.");
                    break;
            }
        }
    }
}