using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4OOPC_.Interface
{
    internal class SeriesByFour : ISeries
    {
        public int Current { get; set; }
        public void getNext()
        {
            Current += 4;
        }
    }
}
