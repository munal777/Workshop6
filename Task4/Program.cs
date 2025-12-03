class Program
{
    public static void Main()
    {
        var numbers = new List<int> { 1, 2, 3, 4, 5 };
        var squaredNumbers = numbers.Select(n => n * n).ToList();

        Console.WriteLine("Squared Numbers:");
        squaredNumbers.ForEach(n => Console.WriteLine(n));


         var books = new List<Book>
            {
                new Book { Title = "C# Basics", Price = 800 },
                new Book { Title = "Advanced C#", Price = 1500 },
                new Book { Title = "LINQ Deep Dive", Price = 1200 },
                new Book { Title = "Intro to SQL", Price = 600 }
            };

        var premiumBooks = books.Where(b => b.Price > 1000).ToList();

        Console.WriteLine("\nPremium Books (Price > 1000):");
        premiumBooks.ForEach(b => Console.WriteLine($"{b.Title} - Rs. {b.Price}"));


        var students = new List<Student>
            {
                new Student { Name = "Nikesh" },
                new Student { Name = "Madan" },
                new Student { Name = "Rohan" },
                new Student { Name = "Bikash" },
                new Student { Name = "Rina" },
                new Student { Name = "Manoj" },
                new Student { Name = "Anish" },
                new Student { Name = "Puja" },
                new Student { Name = "Dipesh" },
                new Student { Name = "Hari" }
            };

        var sortedStudents = students.OrderBy(s => s.Name).ToList();

        Console.WriteLine("\nAAA Scholarship Students (Alphabetically Sorted):");
        sortedStudents.ForEach(s => Console.WriteLine(s.Name));
    }
}
