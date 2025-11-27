class Program
{
    static void Main(string[] args)
    {
        // Car object
        Car car = new Car
        {
            Brand = "Toyota",
            Speed = 180,
            Seats = 5
        };

        car.Start();
        car.DisplayInfo();
        car.Stop();

        Console.WriteLine();

        // Motorcycle object
        Motorcycle bike = new Motorcycle
        {
            Brand = "Yamaha",
            Speed = 120,
            HasCarrier = true
        };

        bike.Start();
        bike.DisplayInfo();
        bike.Stop();
    }
}