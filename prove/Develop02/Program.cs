using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine();

        string userInput;
        string fileName;

        Journal newJournal = new("aaa"); // required Journal.name constructor
        
        while (true) {
            Console.Write("""
            Journal Options:
            1. "write"
            2. "display"
            3. "save"
            4. "load"
            5. "exit"

            > 
            """);
            userInput = Console.ReadLine().ToLower();
            Console.WriteLine();

            if (userInput == "1" || userInput == "write") {
                Prompts prmpt = new();
                Console.WriteLine($"Optional prompt: {prmpt.RandPrompt()}");
                Console.WriteLine();
                newJournal.AddEntry();
            }
            else if (userInput == "2" || userInput == "display") {
                newJournal.DisplayAll();
            }
            else if (userInput == "3" || userInput == "save") {
                ;
            }
            else if (userInput == "4" || userInput == "load") {
                ;
            }
            else if (userInput == "5" || userInput == "exit") {
                break;
            }
            else {
                Console.WriteLine("Invalid input, try again.");
            }

            Console.WriteLine();
        }

        Console.WriteLine();
        // Console.WriteLine("Hello Develop02 World!");
    }
}