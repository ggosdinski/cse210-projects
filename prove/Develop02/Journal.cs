using System;
using System.IO; 

class Journal
{
    public List<Entry>_entries = new List<Entry>();
    // This is the empty list used to store the user´s response

    public void DisplayEntries()
    {
        Console.WriteLine (" Your entries: ");

        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }
    // This is a method use to display all the entries from the list I created before
    public void SaveToFile(string file)
    {
        //Save the entries.
        using (StreamWriter outputFile = new StreamWriter(file)) {
            foreach (Entry entrie in _entries) {
                outputFile.WriteLine(entrie.GetEntry());
            }
        }    
    }

    public void LoadFromFile(string file)
    {
        string[] lines = System.IO.File.ReadAllLines(file);
        
        foreach (string line in lines)
        {
            string[] parts = line.Split("|");
            string date = parts[0];
            string prompt= parts[1];
            string text = parts[2];
            
            Entry loadEntry = new Entry(); 
            loadEntry._date = date;
            loadEntry._prompt = prompt;
            loadEntry._text = text;
            
            _entries.Add(loadEntry);
        }
    }
    public void AddEntry(Entry entry)
    {
        _entries.Add(entry);
    }
}