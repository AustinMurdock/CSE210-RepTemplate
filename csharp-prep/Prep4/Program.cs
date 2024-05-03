using System;
// for lists, likely is included by default:
using System.Collections.Generic;
// using Internal;
// using System.Runtime.ConstrainedExecution;
// using Internal;
// using System.Numerics;
// using Internal;
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
        int smallestNat = -1; // smallest natural number in list, initial false value

        Console.WriteLine();

        Console.WriteLine("Enter a list of integers, type 0 when finished.");
        do {
            Console.Write("Enter an integer: ");
            numbers.Add(int.Parse((Console.ReadLine())));
        } while (!numbers.Contains(0));
        
        Console.WriteLine();

        sum = numbers.Sum();
        // average = sum / (numbers.Count); // can do -1 to remove last 0 int
        // cast sum to float value for float division:
        average = ((float)sum) / (numbers.Count);
        largest = numbers.Max();
        numbers.Sort(); // applies to original numbers list; mutability?
        if (numbers.Max() > 0) { // only if the list contains natural numbers
            // whatevers after 0 in sorted is smallest natural num:
            smallestNat = numbers[(numbers.IndexOf(0)+1)];
        }
        

        Console.WriteLine($"Sum: {sum}");
        Console.WriteLine($"Average: {average}");
        Console.WriteLine($"Highest value: {largest}");
        if (numbers.Max() > 0) { // only if the list contains natural numbers
            Console.WriteLine($"Lowest natural value: {smallestNat}");
        }
        else {
            Console.WriteLine("Lowest natural value: none");
        }
        Console.WriteLine("List of integers, sorted:");
        foreach (int value in numbers) {
            Console.WriteLine(value);
        }

        Console.WriteLine("\n");
    }
}