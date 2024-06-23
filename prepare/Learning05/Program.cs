
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine();

        List<Shape> shapes = new();
        shapes.Add(new Square("blue", 3.6));
        shapes.Add(new Square("red", 1));
        shapes.Add(new Circle("green", 3));
        shapes.Add(new Rectangle("red", 5, 0));
        shapes.Add(new Rectangle("red", 5, 12.54));

        foreach (Shape shape in shapes) {
            Console.WriteLine($"Color {shape.GetColor()}, Area {shape.GetArea()}");
        }

        Console.WriteLine();
        Console.WriteLine();

        // Console.WriteLine("Hello Learning05 World!");
    }
}