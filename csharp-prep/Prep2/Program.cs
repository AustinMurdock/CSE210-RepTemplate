using System;

class Program
{
    static void Main(string[] args)
    {
        int value;
        string letterGrade;
        string sign;

        Console.WriteLine();

        Console.Write("Enter your grade, as an integer: ");
        value = int.Parse(Console.ReadLine());

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
        
        sign = "";
        if (value >= 60 && value < 93) {
            if (value % 10 >= 7) {
                sign = "+";
            }
            else if (value % 10 < 3) {
                sign = "-";
            }
        }

        Console.WriteLine($"Your marked grade is \"{letterGrade}{sign}\".");

        if (value >= 70) {
            Console.WriteLine("You passed!");
        }
        else {
            Console.WriteLine("You probably didn't pass!");
        }

        Console.WriteLine("\n");
    }
}
