using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4OOPC_.Question1
{
    internal class Circle : ICircle
    {
        public float Area { get; set; }

        public void DisplayShapeInfo()
        {
            Console.WriteLine($"Circle Area is {Area}");
        }

    }
}
