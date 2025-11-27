using System;

public class Teacher
{
    public string Name { get; set; }

    public virtual void Teaching()
    {
        Console.WriteLine("Teacher teaches in English");
    }

    public sealed void SalaryInfo()
    {
        Console.WriteLine("This teacher earns a fixed monthly salary.");
    }
}

public class NepaliTeacher : Teacher
{
    public override void Teaching()
    {
        Console.WriteLine("Nepali Teacher teaches in Nepali language");
    }
}

public class EnglishTeacher: Teacher
{
    // No override needed; inherits Teaching() method as it is
}