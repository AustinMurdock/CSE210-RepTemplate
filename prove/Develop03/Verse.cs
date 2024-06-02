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
        bool willOverflow = false;
        Random rand = new();
        
        // if word is hidden & chance triggers, willOverflow = true;
        // if word isn't hidden & (willOverflow or chance triggers),
        // hide the word and reset willOverflow status:
        foreach (Word word in content) {
            if (word.ToString().Contains('_')) {
                if (rand.NextSingle() < chance) {
                    willOverflow = true;
                }
            }
            else {
                if (willOverflow || rand.NextSingle() < chance) {
                    word.SetHidden();
                    willOverflow = false;
                }
            }
        }
    }

    public string AssembleWords() {
        return string.Join(" ", content.Select(word => word.ToString()));
    }
}