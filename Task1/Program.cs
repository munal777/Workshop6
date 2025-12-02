class Program
{
    static void Main(string[] args)
    {
        Rectangle rect1 = new Rectangle();
        double l = 3;
        double b = 2;
        rect1.Length = l;
        rect1.Breadth = b;

        Console.WriteLine(rect1.ShowDetails());
        Console.WriteLine($"Area: {rect1.GetArea()}");
        Console.WriteLine($"Perimeter: {rect1.GetPerimeter()}");
    }
}