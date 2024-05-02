using System;

static void Main() {
    // void function returns nothing, int function returns int:
    static int AddNumbers(int a, int b) {
        int result = a + b;
        return result;
    }

    Console.WriteLine("Counting from 1 to 5:");
    // i++; i+=1; i=i+1:
    for (int i = 1; i <= 5; i++) {
        // i++; // increment value by 1
        Console.WriteLine(i);
    }

    // Console.WriteLine("Counting from 1 to 5:")
    // for (int i = len(list); i < 0; i--){ // i++; i+=1; i=i+1
    //     ;
    // }


    List<string> fruits = new List<string>();

    fruits.Add("Apple");
    fruits.Add("Banan");
    
    // .Count is a property return statement
    Console.WriteLine($"{fruits.Count} items in list \"fruits\":");
    foreach (string fruit in fruits) {
        Console.WriteLine(fruit);
    }
    // create "Random" class instance:
    Random RandomGenerator1 = new Random(); 
    int number = RandomGenerator1.Next(1, 11);
    Console.WriteLine(number);

}

Main();