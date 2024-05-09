using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine();
        
        // Job is now a data type that contains 2 strings and 2 ints:
        Job job1 = new(); // standard: " = new Job();", simplified
        job1._jobTitle = "Software Engineer";
        job1._company = "Microsoft";
        job1._startYear = 2019;
        job1._endYear = 2022;

        Job job2 = new() { // more simplified, only for initialization?
            _jobTitle = "Custodian", // why commas? idk
            _company = "BYU-I",
            _startYear = 2023,
            _endYear = 2024,
        };

        job1.Display();
        job2.Display();

        Console.WriteLine("\n");
        

        // Console.WriteLine("Hello Learning02 World!");

        // Person fred = new Person("Fred", "Flinstone"); // seperate instances
        // // fred.givenName = "Fred"; // can't be changed directly when private
        // // fred.familyName = "Flinstone";
        // Person steve = new Person("Steve", "Minecraft");
        // // steve.givenName = "Steve";
        // // steve.familyName = "Minecraft";
        
        // fred.EasternStyleName();
        // steve.WesternStyleName();
    }
}