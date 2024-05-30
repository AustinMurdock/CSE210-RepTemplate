class Reference
{
    string label;
    List<Verse> verses = new();

    public Reference(List<string> data) {
        this.label = data[0];
        foreach (string verse in data[1..]) {
            Verse newVerse = new(verse);
            verses.Add(newVerse);
        }
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