public abstract class Activity {
    private string date;
    private int length;

    public string Date {
        get { return date; }
        private set { date = value; }
    }

    public int Length {
        get { return length; }
        private set { length = value; }
    }

    public Activity(string date, int length) {
        Date = date;
        Length = length;
    }

    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();
    public abstract string GetSummary();

    public override string ToString() {
        return $"Date: {Date}, Length: {Length} minutes";
    }
}