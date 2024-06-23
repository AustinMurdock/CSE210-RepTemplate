
class Program
{
    static void Main()
    {
        Console.WriteLine();

        House userHouse = new([
            new Room([
                new SmartLight("FancyLightA"),
                new SmartLight("FancyLightB"),
                new SmartTv("Dell Optiplex 9010"),
                new SmartHeater("Heat-inator 5000")
            ]),
            new Room([
                new SmartLight("FancierLight"),
                new SmartLight("FanciestLight"),
                new SmartHeater("The Sun")
            ]),
            new Room([

            ])
        ]);
        
        Console.WriteLine($"Report all devices in all {userHouse.GetRooms().Count} rooms:");
        foreach (Room room in userHouse.GetRooms()) {
            Console.WriteLine(room.ReportAll());
        }

        Console.WriteLine();
        
        Console.WriteLine("Toggle all lights in 1st room, then report state of all devices & all running devices in 1st room:");
        userHouse.GetRooms()[0].ToggleAllLights();
        Console.WriteLine(userHouse.GetRooms()[0].ReportAll());
        Console.WriteLine(userHouse.GetRooms()[0].ReportAllRunning());

        Console.WriteLine();
        
        Console.WriteLine("Toggle all devices in 1st room & toggle \"FancyLightB\" in 1st room, then report state of all devices, all running devices, & longest running device in 1st room");
        userHouse.GetRooms()[0].ToggleAllDevices();
        userHouse.GetRooms()[0].ToggleDevice("FancyLightB");
        Console.WriteLine(userHouse.GetRooms()[0].ReportAll());
        Console.WriteLine(userHouse.GetRooms()[0].ReportAllRunning());
        Console.WriteLine(userHouse.GetRooms()[0].ReportLongestRunning());

        Console.WriteLine();
        Console.WriteLine();

        // Console.WriteLine("Hello Sandbox World!");
    }
}