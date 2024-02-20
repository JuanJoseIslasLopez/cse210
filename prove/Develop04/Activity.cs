using System;
using System.Collections.Generic;
using System.Threading;

class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    public Activity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }

    public virtual void DisplayStartingMessage()
    {
        Console.WriteLine($"Starting {_name} activity...");
        Console.WriteLine(_description);
        Thread.Sleep(2000);
    }

    public virtual void DisplayEndingMessage()
    {
        Console.WriteLine($"Congratulations! You've completed the {_name} activity.");
        Console.WriteLine($"Duration: {_duration} seconds.");
        Thread.Sleep(2000);
    }

    protected void ShowSpinner(int seconds)
    {
        for (int i = 0; i < seconds; i++)
        {
            Console.Write("+");

            Thread.Sleep(250);

            Console.Write("\b \b"); 
            Console.Write("-"); 

        }
    }

    protected void ShowCountdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.WriteLine($"{i}");
            Thread.Sleep(1000);
            Console.Write("\b\b"); 
        }
    }
}