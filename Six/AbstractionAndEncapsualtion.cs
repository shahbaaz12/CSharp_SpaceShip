using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Five;

namespace Six
{
    class AbstractionAndEncapsualtion
    {
        static void Main(string[] args)
        {
            PInterval one = new PInterval();
            //this will break if var time changes to 2 vars hour and min
            one.time = 125;
            Interval two = new Interval();
            two.SetTime(125);
            Console.WriteLine();

        }
    }
}
