class Word
{
    string content;
    bool isHidden = false;

    public Word(string content) {
        this.content = content;
    }

    public void SetHidden() {
        isHidden = true;
    }

    public override string ToString() {
        // not sure if this is good practice,
        // but might as well try it (:
        if (!isHidden) {
            return content.ToString();
        }
        else {
            return new string('_', content.Length);
        }
    }
}