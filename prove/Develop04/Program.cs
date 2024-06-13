using System;

class Program
{
    static void Main()
    {
        List<string> options = new([
            "Breathing activity", 
            "Reflection activity", 
            "Listing activity", 
            "Exit"]);
        string input;
        
        Console.Clear();
        Console.WriteLine();
        
        while (true) {
            Console.WriteLine("Current Options:");
            for (int i = 0; i < options.Count; i++ ) {
                Console.WriteLine($" [{i+1}] {options[i]}");
            }
            Console.Write("Enter a number: ");
            input = Console.ReadLine();

            if (input == "1") {
                BreathingActivity breathing = new();
                
                breathing.DisplayDescription();
                breathing.PromptSetSeconds();
                breathing.DisplayEnd();

                Console.Clear();
            }
            else if (input == "2") {
                
                Console.Clear();
            }
            else if (input == "3") {
                
                Console.Clear();
            }
            else if (input == "4") {
                break;
            }
            else {
                Console.Clear();

                Console.WriteLine("Sorry, that wasn't a valid option.");
                Console.WriteLine();
            }
        }

        Console.WriteLine();
        Console.WriteLine();

        // Console.WriteLine("Hello Develop04 World!");
    }
}