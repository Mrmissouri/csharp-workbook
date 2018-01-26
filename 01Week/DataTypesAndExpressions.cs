using System;

public class Program
{
    public static void Main()
    {
        bool isHuman = true;

        bool f = false;

        decimal num = 9.99m;

        decimal total = num * num;

        string firstName = "Dwayne";

        string lastName = "Missouri";

        int age = 39;

        string job = "Developer";

        string favoriteBand = "The Gap Band";

        string favoriteSportsTeam = "Washington Redskins";

        Console.WriteLine("First Name: " + firstName);
        Console.WriteLine("Last Name: " + lastName);
        Console.WriteLine("Age: " + age);
        Console.WriteLine("Job: " + job);
        Console.WriteLine("Favorite Band: " + favoriteBand);
        Console.WriteLine("Favorite Sports Team: " + favoriteSportsTeam);

        int myInteger = (int)num;



        // leave this command at the end so your program does not close automatically
        Console.ReadLine();
    }
}
