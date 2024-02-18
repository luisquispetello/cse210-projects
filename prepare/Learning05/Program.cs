using System;
using System.Drawing;

class Program
{
    static void Main(string[] args)
    {

        List<Shape> shapes = new()
        {
            new Square("Red", 3),
            new Rectangle("Blue",4, 5),
            new Circle("Green", 6)
        };


        foreach (Shape shape in shapes)
        {
            string color = shape.GetColor();
            double area = shape.GetArea();
            Console.WriteLine($"The {color} shape has an area of {area}.");
        };

    }
}