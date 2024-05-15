using System;

class Entry
{
    private readonly string date;
    // private string Date {get;}
    private string heading;
    private string content;

    public Entry() { // always set default current date
        this.date = DateTime.Today.ToString();
    }
    public string Date() { // compare to List.Count ?property
        return (date);
    }

    public void SetHeading(string input) {
        heading = input;
    }
    public void SetContent(string input) {
        content = input;
    }

    public string GetHeading() {
        return (heading);
    }
    public string GetContent() {
        return (content);
    }

}