public class Lecture : Event {
    private string speaker;
    private int capacity;

    public string Speaker {
        get { return speaker; }
        set { speaker = value; }
    }

    public int Capacity {
        get { return capacity; }
        set { capacity = value; }
    }

    public Lecture(string title, string description, string date, string time, string address, string speaker, int capacity)
        : base(title, description, date, time, address) {
        Speaker = speaker;
        Capacity = capacity;
    }

    public string DisplayInfo() {
        return base.DisplayInfo() + $"\nSpeaker: {Speaker}\nCapacity: {Capacity}";
    }
}