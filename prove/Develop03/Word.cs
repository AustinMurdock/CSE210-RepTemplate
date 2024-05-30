class Word
{
    string content;
    bool isHidden = false;

    public Word(string content) {
        this.content = content;
    }

    public bool SetHidden() {
        if (!isHidden) {
            isHidden = true;
            return true;
        }
        else {
            return false;
        }
    }

    public override string ToString()
    {
        if (!isHidden) {
            return content.ToString();
        }
        else {
            return new string('_', content.Length);
        }
    }
}