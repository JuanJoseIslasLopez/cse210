public class Running : Activity {
    private double distance;

    public double Distance {
        get { return distance; }
        private set { distance = value; }
    }

    public Running(string date, int length, double distance) : base(date, length) {
        Distance = distance;
    }

    public override double GetDistance() {
        return Distance;
    }

    public override double GetSpeed() {
        return Distance / (Length / 60.0);
    }

    public override double GetPace() {
        return Length / Distance;
    }

    public override string GetSummary() {
        return $"{Date} Running ({Length} min) - Distance: {Distance} miles, Speed: {GetSpeed():F2} mph, Pace: {GetPace():F2} min per mile";
    }
}