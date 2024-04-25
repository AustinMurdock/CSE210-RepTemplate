using System;

class Program
{
    static void Main(string[] args)
    {
        string letterGrade = "Z";

        Console.WriteLine();

        Console.Write("Enter your grade, as an integer: ");
        int value = int.Parse(Console.ReadLine());

        if (value >= 90) {
            letterGrade = "A";
        }
        else if (value >= 80) {
            letterGrade = "B";
        }
        else if (value >= 70) {
            letterGrade = "C";
        }
        else if (value >= 60) {
            letterGrade = "D";
        }
        else {
            letterGrade = "F";
        }

        Console.WriteLine($"Your letter grade is \"{letterGrade}\".");

        Console.WriteLine("\n");
    }
}
