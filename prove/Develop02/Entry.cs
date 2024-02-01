using System.ComponentModel.DataAnnotations;

public class Entry{
    public DateTime _date;
    public string _promptText;
    public string _entryText;

    public void Display()
    {
        Console.WriteLine($"Date: {_date:yyyy-MM-dd} - Prompt: {_promptText}\n{_entryText}\n");
    }

}

    