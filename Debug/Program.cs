using System;
using SquareLib;

namespace Debug
{
    class Program
    {
        static void Main(string[] args)
        {
            IFigure triangle = new Triangle(3, 4, 5);
            Console.WriteLine(triangle.Square());

            IFigure circle = new Circle(2);
            Console.WriteLine(circle.Square());
        }
    }
}