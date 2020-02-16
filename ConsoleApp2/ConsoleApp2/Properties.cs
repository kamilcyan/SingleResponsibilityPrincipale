using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Properties
    {
        public string Color { get; set; }
        public string Shape { get; set; }

        public void objectProperties()
        {
            Console.WriteLine("Object shape is " + Shape);
            Console.WriteLine("Object color is " + Color);
        }
    }
}
