using System;

class Program
{
    static void Main()
    {
        Console.WriteLine();

        Order order1 = new([
            new Product("Asus TUF A16", "37vn3220vg3", 790.30f, 1),
            new Product("Dell 3.5 Hard Drive Caddy", "DN8MY", 6.79f, 2)
        ], "Bilboy Baggins", "2167 MilkyWay Ave.", "San Fransisco", "CA", "United States");
        Order order2 = new([
            new Product("SSD M2 2.5mm 3mm SATA M.2 Mounting Screws Set", "7vq4b0", 6.99f, 1),
            new Product("Lucky Block Hard Drives", "q3v68b30b", 96.95f, 2),
            new Product("GV Fruit Smiles 40 Count", "n70w34b", 7.56f, 50)
        ], "Gnome Ann", "Main Street #1", "Punk Hazard", "TheNorthernlands", "Zimbabwe");
        
        Console.WriteLine("Order 1:");
        Console.WriteLine($"{order1.GetPackingLabel()}");
        Console.WriteLine($"{order1.GetShippingLabelBlockF()}");
        Console.WriteLine($"\nTotal Cost ${order1.GetTotalCost()}");

        Console.WriteLine();
        Console.WriteLine();
        
        Console.WriteLine("Order 2:");
        Console.WriteLine($"{order2.GetPackingLabel()}");
        Console.WriteLine($"{order2.GetShippingLabelBlockF()}");
        Console.WriteLine($"\nTotal Cost ${order2.GetTotalCost()}");

        Console.WriteLine();
        Console.WriteLine();

        // Console.WriteLine("Hello Foundation2 World!");
    }
}