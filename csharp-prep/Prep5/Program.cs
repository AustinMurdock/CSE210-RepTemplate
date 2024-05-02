using System;
// using Internal;

class Program {
    static void Main(string[] args) {
        string usersName;
        int usersInt;
        int usersResult;

        Console.WriteLine();

        DisplayWelcome();
        usersName = PromptUserName();
        usersInt = PromptUserInt();
        usersResult = SquareNumber(usersInt);
        DisplayResult(usersName, usersResult);

        Console.WriteLine("\n");
    }

    static void DisplayWelcome() {
        Console.WriteLine(" - Program Start - ");
    }

    static string PromptUserName() {
        Console.Write("Enter your name: ");
        return Console.ReadLine();
    }

    static int PromptUserInt() {
        Console.Write("Enter an integer: ");
        return int.Parse(Console.ReadLine());
    }

    static int SquareNumber(int input) {
        // Math.Pow returns a "double" data type, 
        // can be converted by (int) casting or Math.Truncate, which both floor,
        // or Convert.ToInt32, which rounds - storage not being variable is annoying though:
        return Convert.ToInt32(Math.Pow(input, 2));
        // can also just (input * input) in this situation
    }

    static void DisplayResult(string name, int square) {
        Console.WriteLine($"\"{name}\"; User-input integer squared: {square}");
    }
}