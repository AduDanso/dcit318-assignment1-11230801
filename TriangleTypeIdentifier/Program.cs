using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== Triangle Type Identifier ===");

        // Prompt the user to enter three side lengths
        Console.Write("Enter length of side 1: ");
        double side1 = ReadSide();

        Console.Write("Enter length of side 2: ");
        double side2 = ReadSide();

        Console.Write("Enter length of side 3: ");
        double side3 = ReadSide();

        // Check for triangle validity using triangle inequality theorem
        if (IsValidTriangle(side1, side2, side3))
        {
            // Identify the type of triangle
            if (side1 == side2 && side2 == side3)
                Console.WriteLine("Triangle Type: Equilateral");
            else if (side1 == side2 || side1 == side3 || side2 == side3)
                Console.WriteLine("Triangle Type: Isosceles");
            else
                Console.WriteLine("Triangle Type: Scalene");
        }
        else
        {
            Console.WriteLine("The values entered cannot form a valid triangle.");
        }
    }

    // Method to read and validate a side length
    static double ReadSide()
    {
        double side;
        while (!double.TryParse(Console.ReadLine(), out side) || side <= 0)
        {
            Console.Write("Invalid input. Please enter a positive number: ");
        }
        return side;
    }

    // Method to check triangle validity
    static bool IsValidTriangle(double a, double b, double c)
    {
        return a + b > c && a + c > b && b + c > a;
    }
}
