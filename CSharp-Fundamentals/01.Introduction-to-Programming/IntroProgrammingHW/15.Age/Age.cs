using System;

class Age
{
    static void Main()
    {
        string birthdateAsString = Console.ReadLine();

        var birthDate = DateTime.Parse(birthdateAsString);
        int ageNow = (DateTime.Now - birthDate).Days / 365;
        int ageAfterTenYers = ageNow + 10;

        Console.WriteLine(ageNow);
        Console.WriteLine(ageAfterTenYers);
    }
}

