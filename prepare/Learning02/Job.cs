using System;

public class Job {
    // all var types that the Job type contains:
    public string _company;
    public string _jobTitle;
    public int _startYear;
    public int _endYear;

    // contructor; use to require properties on intance creation
    public Job() {
        // this._company = _company;
        // this._jobTitle = _jobTitle;
        // // ...
    }

    public void Display() {
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
    }
}