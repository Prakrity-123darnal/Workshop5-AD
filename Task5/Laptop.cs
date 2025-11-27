using System;

public class Laptop : ElectronicDevice
{
    public Laptop(string brand, double price) : base(brand, price)
    {
    }

    public void TurnOnBattery()
    {
        Console.WriteLine($"{Brand} laptop battery turned on.");
    }

    public override void ShowInfo()
    {
        Console.WriteLine($"Laptop Brand: {Brand}, Price: {Price}");
    }
}