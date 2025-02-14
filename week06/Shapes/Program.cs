using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
      List<Shape> shapes = new List<Shape>
        {
            new Square("Yellow", 5),
            new Rectangle("Blue", 4, 6),
            new Circle("Red", 3)
        };

        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"Shape Color: {shape.GetColor()}");
            Console.WriteLine($"Shape Area: {shape.GetArea():F2}");
            Console.WriteLine();
        }
    }
}