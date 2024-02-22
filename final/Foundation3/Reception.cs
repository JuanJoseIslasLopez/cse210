public class Reception : Event {
    private string rsvpEmail;

    public string RsvpEmail {
        get { return rsvpEmail; }
        set { rsvpEmail = value; }
    }

    public Reception(string title, string description, string date, string time, string address, string rsvpEmail)
        : base(title, description, date, time, address) {
        RsvpEmail = rsvpEmail;
    }

    public string DisplayInfo() {
        return base.DisplayInfo() + $"\nRSVP Email: {RsvpEmail}";
    }
}

public class OutdoorGathering : Event {
    private string weather;

    public string Weather {
        get { return weather; }
        set { weather = value; }
    }

    public OutdoorGathering(string title, string description, string date, string time, string address, string weather)
        : base(title, description, date, time, address) {
        Weather = weather;
    }

    public string DisplayInfo() {
        return base.DisplayInfo() + $"\nWeather: {Weather}";
    }
}