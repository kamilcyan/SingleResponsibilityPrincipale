using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Shapes
    {
        private string _shape;      

        public string Shape
        {
            get { return _shape; }
            set { _shape = value; }
        }

        public void setShape()
        {
            Console.WriteLine("Shape is " + Shape);
        }
    }
}
