using System;

/*
[Turned in late, at 5 in the morning]

(Possibly) Exceeding Requirements:

In general I tried to make the program well-structured and 
clean/easy-to-use, which also involved creating an extra class Interface.cs 
for the user interface/input management. All text displayed to the user 
should only be in that class, except for some whitespace in this 
Program.cs file, and the prompt strings in Prompts.cs.

It also involved some basic error checking for inputs related to menu 
options, blank journal names, and trying to load missing files. The only 
significant errors I can think of right now are if someone tries to make a 
new journal with the same name as a previous one, which can overwrite the 
previous saved file, and low file security in general.

I also tried to learn about basic {get; set;} variables, which caused 
some issues with naming conventions, but it works out well enough for now.

*/

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine();
        
        // program starts, create a starting journal for journalInterface:
        Journal initialJournal = new();
        Interface journalInterface = new(initialJournal);
        
        // loop OptionsPrompt() until JournalAct() is false:
        while (true) {
            journalInterface.OptionsPrompt();

            Console.WriteLine();

            if (!journalInterface.JournalAct()) {
                break;
            }

            Console.WriteLine();
        }

        Console.WriteLine("\n");
        // Console.WriteLine("Hello Develop02 World!");
    }
}