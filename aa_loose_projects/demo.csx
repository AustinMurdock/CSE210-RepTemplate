// ".cs" = C#,
// ".csx" = C# script
// capital folder names indicate projects

using System; // have to import everything, including System
// using Internal; // or import Internal (system)

// Console is a class, WriteLine is a method:
Console.WriteLine();
Console.WriteLine("Hello world?");

// C#'s version of Python's input:
Console.Write("input: "); // no newline after Write method
string user_response = Console.ReadLine();

// f-string ->
Console.WriteLine($"ok, {user_response}.");
// '' is only used with character data type, saving a single character

if (user_response != "yes" && user_response != "no") {
    Console.WriteLine("no match with \"yes\" or \"no\".");
}

Console.WriteLine();
Console.WriteLine();
