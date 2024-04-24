// ".cs" = C#,
// ".csx" = C# script
// capital folder names indicate projects

using System; // have to import everything, including System
// using Internal; // or import Internal (system)

// Console is a class, WriteLine is a method:
Console.WriteLine("Hello world?");

// C#'s version of Python's input:
string user_response = Console.ReadLine();

// f-string ->
Console.WriteLine($"ok, {user_response}.");
// '' is only used with character data type, saving a single character
