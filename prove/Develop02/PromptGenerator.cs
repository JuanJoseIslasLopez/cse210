using System;
using System.Collections.Generic;
using Microsoft.VisualBasic;
public class PromptGenerator{
    public List<string> strings = new List<string> {"Who was the most interesting person I interacted with today?","What was the best part of my day?","How did I see the hand of the Lord in my life today?","What was the strongest emotion I felt today?","If I had one thing I could do over today, what would it be?","What did I learn of my scriture's study today?"};

    public string GetRandomPrompt()
    {   
        Random random = new Random();
        int index = random.Next(strings.Count);
        return strings[index];
    }
}