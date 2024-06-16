using System;

/*
No stretch challenge completed.
*/

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

            Console.WriteLine();

            if (input == "1") {
                BreathingActivity breathing = new();

                Console.Clear();
                
                breathing.DisplayDescription();
                Console.WriteLine();
                breathing.PromptSetSeconds();
                Console.Clear();

                breathing.BreatheLoop();
                breathing.DisplayEnd();

                Console.Clear();
            }
            else if (input == "2") {
                ReflectionActivity reflection = new();

                Console.Clear();
                
                reflection.DisplayDescription();
                Console.WriteLine();
                reflection.PromptSetSeconds();
                Console.Clear();

                reflection.DisplayPrompt();
                Console.WriteLine();
                Console.WriteLine();
                reflection.QuestionsLoop();
                Console.WriteLine();
                reflection.DisplayEnd();

                Console.Clear();
            }
            else if (input == "3") {
                ListingActivity listing = new();

                Console.Clear();
                
                listing.DisplayDescription();
                Console.WriteLine();
                listing.PromptSetSeconds();
                Console.Clear();

                listing.DisplayPrompt();
                Console.WriteLine();
                listing.InputLoop();
                listing.DisplayCount();
                Console.WriteLine();
                listing.DisplayEnd();

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