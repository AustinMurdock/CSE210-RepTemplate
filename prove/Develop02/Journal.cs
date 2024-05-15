using System;

class Journal
{
    private string name;
    private List<Entry> entries = new();
    
    public Journal(string name) {
        this.name = name;
    }

    public void AddEntry() {
        Entry newEnt = new();

        Console.Write($"[{newEnt.Date()}], Entry Title: ");
        newEnt.SetHeading(Console.ReadLine());

        Console.Write("  > ");
        newEnt.SetContent(Console.ReadLine());

        entries.Add(newEnt);
    }

    public void DisplayAll() {
        Console.WriteLine($"Journal \"{name}\":");
        for (int i = 0; i < entries.Count; i++) {
            Console.WriteLine($"{i+1}. [{entries[i].Date()}]: \"{entries[i].GetHeading()}\"");
            Console.WriteLine($"      > \"{entries[i].GetContent()}\"");
        }
    }
}