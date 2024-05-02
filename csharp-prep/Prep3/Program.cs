// using System;
// using Internal;

class Program {
    static void Main(string[] args) {
        // not static class method, so doesn't work?:
        // int hiddenVal = Random.Next(1, 101); 
        Random RandGen1 = new Random();
        int hiddenVal;
        int response;
        int guessCount;
        string willPlayAgain;

        do {
            hiddenVal = RandGen1.Next(1, 101); // .Next( <= x < )
            guessCount = 0;

            // Console.WriteLine(hiddenVal);

            Console.WriteLine();

            do {
                Console.Write("Enter an integer in the range [1,100]: ");
                response = int.Parse(Console.ReadLine());
                guessCount++;
                // response conditionals:
                if (response == hiddenVal) {
                    Console.WriteLine();
                    Console.WriteLine($"Correct, the hidden value is {hiddenVal}.");
                    Console.WriteLine($"# of guesses: {guessCount}");
                }
                else if (response < hiddenVal) {
                    Console.WriteLine("Guess higher -");
                }
                else if (response > hiddenVal) {
                    Console.WriteLine("Guess lower -");
                }
                else { // shouldn't ever run
                    Console.WriteLine("Invalid case, try again.");
                }
            } while (response != hiddenVal);
            
            Console.WriteLine();
            Console.Write("Do you want to play again? (y/n): ");
            willPlayAgain = Console.ReadLine();

        } while (willPlayAgain == "yes" || willPlayAgain == "y");
        
        Console.WriteLine("\n");
    }
}