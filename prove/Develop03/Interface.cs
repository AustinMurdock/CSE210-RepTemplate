class Interface
{
    List<Reference> stored = new();
    Reference currentReference;

    public Interface(List<List<string>> data) {
        foreach (List<string> reference in data) {
            Reference newReference = new(reference);
            this.stored.Add(newReference);
        }
    }

    public void OptionsPrompt() {
        Console.WriteLine("Current verse options:");
        for (int i=0; i<stored.Count; i++) {
            Console.WriteLine($"[{i+1}] {stored[i].GetLabel()}");
        }
        Console.WriteLine();
        
        Console.Write("Enter a number: ");
        currentReference = stored[int.Parse(Console.ReadLine())-1];
    }

    public bool DisplayReference() {
        Console.Clear();
        Console.WriteLine(currentReference.GetLabel());
        Console.WriteLine(currentReference.AssembleVerses());
        Console.ReadLine();

        if (currentReference.AssembleVerses().All(c => c == ' ' || c == '_' || c == '\n')) {
            return false;
        }
        else {
            currentReference.ObscureVerses((float)0.2);
            return true;
        }
    }
}