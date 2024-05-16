using System;

class Entry
{
    public string Date {get; private set;}
    public string Heading {get; private set;}
    public string Content {get; private set;}

    public Entry() { // always set default current date
        this.Date = DateTime.UtcNow.ToString("MM/dd/yyyy");
    }

    public void SetHeading(string input) {
        Heading = input;
    }

    public void SetContent(string input) {
        Content = input;
    }
}