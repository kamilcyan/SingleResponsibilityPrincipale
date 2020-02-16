using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Properties properties = new Properties();

            properties.Color = "red";
            properties.Shape = "triangle";

            properties.objectProperties();
            Console.WriteLine("Object properties: " + properties.Color + " " + properties.Shape);
            Console.ReadKey();
        }
    }
}
