using System;

class Program
{
    static void Main(string[] args)
    {
        GoalManager manager = new GoalManager();
        bool running = true;

        while (running)
        {
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
            Console.Write("Select a choice from the menu: ");

            int choice;
            if (int.TryParse(Console.ReadLine(), out choice))
            {
                switch (choice)
                {
                   case 1:
                        Console.WriteLine("Options:");
                        Console.WriteLine("1. Simple Goal");
                        Console.WriteLine("2. Eternal Goal");
                        Console.WriteLine("3. Checklist Goal");
                        Console.Write("Select the type of goal: ");
                        if (int.TryParse(Console.ReadLine(), out int goalTypeChoice))
                        {
                            string goalType;
                            switch (goalTypeChoice)
                            {
                                case 1:
                                    goalType = "SimpleGoal";
                                    break;
                                case 2:
                                    goalType = "EternalGoal";
                                    break;
                                case 3:
                                    goalType = "ChecklistGoal";
                                    break;
                                default:
                                    Console.WriteLine("Invalid choice. Creating a Simple Goal by default.");
                                    goalType = "SimpleGoal";
                                    break;
                            }

                            Console.Write("Enter goal name: ");
                            string name = Console.ReadLine();
                            Console.Write("Enter goal description: ");
                            string description = Console.ReadLine();
                            Console.Write("Enter points for the goal: ");
                            if (int.TryParse(Console.ReadLine(), out int points))
                            {
                                if (goalTypeChoice == 3) 
                                {
                                    Console.Write("Enter target for the checklist goal: ");
                                    if (int.TryParse(Console.ReadLine(), out int target))
                                    {
                                        Console.Write("Enter bonus for completing the checklist goal: ");
                                        if (int.TryParse(Console.ReadLine(), out int bonus))
                                        {
                                            manager.CreateGoal(name, description, points, target, bonus, goalType);
                                            Console.WriteLine("Goal created successfully.");
                                        }
                                        else
                                        {
                                            Console.WriteLine("Invalid bonus value. Creating a Simple Goal by default.");
                                            manager.CreateGoal(name, description, points);
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("Invalid target value. Creating a Simple Goal by default.");
                                        manager.CreateGoal(name, description, points);
                                    }
                                }
                                else
                                {
                                    manager.CreateGoal(name, description, points, goalType: goalType);
                                    Console.WriteLine("Goal created successfully.");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Invalid points value. Please enter a valid integer.");
                            }
                        
                        }
                        break;
                    case 2:
                        manager.ListGoalDetails();
                        break;
                   case 3:
                        Console.Write("Enter the name of the file to save: ");
                        string fileName = Console.ReadLine();
                        manager.SaveGoals(fileName + ".txt");
                        break;
                    case 4:
                        Console.Write("Enter the name of the file to load: ");
                        string loadFileName = Console.ReadLine();
                        manager.LoadGoals(loadFileName + ".txt");
                        break;
                    case 5:
                        Console.Write("Enter the name of the goal you accomplished: ");
                        string eventName = Console.ReadLine();
                        manager.RecordEvent(eventName);
                        break;
                    case 6:
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please select a number from the menu.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid choice. Please select a number from the menu.");
            }

            Console.WriteLine();
        }
    }
}
