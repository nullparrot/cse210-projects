using System;

class Program
{
    static void Main(string[] args)
    {

        // Square peg = new Square(2.5,"Red");
        // Console.WriteLine($"Square Color: {peg.GetColor()}");
        // Console.WriteLine($"Square Area: {peg.GetArea()} units^2");

        // Circle hole = new Circle(2.5,"Green");
        // Console.WriteLine($"Circle Color: {hole.GetColor()}");
        // Console.WriteLine($"Circle Area: {hole.GetArea()} units^2");

        // Rectangle box = new Rectangle(2.5,5,"Blue");
        // Console.WriteLine($"Rectangle Color: {box.GetColor()}");
        // Console.WriteLine($"Rectangle Area: {box.GetArea()} units^2");


        List<Shape> myShapes = new List<Shape>();
        myShapes.Add(new Square(3.4,"Cyan"));
        myShapes.Add(new Circle(3.0,"Magenta"));
        myShapes.Add(new Rectangle(4.2,12.1,"Yellow"));
        foreach(Shape someShape in myShapes){
            Console.WriteLine($"Shape Color: {someShape.GetColor()}");
            Console.WriteLine($"Shape Area: {someShape.GetArea()} units^2");
        }
    }
}