using System;

public class Car : Vehicle
{
    public override void StartEngine()
    {
        Console.WriteLine("Car engine has started.");
    }

    public override void StopEngine()
    {
        Console.WriteLine("Car engine has stopped.");
    }
}