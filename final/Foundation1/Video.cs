
class Video
{
    private string title;
    private string author;
    private int length;
    private List<Comment> comments;

    public Video(string title, string author, int secondsLength, List<Comment> comments) {
        this.title = title;
        this.author = author;
        this.length = secondsLength;
        this.comments = comments;
    }

    public int GetCommentsCount() {
        return comments.Count;
    }

    public string GetTitle() {
        return this.title;
    }
    
    public string GetAuthor() {
        return this.author;
    }

    public int GetLength() {
        return this.length;
    }

    public List<Comment> GetComments() {
        return comments;
    }

}