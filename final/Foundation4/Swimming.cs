public class Swimming : Activity {
    private int laps;
    private const double lapLengthMeters = 50;

    public int Laps {
        get { return laps; }
        private set { laps = value; }
    }

    public Swimming(string date, int length, int laps) : base(date, length) {
        Laps = laps;
    }

    public override double GetDistance() {
        return Laps * lapLengthMeters / 1000;
    }

    public override double GetSpeed() {
        return GetDistance() / (Length / 60.0);
    }

    public override double GetPace() {
        return Length / GetDistance();
    }

    public override string GetSummary() {
        return $"{Date} Swimming ({Length} min) - Distance: {GetDistance():F2} km, Speed: {GetSpeed():F2} kph, Pace: {GetPace():F2} min per km";
    }
}
