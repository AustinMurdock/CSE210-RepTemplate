using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine();

        string userInput;
        string fileName;
        
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

            if (userInput == "write") {
                Console.WriteLine(Prompts.GetPrompt());
            }
            else if (userInput == "display") {
                ;
            }
            else if (userInput == "save") {
                ;
            }
            else if (userInput == "load") {
                ;
            }
            else if (userInput == "exit") {
                break;
            }
            else {
                Console.WriteLine("Invalid input, try again.");
            }
        }

        Console.WriteLine("\n");
        // Console.WriteLine("Hello Develop02 World!");
    }
}