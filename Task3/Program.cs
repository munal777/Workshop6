internal class Program
{

    public static void ProcessNumbers(int[] numbers, Func<int, bool> condition)
    {
        foreach (var n in numbers)
        {
            if (condition(n))
            {
                Console.WriteLine(n);
            }
        }
    }
    public static void Main(string[] args)
    {
        int[] nums = { 2, 5, 12, 8, 15, 20 };

        ProcessNumbers(nums, n => n % 2 == 0);
        Console.WriteLine("num 2");

        ProcessNumbers(nums, n => n > 10);
       

    }




}