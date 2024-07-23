
class Comment
{
    private string username;
    private string text;

    public Comment(string username, string text) {
        this.username = username;
        this.text = text;
    }

    public string GetComment() {
        return $"{this.username}: \"{this.text}\"";
    }
}