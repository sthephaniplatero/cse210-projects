using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    private List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry entry)
    {
        _entries.Add(entry);
    }

    public void DisplayAll()
    {
        foreach (var entry in _entries)
        {
            Console.WriteLine(entry);
        }
    }

    public void SaveToFile(string filePath)
    {
        using (StreamWriter writer = new StreamWriter(filePath))
        {
            foreach (var entry in _entries)
            {
                writer.WriteLine($"{entry._date}|{entry._mood}|{entry._prompt}|{entry._content}");
            }
        }
        Console.WriteLine("Entries saved to text file.");
    }

    public void LoadFromFile(string filePath)
    {
        if (File.Exists(filePath))
        {
            _entries.Clear();
            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split('|');
                    DateTime date = DateTime.Parse(parts[0]);
                    string mood = parts[1];
                    string prompt = parts[2];
                    string content = parts[3];
                    _entries.Add(new Entry(date,mood,prompt,content));
                }
            }
            Console.WriteLine("Entries loaded from text file.");
        }
        else
        {
            Console.WriteLine("File not found.");
        }
    }



    
}



