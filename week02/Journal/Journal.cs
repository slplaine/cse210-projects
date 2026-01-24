using System;
using System.Collections.Generic;
using System.IO;

public class Journal 
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry entry)
    {
        _entries.Add(entry);
    }

    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    public void SaveToCsv(string filename)
    {
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.WriteLine("Date,Prompt,Entry");

            foreach (Entry entry in _entries)
            {
                string date = EscapeCsv(entry._date);
                string prompt = EscapeCsv(entry._promptText);
                string text = EscapeCsv(entry._entryText);

                outputFile.WriteLine($"{date},{prompt},{text}");
            }
        }
    }

    private string EscapeCsv(string field)
    {
        if (field.Contains(",") || field.Contains("\""))
        {
            field = field.Replace("\"", "\"\"");
            field = $"\"{field}\"";
        }
        return field;
    }
    public void LoadFromCsv(string filename)
    {
        _entries.Clear();
        string[] lines = File.ReadAllLines(filename);

        for (int i = 1; i < lines.Length; i++)
        {
            string line = lines[i];
            string[] parts = ParseCsvLine(line);

            Entry entry = new Entry
            {
                _date = parts[0],
                _promptText = parts[1],
                _entryText = parts[2]
            };

            _entries.Add(entry);
        }
    }

    private string[] ParseCsvLine(string line)
    {
        List<string> fields = new List<string>();
        bool insideQuotes = false;
        string current = "";

        foreach (char c in line)
        {
            if (c == '"' && !insideQuotes)
            {
                insideQuotes = true;
            }
            else if (c == '"' && insideQuotes)
            {
                insideQuotes = false;
            }
            else if (c == ',' && !insideQuotes)
            {
                fields.Add(current);
                current = "";
            }
            else
            {
                current += c;
            }
        }
        fields.Add(current);

        return fields.ToArray();
    }

}
  
