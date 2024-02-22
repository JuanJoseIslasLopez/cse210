using System;

class Program
{
    static void Main(string[] args)
    {
        Event lecture = new Lecture("Python Workshop", "Introduction to Python programming", "2024-02-20", "10:00 AM", "Apple 4563, Anytown, Uruguay", "Dr. Smith", 50);
        Event reception = new Reception("Networking Event", "Meet and greet with industry professionals", "2024-03-15", "6:00 PM", "Orange 4563, Anytown, Uruguay", "rsvp@example.com");
        Event outdoorEvent = new OutdoorGathering("Picnic in the Park", "Enjoy food and games outdoors", "2024-04-30", "12:00 PM", "Banana 4563, Anytown, Uruguay", "Sunny");

        List<Event> events = new List<Event> { lecture, reception, outdoorEvent };
        foreach (Event ev in events) {
            Console.WriteLine(ev.DisplayInfo());
            Console.WriteLine();
        }
    }
}