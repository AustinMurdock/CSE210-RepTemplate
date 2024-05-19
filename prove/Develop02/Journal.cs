using System;
using System.Text.RegularExpressions;

class Journal // File-reference journal data manager
{
    public string Name {get; private set;}
    public List<Entry> Entries {get; private set;} = new();

    public void SetName(string newName) {
        Name = newName;
    }

    public void SaveEntry(List<string> inputData) {
        Entry newEntry = new();
        
        newEntry.SetDate(inputData[0]);
        newEntry.SetPrompt(inputData[1]);
        newEntry.SetHeading(inputData[2]);
        newEntry.SetContent(inputData[3]);

        Entries.Add(newEntry);
    }

    public string SaveToFile() {
        using (StreamWriter writer = new($"j_{Name}.csv")) {
            writer.WriteLine("Date|%>⸲'>|Prompt|%>⸲'>|Heading|%>⸲'>|Content");
            foreach (Entry entryI in Entries) {
                // |%>⸲'>| seperation markers, including unicode U+2E32 "Turned Comma"
                writer.Write($"{entryI.Date}|%>⸲'>|");
                writer.Write($"{entryI.Prompt}|%>⸲'>|");
                writer.Write($"{entryI.Heading}|%>⸲'>|");
                writer.WriteLine($"{entryI.Content}");
            }
        }
        return $"\"{Name}\" data written to file \"j_{Name}.csv\"";
    }

    public string LoadFromFile(string inputJournalName) {
        using (StreamReader reader = new($"j_{inputJournalName}.csv")) {
            reader.ReadLine(); // skip heading

            Name = inputJournalName;
            Entries = new();

            while (reader.Peek() >= 0) {
                // can switch to custom MyRegex.Split for better efficiency:
                SaveEntry(Regex.Split(reader.ReadLine(), @"\|%>⸲'>\|").ToList());
            }
        }
        return $"\"{Name}\" data read from file \"j_{inputJournalName}.csv\"";
    }
}