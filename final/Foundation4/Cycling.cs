public class Cycling : Activity {
    private double speed;

    public double Speed {
        get { return speed; }
        private set { speed = value; }
    }

    public Cycling(string date, int length, double speed) : base(date, length) {
        Speed = speed;
    }

    public override double GetSpeed() {
        return Speed;
    }

    public override double GetDistance() {
        throw new NotImplementedException("Distance calculation not implemented for Cycling activity");
    }

    public override double GetPace() {
        throw new NotImplementedException("Pace calculation not implemented for Cycling activity");
    }

    public override string GetSummary() {
        return $"{Date} Cycling ({Length} min) - Speed: {Speed} mph";
    }
}