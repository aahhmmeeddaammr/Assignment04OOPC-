using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4OOPC_.Question1
{
    internal class Rectangle :IRectangle
    {
        public float Area { get; set; }

        public void DisplayShapeInfo()
        {
            Console.WriteLine($"Rectangle Area is {Area}");
        }

    }
}
