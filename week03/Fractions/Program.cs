using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction f1 = new Fraction();
        Console.WriteLine(f1.GetFractionString());
        Console.WriteLine(f1.GetDecimalValue());

        Fraction f2 = new Fraction(5);
        Console.WriteLine(f2.GetFractionString());
        Console.WriteLine(f2.GetDecimalValue());

        Fraction f3 = new Fraction(3, 4);
        Console.WriteLine(f3.GetFractionString());
        Console.WriteLine(f3.GetDecimalValue());

        Fraction f4 = new Fraction(1, 3);
        Console.WriteLine(f4.GetFractionString());
        Console.WriteLine(f4.GetDecimalValue());

        // Testing getters and setters
        f1.SetTop(4);
        f1.SetBottom(5);
        Console.WriteLine(f1.GetFractionString()); // 4/5
        Console.WriteLine(f1.GetDecimalValue());  // 0.8

        // Testing invalid denominator
        f1.SetBottom(0); // Should display an error message
        Console.WriteLine(f1.GetFractionString()); // 7/8 (unc
    }
}