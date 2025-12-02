using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;

public delegate int Calculate(int a, int b);
public delegate double DiscountStrategy(double price);

class Program
{
    public static int Add(int a, int b) => a+b;
    public static int Subtract(int a, int b) => a-b;
    public static double FestivalDiscount(double price) => price * 0.80; 
    public static double SeasonalDiscount(double price) => price * 0.90; 
    public static double NoDiscount(double price) => price;

    public static double CalculateFinalPrice(double originalPrice, DiscountStrategy ds) => ds(originalPrice);

    public static void Main()
    {
        Calculate a = Add;
        Console.WriteLine(a(1,2));

        Calculate b = Subtract;
        Console.WriteLine(b(2,3));

        double FestivalPrice = CalculateFinalPrice(1200, FestivalDiscount);
        Console.WriteLine(FestivalPrice);

        double SeasonalPrice = CalculateFinalPrice(1200, SeasonalDiscount);
        Console.WriteLine(SeasonalPrice);

        double realPrice = CalculateFinalPrice(1200, NoDiscount);
        Console.WriteLine(realPrice);
    }

}