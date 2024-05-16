using System;

class Journal // File-stored journal processing & interface
{
    public string Name {get; private set;}
    private List<Entry> entries = new();
    
    public Journal() {
        // this.Name = name;
    }

    public void AddEntry() {
        if (Name == null) {
            Console.Write("No current journal, enter a journal name: ");
            Name = Console.ReadLine();
        }

        Entry newEnt = new();

        Console.Write($"[{newEnt.Date}], Entry Title: ");
        newEnt.SetHeading(Console.ReadLine());

        Console.Write("  > ");
        newEnt.SetContent(Console.ReadLine());

        entries.Add(newEnt);
    }

    public void DisplayAll() {
        Console.WriteLine($"Journal \"{Name}\":");
        for (int i = 0; i < entries.Count; i++) {
            Console.WriteLine($"{i+1}. [{entries[i].Date}]: \"{entries[i].Heading}\"");
            Console.WriteLine($"      > \"{entries[i].Content}\"");
        }
    }

    public string SaveToFile(string fileName) {
        using (StreamWriter writer = new(fileName)) {
            writer.WriteLine("Date,Heading,Content");
            foreach (Entry entryClass in entries) {
                writer.Write($"{entryClass.Date},");
                writer.Write($"{entryClass.Heading},");
                writer.WriteLine($"{entryClass.Content}");
            }
        }
        return $"Data written to file \"{fileName}\"";
    }

    public string LoadFromFile(string fileName) {
        using (StreamReader reader = new(fileName)) {
            reader.ReadLine(); // skip heading
            Name = fileName.Substring(0, fileName.Length-4);
            while (reader.ReadLine() != null) {
                Console.WriteLine(reader.ReadLine());
            }
        }
        return $"Data read from file \"{fileName}\"";
    }
}