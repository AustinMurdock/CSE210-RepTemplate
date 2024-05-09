using System;

public class Resume {
    public string _name;
    public List<Job> _jobs = new List<Job>();

    // blank contructor, no required properties:
    public Resume() {}

    public void Display() {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs:");
        foreach (Job listedJob in _jobs) {
            listedJob.Display();
        }
    }
}