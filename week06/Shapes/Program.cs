using System;
using System.Formats.Asn1;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Shapes Project.");

        Square shape1 = new Square("blue", 2);
        Console.WriteLine($"The color is {shape1.GetColor()} and the area {shape1.GetArea()}");

        Rectangle shape2 = new Rectangle("red", 2, 4);
        Console.WriteLine($"The color is {shape2.GetColor()} and the area {shape2.GetArea()}");

        Circle shape3 = new Circle("yellow", 2);
        Console.WriteLine($"The color is {shape3.GetColor()} and the area {shape3.GetArea()}");

        Console.WriteLine("");

        List<Shape> shapes = new List<Shape>();
        shapes.Add(new Square("blue", 2));
        shapes.Add(new Rectangle("red", 2, 4));
        shapes.Add(new Circle("yellow", 2));

        foreach (Shape shape in shapes)
        {
            string color = shape.GetColor();
            double area = shape.GetArea();

            Console.WriteLine($"The color is {color} and the area {area}");
        }
    }
}