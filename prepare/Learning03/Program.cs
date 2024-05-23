using System;

class Program
{
    static void Main()
    {
        Fraction f1 = new(); // 1/1
        Fraction f2 = new(6); // 6/1
        Fraction f3 = new(6, 7); // 6/7

        Console.WriteLine($"f1: {f1.GetTop()}, {f1.GetBottom()}");
        Console.WriteLine($"f2: {f2.GetTop()}, {f2.GetBottom()}");
        Console.WriteLine($"f3: {f3.GetTop()}, {f3.GetBottom()}");
        
        f1.SetTop(2); f1.SetBottom(3);
        f2.SetTop(5); f2.SetBottom(9);
        f3.SetTop(1); f3.SetBottom(2);
        Console.WriteLine("Replaced values. ");

        Console.WriteLine($"f1: {f1.GetTop()}, {f1.GetBottom()}");
        Console.WriteLine($"f2: {f2.GetTop()}, {f2.GetBottom()}");
        Console.WriteLine($"f3: {f3.GetTop()}, {f3.GetBottom()}");
        
        Fraction f4 = new();
        Fraction f5 = new(1);
        Fraction f6 = new(5);
        Fraction f7 = new(3, 4);
        Fraction f8 = new(1, 3);
        Console.WriteLine("New set of values.");

        Console.WriteLine($"f4: {f4.GetFractionString()} | {f4.GetDecimalValue()}");
        Console.WriteLine($"f5: {f5.GetFractionString()} | {f5.GetDecimalValue()}");
        Console.WriteLine($"f6: {f6.GetFractionString()} | {f6.GetDecimalValue()}");
        Console.WriteLine($"f7: {f7.GetFractionString()} | {f7.GetDecimalValue()}");
        Console.WriteLine($"f8: {f8.GetFractionString()} | {f8.GetDecimalValue()}");

        // Console.WriteLine("Hello Learning03 World!");
    }
}