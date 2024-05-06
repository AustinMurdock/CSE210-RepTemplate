// using Internal;
using System;

/*
[          Person          ]    Class: Person
[--------------------------]    Attributes:
[ - givenName: string      ]     - givenName : string
[ - familyName: string     ]     - familyName : string
[--------------------------]    Behaviors:
[ + EasternName: (...) void]     + EasternStyleName() : void
[ + WesternName: (...) void]     + WesternStyleName() : void
*/

class Person {
    // private is default,
    // _ indicates "devs, treat this as private",
    // to not get confused with variables in the main program:
    private string givenName;
    private string familyName;

    // constructor instantiates?,
    // other languages would use term "constructor":
    public Person(string givenName, string familyName) {
        this.givenName = givenName; // set property givenName to arg givenName
        this.familyName = familyName;
    }

    public void EasternStyleName() {
        // this. assumes bcz can't find in scope, 
        // so reference stated strings above:
        Console.WriteLine($"{this.familyName}, {this.givenName}");
    }

    public void WesternStyleName() {
        Console.WriteLine($"{this.givenName} {this.familyName}");
    }
}