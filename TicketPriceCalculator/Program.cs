using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== Ticket Price Calculator ===");

        // Ask user to enter age
        Console.Write("Enter your age: ");
        int age;

        // Validate input
        bool isValid = int.TryParse(Console.ReadLine(), out age);

        if (!isValid || age < 0)
        {
            Console.WriteLine("Invalid age entered. Please enter a valid number.");
            return;
        }

        // Determine ticket price
        int price;

        if (age <= 12 || age >= 65)
        {
            price = 7; // Discounted price
        }
        else
        {
            price = 10; // Regular price
        }

        // Display result
        Console.WriteLine($"Ticket Price: GHC{price}");
    }
}