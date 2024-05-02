using System;
// for lists, likely is included by default:
using System.Collections.Generic;
// using System.Linq;
// using Internal;
// using Internal;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int sum;
        float average;
        int largest;

        Console.WriteLine();

        Console.WriteLine("Enter a list of integers, type 0 when finished.");
        do {
            Console.Write("Enter an integer: ");
            numbers.Add(int.Parse((Console.ReadLine())));
        } while (!numbers.Contains(0));

        sum = numbers.Sum();
        // average = sum / (numbers.Count); // can do -1 to remove last 0 int
        // multiply by null (float) value for float output:
        average = ((float)sum) / (numbers.Count);
        largest = numbers.Max();

        Console.WriteLine($"Sum: {sum}");
        Console.WriteLine($"Average: {average}");
        Console.WriteLine($"Highest value: {largest}");

        Console.WriteLine("\n");
    }
}