class Reference
{
    string label;
    List<Verse> verses = new();

    public Reference(string label, List<string> verses) {
        this.label = label;
        foreach (string verse in verses) {
            Verse newVerse = new(verse);
            this.verses.Add(newVerse);
        }
        // I get how multiple constructors can be used in a class, 
        // but in this case I just don't think they're needed
    }

    public string GetLabel() {
        return label;
    }

    public void ObscureVerses(float chance) {
        foreach (Verse verse in verses) {
            verse.ObscureWords(chance);
        }
    }

    public string AssembleVerses() {
        return string.Join("\n", verses.Select(verse => verse.AssembleWords()));
    }

}