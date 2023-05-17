using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        Square squ1 = new Square("Red", 5);
        shapes.Add(squ1);

        Rectangle rec1 = new Rectangle("blue", 7, 15);
        shapes.Add(rec1);

        Circle circ1 = new Circle("orange", 15);
        shapes.Add(circ1);

        foreach (Shape shape in shapes)
        {
            double area = shape.GetArea();
            Console.WriteLine($"Object with the color {shape.GetColor()} has an area of {area}");
        }
    }
}