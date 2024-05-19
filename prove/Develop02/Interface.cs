using System;

class Interface // everything displayed to the user, & input manager
{
    private string optionsInput;
    private List<string> currentEntryInput = new();
    private Journal currentJournal;
    
    // at least an empty journal required for interface to work:
    public Interface(Journal currentJournal) {
        this.currentJournal = currentJournal;
    }

    public void OptionsPrompt() {
        Console.Write("""
        Journal Options:
        1. "write"
        2. "display"
        3. "save"
        4. "load"
        5. "exit"

        > 
        """);
        optionsInput = Console.ReadLine().ToLower();
    }

    public bool JournalAct() {
        if (optionsInput == "1" || optionsInput == "write") {
            CheckName();
            currentJournal.SaveEntry(CollectEntryData());
        }
        else if (optionsInput == "2" || optionsInput == "display") {
            DisplayAll();
        }
        else if (optionsInput == "3" || optionsInput == "save") {
            CheckName();
            currentJournal.SaveToFile();
            Console.WriteLine($"Saved journal \"{currentJournal.Name}\".");
        }
        else if (optionsInput == "4" || optionsInput == "load") {
            Console.Write("Enter the name of the journal to open: ");
            try {
                currentJournal.LoadFromFile(Console.ReadLine());
                Console.WriteLine($"Found journal \"{currentJournal.Name}\".");
            }
            catch (FileNotFoundException ex) {
                Console.WriteLine($"Error, requested journal not found: \"{ex.Message}\"");
                Console.WriteLine($"No journal data loaded.");
            }
        }
        else if (optionsInput == "5" || optionsInput == "exit") {
            Console.WriteLine("Ending program loop.");
            return false; // JournalAct() == false, breaks loop
        }
        else {
            Console.WriteLine($"Invalid input \"{optionsInput}\", try again.");
        }
        return true;
    }

    public void CheckName() {
        while (string.IsNullOrEmpty(currentJournal.Name)) {
            Console.Write("The current journal has no name. Enter a name here: ");
            currentJournal.SetName(Console.ReadLine());
            if (currentJournal.Name == "") {
                Console.WriteLine("Invalid blank input, try again.");
            }
        }
        Console.WriteLine();
    }

    private List<string> CollectEntryData() {
        currentEntryInput = new();

        currentEntryInput.Add(DateTime.UtcNow.ToString("MM/dd/yyyy"));

        Prompts promptSet = new();
        currentEntryInput.Add(promptSet.GetRandPrompt());

        Console.WriteLine($"[{currentEntryInput[0]}], {currentEntryInput[1]}");
        Console.WriteLine();
        
        Console.Write("Entry Title: ");
        currentEntryInput.Add(Console.ReadLine());

        Console.Write("  > ");
        currentEntryInput.Add(Console.ReadLine());

        return currentEntryInput;
    }

    public void DisplayAll() {
        Console.WriteLine($"Journal \"{currentJournal.Name}\":");

        for (int i = 0; i < currentJournal.Entries.Count; i++) {
            Console.WriteLine($"{i+1}. [{currentJournal.Entries[i].Date}]: {currentJournal.Entries[i].Prompt}");
            Console.WriteLine($"    \"{currentJournal.Entries[i].Heading}\"");
            Console.WriteLine($"  > \"{currentJournal.Entries[i].Content}\"");
        }
    }
}