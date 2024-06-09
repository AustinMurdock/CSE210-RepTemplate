
class WritingAssignment : Assignment
{
    string title;

    public WritingAssignment(string studentName, string topic, string title) : base(studentName, topic)
    {
        this.title = title;
    }

    public string GetWritingInfo() {
        return $"{title} by {studentName}";
    }
}