using System;

class Program
{
    static void Main(string[] args)
    {
        Square sq = new Square("red", 5);
        Rectangle rec = new Rectangle("green", 5, 10);
        Circle cir = new Circle("blue", 3);

        List<Shape> shapes = new List<Shape>();
        shapes.Add(sq);
        shapes.Add(rec);
        shapes.Add(cir);

        foreach (Shape s in shapes)
        {
            double area = s.GetArea();
            string color = s.GetColor();

            Console.WriteLine($"The shape is {color} and has an area of {area}");
        }
    }
}