class Program
{
    static void Main()
    {
        var bookings = new List<Booking>
            {
                new Booking { CustomerName = "Arjun", Destination = "Bandipur", Price = 9000, DurationInDay = 4, IsInternational = false },
                new Booking { CustomerName = "Sneha", Destination = "Malaysia", Price = 52000, DurationInDay = 7, IsInternational = true },
                new Booking { CustomerName = "Rabin", Destination = "Janakpur", Price = 11000, DurationInDay = 3, IsInternational = false },
                new Booking { CustomerName = "Kritika", Destination = "Qatar", Price = 58000, DurationInDay = 6, IsInternational = true },
                new Booking { CustomerName = "Bikash", Destination = "Ilam", Price = 14000, DurationInDay = 4, IsInternational = false }
            };

        var filtered = bookings.Where(b => b.Price > 10000 && b.DurationInDay > 4);

        var projected = filtered.Select(b => new
        {
            b.CustomerName,
            b.Destination,
            b.Price,
            Category = b.IsInternational ? "International" : "Domestic"
        });

        var sorted = projected
            .OrderBy(b => b.Category)       
            .ThenBy(b => b.Price)           
            .ToList();

        Console.WriteLine("Filtered, Transformed and Sorted Tours:\n");
        foreach (var b in sorted)
        {
            Console.WriteLine($"Customer: {b.CustomerName}\nDestination: {b.Destination}\nCategory: {b.Category}\nPrice: Rs. {b.Price}\n------------------------");
        }
    }
}