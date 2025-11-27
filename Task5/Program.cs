using System;

class Program
{
    static void Main(string[] args)
    {
        ElectronicsStore store = new ElectronicsStore();

        Laptop laptop = new Laptop("Dell", 95000);
        Smartphone phone = new Smartphone("Samsung", 65000);

        store.AddDevice(laptop);
        store.AddDevice(phone);

        Console.WriteLine("\nShowing all device details:\n");
        store.ShowAllDeviceDetails();
    }
}