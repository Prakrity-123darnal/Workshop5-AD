using System;

class Program
{
    static void Main(string[] args)
    {
        Car car = new Car();
        Bike bike = new Bike();

        Console.WriteLine("Car:");
        car.Display();
        car.StartEngine();
        car.StopEngine();

        Console.WriteLine();

        Console.WriteLine("Bike:");
        bike.Display();
        bike.StartEngine();
        bike.StopEngine();
    }
}