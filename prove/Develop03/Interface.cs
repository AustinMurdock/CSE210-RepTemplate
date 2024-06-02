class Interface
{
    List<Reference> storedReferences = new();
    Reference currentReference;

    public Interface() {
        // no initial data required
    }

    public void AddReference(string label, List<string> verses) {
        Reference newReference = new(label, verses);
        this.storedReferences.Add(newReference);
    }

    public void PickOption() {
        Console.WriteLine("Current verse options:");
        for (int i=0; i<storedReferences.Count; i++) {
            Console.WriteLine($"[{i+1}] {storedReferences[i].GetLabel()}");
        }
        Console.WriteLine();
        
        Console.Write("Enter a number: ");
        currentReference = storedReferences[int.Parse(Console.ReadLine())-1];
    }

    public void DisplayReference() {
        Console.Clear();
        Console.WriteLine(currentReference.GetLabel());
        Console.WriteLine(currentReference.AssembleVerses());

        Console.WriteLine();

        
    }

    public string CollectInput() {
        Console.Write("Press Enter or type \"quit\": ");
        return Console.ReadLine();
    }

    public void ObscureReference(float chance) {
        currentReference.ObscureVerses(chance);
    }

    public bool AllHidden() {
        if (currentReference.AssembleVerses().All(c => c == ' ' || c == '_' || c == '\n')) {
            return true;
        }
        else {
            return false;
        }
    }
}