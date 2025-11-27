using System;

public class Bike : Vehicle
{
    public override void StartEngine()
    {
        Console.WriteLine("Bike engine has started.");
    }

    public override void StopEngine()
    {
        Console.WriteLine("Bike engine has stopped.");
    }
}