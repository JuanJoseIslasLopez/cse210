abstract class Goal
{
    protected string _shortName;
    protected string _description;
    protected int _points;

    public string ShortName => _shortName;
    public string Description => _description;
    public int Points => _points;

    public Goal(string name, string description, int points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }


    public abstract void RecordEvent();
    public abstract bool IsComplete();
    public abstract string GetDetailsString();
    public abstract string GetStringRepresentation();

    protected string GetShortName() => _shortName;
    protected string GetDescription() => _description;
    protected int GetPoints() => _points;
}