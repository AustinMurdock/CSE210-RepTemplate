using System;

class Entry // simple data set
{
    public string Date {get; private set;}
    public string Prompt {get; private set;}
    public string Heading {get; private set;}
    public string Content {get; private set;}

    public void SetDate(string input) {
        Date = input;
    }

    public void SetPrompt(string input) {
        Prompt = input;
    }

    public void SetHeading(string input) {
        Heading = input;
    }

    public void SetContent(string input) {
        Content = input;
    }
}