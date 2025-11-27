class Program
{
    static void Main(string[] args)
    {
        Printer p = new Printer();

        // Call Print(string)
        p.Print("Hello, Prakrity!");

        // Call Print(int)
        p.Print(2025);

        // Call Print(string, int)
        p.Print("Repeated message", 3);
    }
}