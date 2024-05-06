using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Learning02 World!";

        Person fred = new Person("Fred", "Flinstone"); // seperate instances
        // fred.givenName = "Fred"; // can't be changed directly when private
        // fred.familyName = "Flinstone";
        Person steve = new Person("Steve", "Minecraft");
        // steve.givenName = "Steve";
        // steve.familyName = "Minecraft";
        
        fred.EasternStyleName();
        steve.WesternStyleName();
    }
}