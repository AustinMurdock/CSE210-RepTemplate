class Verse
{
    List<Word> content = new();

    public Verse(string text) {
        foreach (string word in text.Split(" ")) {
            Word newWord = new(word);
            this.content.Add(newWord);
        }
    }

    public void ObscureWords(float chance) {
        Random rand = new();
        foreach (Word word in content) {
            if (rand.NextSingle() < chance) {
                word.SetHidden();
            }
        }
    }

    public string AssembleWords() {
        return string.Join(" ", content.Select(word => word.ToString()));
    }
}