using System;
using System.Collections.Generic;

public class Event {
    private string title;
    private string description;
    private string date;
    private string time;
    private string address;

    public string Title {
        get { return title; }
        set { title = value; }
    }

    public string Description {
        get { return description; }
        set { description = value; }
    }

    public string Date {
        get { return date; }
        set { date = value; }
    }

    public string Time {
        get { return time; }
        set { time = value; }
    }

    public string Address {
        get { return address; }
        set { address = value; }
    }

    public Event(string title, string description, string date, string time, string address) {
        Title = title;
        Description = description;
        Date = date;
        Time = time;
        Address = address;
    }

    public string DisplayInfo() {
        return $"Title: {Title}\nDescription: {Description}\nDate: {Date}\nTime: {Time}\nAddress: {Address}";
    }
}