using System;

class Program
{
    static void Main(string[] args)
    {
        Square MySquare = new Square("Red", 3.5);
       /*  Console.WriteLine(MySquare.GetColor());
        Console.WriteLine(MySquare.GetArea()); */

        Rectangle MyRectangle = new Rectangle("Blue", 6.5, 10);
        /* Console.WriteLine(MyRectangle.GetColor());
        Console.WriteLine(MyRectangle.GetArea()); */

        Circle MyCircle = new Circle("Black", 4);
       /*  Console.WriteLine(MyCircle.GetColor());
        Console.WriteLine(MyCircle.GetArea()); */

        List<Shape> shapes = new List<Shape>();
        shapes.Add(MySquare);
        shapes.Add(MyRectangle);
        shapes.Add(MyCircle);

        foreach (Shape s in shapes)
        {
            Console.WriteLine($"The {s.GetColor()} shape has an area of {s.GetArea()} ");
        }

    }
}