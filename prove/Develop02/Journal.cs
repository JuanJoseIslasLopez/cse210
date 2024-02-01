using System.IO; 
public class Journal {
    public List <Entry> _entries = new List<Entry>();

     public void AddEntry(Entry entry)
    {
        _entries.Add(entry);
    }

    public void DisplayAll()
    {
         if (_entries.Count == 0)
        {
            Console.WriteLine("Journal is empty.");
        }
        else
        {
            foreach (var entry in _entries)
            {
                entry.Display();
            }
        
        }
    }
    public void SaveToFile(string fileName)
    {

        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            foreach (var entry in _entries)
            {
                outputFile.WriteLine($"{entry._date}, {entry._promptText}, {entry._entryText}");
            }
        }
    }

    public void LoadFromFile(string fileName)
    {
        _entries.Clear();

        using (StreamReader reader = new StreamReader(fileName))
        {
            while (!reader.EndOfStream)
            {
                string[] entryParts = reader.ReadLine().Split(',');

                if (entryParts.Length == 3)
                {
                    Entry loadedEntry = new Entry
                    {
                        _date = DateTime.Parse(entryParts[0].Trim()),
                        _promptText = entryParts[1].Trim(),
                        _entryText = entryParts[2].Trim()
                    };

                    _entries.Add(loadedEntry);
                }
            }
        }
    }
   
}