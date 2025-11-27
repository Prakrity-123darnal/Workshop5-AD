using System;
using System.Collections.Generic;

public class ElectronicsStore
{
    private List<ElectronicDevice> devices = new List<ElectronicDevice>();

    public void AddDevice(ElectronicDevice device)
    {
        devices.Add(device);
        Console.WriteLine($"{device.Brand} added to the store.");
    }

    public void RemoveDevice(ElectronicDevice device)
    {
        devices.Remove(device);
        Console.WriteLine($"{device.Brand} removed from the store.");
    }

    public void ShowAllDeviceDetails()
    {
        foreach (var device in devices)
        {
            device.ShowInfo();

            if (device is Laptop laptop)
            {
                laptop.TurnOnBattery();
            }

            if (device is Smartphone phone)
            {
                phone.EnableCamera();
            }

            Console.WriteLine();
        }
    }
}