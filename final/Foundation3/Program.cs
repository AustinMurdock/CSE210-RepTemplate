using System;

class Program
{
    static void Main()
    {
        Console.WriteLine();

        LectureEvent lE1 = new("The Perfect PokeRap", "An analysis of the flaws in the current official PokeRap, and a demonstration of a potential complete version for today's 1000+ Pokemon", "7/1819", "2am", "4qtnq Street", "San Fransisco", "California", "USA", "Brian David Gilbert", 80);
        ReceptionEvent rE1 = new("Receptinator 5000", "A reception in which all the people are recepted", "2046", "05:50", "213 aaaa idk st.", "Main City", "ProvinceLand", "Canada", "aaa@bb.com");
        OutdoorEvent oE1 = new("Running Around", "We show up to the park, we run around, not much else really. Bring snacks if you want ok thx", "Tomorrow", "2:05pm", "Park Circle A", "Brooklyn", "New York", "United States", "If it's sunny, we show up, if it rains, we show up");
        
        Console.WriteLine("Lecture Event Test 1:");
        Console.WriteLine($"\n{lE1.GetStandardDetails()}");
        Console.WriteLine($"\n{lE1.GetFullDetails()}");
        Console.WriteLine($"\n{lE1.GetShortDetails()}");

        Console.WriteLine();
        Console.WriteLine();

        Console.WriteLine("Reception Event Test 1:");
        Console.WriteLine($"\n{rE1.GetStandardDetails()}");
        Console.WriteLine($"\n{rE1.GetFullDetails()}");
        Console.WriteLine($"\n{rE1.GetShortDetails()}");

        Console.WriteLine();
        Console.WriteLine();

        Console.WriteLine("Outdoor Event Test 1:");
        Console.WriteLine($"\n{oE1.GetStandardDetails()}");
        Console.WriteLine($"\n{oE1.GetFullDetails()}");
        Console.WriteLine($"\n{oE1.GetShortDetails()}");

        Console.WriteLine();
        Console.WriteLine();

        // Console.WriteLine("Hello Foundation3 World!");
    }
}