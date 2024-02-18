using System;
using System.Drawing;

class Program
{
    static void Main(string[] args)
    {

        List<Shape> shapes = new();

        Square shape1 = new("Red", 3);
        Rectangle shape2 = new("Blue",4, 5);
        Circle shape3 = new("Green", 6);

        shapes.Add(shape1);
        shapes.Add(shape2);
        shapes.Add(shape3);

        foreach (Shape shape in shapes)
        {
            string color = shape.GetColor();
            double area = shape.GetArea();
            Console.WriteLine($"The {color} shape has an area of {area}.");
        };

    }
}