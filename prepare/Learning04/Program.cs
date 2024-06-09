using System;

class Program
{
    static void Main()
    {
        Console.WriteLine();

        Assignment assignment1 = new("Samuel Bennett", "Multiplication");
        Console.WriteLine(assignment1.GetSummary());
        
        Console.WriteLine();

        MathAssignment assignment2 = new("Roberto Rodriguez", "Fractions", "7.3", "8-19");
        Console.WriteLine(assignment2.GetSummary());
        Console.WriteLine(assignment2.GetHomeworkList());

        Console.WriteLine();

        WritingAssignment assignment3 = new("Mary Waters", "European History", "The Causes of World War II");
        Console.WriteLine(assignment3.GetSummary());
        Console.WriteLine(assignment3.GetWritingInfo());

        Console.WriteLine();
        Console.WriteLine();

        // Console.WriteLine("Hello Learning04 World!");
    }
}