class GoalManager
{
    private List<Goal> _goals;
    private int _score;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"Current Score: {_score}");
    }

    public void ListGoalNames()
    {
        foreach (Goal goal in _goals)
        {
            Console.WriteLine(goal.ShortName);
        }
    }

    public void ListGoalDetails()
    {
        foreach (Goal goal in _goals)
        {
            Console.WriteLine(goal.GetDetailsString());
        }
    }

   public void CreateGoal(string name, string description, int points, int target = 0, int bonus = 0, string goalType = "SimpleGoal")
{
    switch (goalType.ToLower())
    {
        case "simplegoal":
            _goals.Add(new SimpleGoal(name, description, points));
            break;
        case "eternalgoal":
            _goals.Add(new EternalGoal(name, description, points));
            break;
        case "checklistgoal":
            _goals.Add(new ChecklistGoal(name, description, points, target, bonus));
            break;
        default:
            Console.WriteLine("Invalid goal type. Creating a Simple Goal by default.");
            _goals.Add(new SimpleGoal(name, description, points));
            break;
    }
}

   
    public void RecordEvent(string goalName)
        {
            foreach (Goal goal in _goals)
            {
                if (goal.ShortName.Equals(goalName))
                {
                    goal.RecordEvent();
                    _score += goal.Points;
                    Console.WriteLine($"Event recorded for {goalName}. You gained {goal.Points} points.");
                    if (goal.IsComplete() && goal is ChecklistGoal checklistGoal)
                    {
                        _score += checklistGoal.Bonus;
                        Console.WriteLine($"Congratulations! You completed the {goalName} goal {checklistGoal.Target} times and earned a bonus of {checklistGoal.Bonus} points.");
                    }
                    return;
                }
            }
            Console.WriteLine("Goal not found.");
        }

    public void SaveGoals(string fileName)
    {
        using (StreamWriter writer = new StreamWriter(fileName))
        {
            foreach (Goal goal in _goals)
            {
                writer.WriteLine(goal.GetStringRepresentation());
            }
        }
        Console.WriteLine("Goals saved successfully.");
    }

   public void LoadGoals(string fileName)
{
    _goals.Clear();
    using (StreamReader reader = new StreamReader(fileName))
    {
        string line;
        while ((line = reader.ReadLine()) != null)
        {
            string[] parts = line.Split(',');
            string name = parts[0];
            string description = parts[1];
            int points = int.Parse(parts[2]);
            int amountCompleted = int.Parse(parts[3]);
            if (amountCompleted == 0)
            {
                _goals.Add(new SimpleGoal(name, description, points));
            }
            else
            {
                int target = int.Parse(parts[4]);
                int bonus = int.Parse(parts[5]);
                _goals.Add(new ChecklistGoal(name, description, points, target, bonus));
            }
        }
    }
    Console.WriteLine("Goals loaded successfully.");
}

}