using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();
    //Write Function
    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }
    //Display Funtion
    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }
    //Save Function
    public void SaveToFile(string file)
    {
        using (StreamWriter writer = new StreamWriter(file))
        {
            foreach (Entry entry in _entries)
            {
                writer.WriteLine($"{entry._DateTime}|{entry._PromptText}|{entry._EntryText}");
            }
        }
    }
    //Load Function
    public void LoadFromFile(string file)
    {   
        string[] lines = File.ReadAllLines(file);
        foreach (string line in lines)
        {
            string[] parts = line.Split('|');

            if (parts.Length == 3)
            {
                Entry entry = new Entry
                {
                    _DateTime = parts[0],
                    _EntryText = parts[1],
                    _PromptText = parts[2]
                };
                _entries.Add(entry);
            }
            else
            {
                Console.WriteLine("File not Found.");
            }
        }
    }
}
