using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Colors
    {
        private string _color;

        public string Color
        {
            get { return _color; }
            set { _color = value; }
        }

        public void setColor()
        {
            Console.WriteLine("Colour is " + Color);
        }
    }
}
