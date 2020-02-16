using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Colors colors = new Colors();
            Shapes shapes = new Shapes();

            colors.Color = "red";
            shapes.Shape = "triangle";

            colors.setColor();
            shapes.setShape();
            Console.WriteLine("Figure stats: " + colors.Color + ", " + shapes.Shape);
            Console.ReadKey();
        }
    }
}
