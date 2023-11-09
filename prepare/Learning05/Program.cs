using System;
using System.Reflection.Metadata.Ecma335;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapeList = new List<Shape>();

        Square s = new Square("Green", 7);
        shapeList.Add(s);

        Rectangle r = new Rectangle("Purple", 5, 4);
        shapeList.Add(r);

        Circle c = new Circle("Blue", 3);
        shapeList.Add(c);

        foreach (Shape shape in shapeList)
        {
            Console.WriteLine(shape.GetColor());
            Console.WriteLine(shape.GetArea());
        } 
    }
}